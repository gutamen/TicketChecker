using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketChecker.Modelo;
using ClosedXML.Excel;
using System.Data;
using System.IO;

namespace TicketChecker
{
    static class Program
    {
        // string para conexão, programa teste, falha de segurança na prática
        private static string conexaoString = "Host=localhost;Port=5432;Database=ticketChecker;Username=postgres;Password=123;";

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());
        }
        public static int ObterProximoIdFuncionarioBD()
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoString))
            {
                conexao.Open();

                string sql = "SELECT nextval('funcionario_id_seq');";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao))
                {
                    int proximoId = Convert.ToInt32(cmd.ExecuteScalar());
                    return proximoId;
                }
            }
        }

        public static int ObterProximoIdTicketBD()
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoString))
            {
                conexao.Open();

                string sql = "SELECT nextval('ticket_id_seq');";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao))
                {
                    int proximoId = Convert.ToInt32(cmd.ExecuteScalar());
                    return proximoId;
                }
            }
        }

        public static List<Ticket> buscaTicketsPorIdFuncionarioBD(int idFuncionario)
        {
            List<Ticket> retorno = new List<Ticket>();
            
            using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoString))
            {
                conexao.Open();

                string sql = @"
                    SELECT id, idfuncionario, quantidade, situacao, dataEntrega  
                        FROM ticket 
                        WHERE idFuncionario=@idFuncionario;";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {

                    comando.Parameters.AddWithValue("@idFuncionario", idFuncionario);

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            retorno.Add(new Ticket((int)reader["id"], (int)reader["idFuncionario"], (int)reader["quantidade"], ((string)reader["situacao"]).ToCharArray()[0],
                                (DateTime)reader["dataEntrega"]));
                        }
                    }
                }
            }


            return retorno;
        }


        // Ordenação pode variar entre:
        // ID = 0
        // Nome Funcionário = 1
        // Data Entrega = 2
        // Join para utilizar o nome do funcionário na interface
        public static List<Ticket> buscaTicketsBD(Funcionario funcionario = null, int order = 0, DateTime? inicial = null, DateTime? final = null)
        {
            List<Ticket> retorno = new List<Ticket>();

            using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoString))
            {
                conexao.Open();

                bool dataUsada = false;

                string sql = @"
                    SELECT t.id,
                        t.idfuncionario,
                        f.nome AS nomeFuncionario,
                        f.cpf,
                        t.quantidade,
                        t.situacao AS situacaoTicket,
                        t.dataEntrega
                        FROM ticket t
                        JOIN funcionario f ON t.idfuncionario = f.id";

                if(inicial != null && final != null)
                {
                    dataUsada = true;
                    sql += " WHERE dataEntrega BETWEEN '" + inicial.ToString() + "' AND '" + final.ToString() + "'";
                }
                else if(inicial != null)
                {
                    dataUsada = true;
                    sql += " WHERE dataEntrega >= '" + inicial.ToString() + "'";
                }
                else if(final != null)
                {
                    dataUsada = true;
                    sql += " WHERE dataEntrega <= '" + final.ToString() + "'";
                }

                // Se a data for utilizada a cláusula WHERE não é inserida novamente
                if (funcionario != null)
                {
                    sql += dataUsada ? "" : "WHERE" + " idFuncionario=" + funcionario.id.ToString();   
                }

                switch (order)
                {
                    case 0:
                        sql += " ORDER BY id asc";
                        break;
                    case 1:
                        sql += " ORDER BY nomeFuncionario";
                        break;
                    case 2:
                        sql += " ORDER BY dataEntrega";
                        break;
                }

                sql += ";";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    //Console.WriteLine(sql);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            retorno.Add(new Ticket((int)reader["id"], (int)reader["idFuncionario"], (int)reader["quantidade"], ((string)reader["situacaoTicket"]).ToCharArray()[0],
                                (DateTime)reader["dataEntrega"], new Funcionario((int)reader["idFuncionario"], (string)reader["nomeFuncionario"], (string)reader["cpf"])));
                        }
                    }
                }
            }


            return retorno;
        }

        public static void testarConexaoBD()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(conexaoString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conectado");


                    using (NpgsqlCommand comando = new NpgsqlCommand("SELECT version()", connection))
                    {
                        string version = comando.ExecuteScalar().ToString();
                        Console.WriteLine($"Versão: {version}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro ao conectar: {e.Message}");
                }
            }
        }

        // 0 é correto
        // 1 é quantidade de caracteres inválido
        // 2 é contém letras
        // 3 existe no banco
        public static int VerificaCPF(String CPF)
        {
            foreach (char i in CPF.ToCharArray())
            {

                if (i < 48 || i > 57)
                {
                    return 2;
                }
            }

            if (CPF.Length != 11)
            {
                return 1;
            }

            // Verifica se existe já no banco
            using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoString))
            {
                conexao.Open();

                string sql = "SELECT cpf from funcionario where cpf='" + CPF + "';";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    Object proximoId = comando.ExecuteScalar();
                    if (proximoId != null)
                    {
                        return 3;
                    }
                }
            }

            return 0;
        }

        public static void insereFuncionarioBD(long id, string nome, string cpf, bool situacao, DateTime data)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoString))
            {
                conexao.Open();

                string sql = @"
                    INSERT INTO funcionario (id, nome, cpf, situacao, dataalteracao) 
                    VALUES (@id, @nome, @cpf, @situacao, @dataalteracao);";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@cpf", cpf);
                    comando.Parameters.AddWithValue("@situacao", situacao ? 'A' : 'I');
                    comando.Parameters.AddWithValue("@dataalteracao", data);

                    comando.ExecuteScalar();
                }
            }
        }

        public static void insereTicketBD(int id, int idFuncionario, int quantidade, bool situacao, DateTime data)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoString))
            {
                conexao.Open();

                string sql = @"
                    INSERT INTO ticket (id, idfuncionario, quantidade, situacao, dataEntrega) 
                    VALUES (@id, @idfuncionario, @quantidade, @situacao, @dataEntrega);";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@idfuncionario", idFuncionario);
                    comando.Parameters.AddWithValue("@quantidade", quantidade);
                    comando.Parameters.AddWithValue("@situacao", situacao ? 'A' : 'I');
                    comando.Parameters.AddWithValue("@dataEntrega", data);

                    comando.ExecuteScalar();
                }
            }
        }

        public static void alteraFuncionarioBD(long id, string nome, string cpf, bool situacao)
        {
            try
            {
                using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoString))
                {
                    conexao.Open();

                    string sql = @"
                        UPDATE funcionario 
                            SET nome = @nome,
                                cpf = @cpf,
                                situacao = @situacao
                            WHERE id = @id;";

                    using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@id", id);
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@cpf", cpf);
                        comando.Parameters.AddWithValue("@situacao", situacao ? 'A' : 'I');

                        int rows = comando.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi atualizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao atualizar: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public static void alteraTicketBD(int id, int idFuncionario, int quantidade, bool situacao, DateTime dataEntrega)
        {
            try
            {
                using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoString))
                {
                    conexao.Open();

                    string sql = @"
                        UPDATE ticket 
                            SET idFuncionario = @idFuncionario,
                                quantidade = @quantidade,
                                situacao = @situacao,
                                dataEntrega = @dataEntrega
                            WHERE id = @id;";

                    using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@id", id);
                        comando.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                        comando.Parameters.AddWithValue("@quantidade", quantidade);
                        comando.Parameters.AddWithValue("@situacao", situacao ? 'A' : 'I');
                        comando.Parameters.AddWithValue("@dataEntrega", dataEntrega);

                        int rows = comando.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi atualizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao atualizar: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public static List<Funcionario> buscaFuncionariosNomeBD(String nome)
        {
            List<Funcionario> retorno = new List<Funcionario>();

            using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoString))
            {
                conexao.Open();

                string sql = @"
                    SELECT id, nome, cpf 
                        FROM funcionario 
                        WHERE nome ILIKE @nomeBusca
                        ORDER BY nome;";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    
                    comando.Parameters.AddWithValue("@nomeBusca", "%" + nome + "%");

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            retorno.Add(new Funcionario((int)reader["id"], (string)reader["nome"], (string)reader["cpf"]));
                        }
                    }
                }
            }


            return retorno;
        }

        public static Funcionario buscaFuncinarioPorID(int id)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoString))
            {
                conexao.Open();

                string sql = @"
                    SELECT id, nome, cpf, situacao, dataalteracao 
                        FROM funcionario 
                        WHERE id=@id;";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {

                    comando.Parameters.AddWithValue("@id", id);

                    using (var reader = comando.ExecuteReader())
                    {
                        reader.Read();
                        return new Funcionario((int)reader["id"], (string)reader["nome"], (string)reader["cpf"], ((string)reader["situacao"]).ToCharArray()[0], (DateTime)reader["dataalteracao"]);
                    }
                }
            }

            return null;
        }

        public static Ticket buscaTicketPorID(int id)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoString))
            {
                conexao.Open();

                string sql = @"
                    SELECT id, idfuncionario, quantidade, situacao, dataEntrega  
                        FROM ticket 
                        WHERE id=@id;";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {

                    comando.Parameters.AddWithValue("@id", id);

                    using (var reader = comando.ExecuteReader())
                    {
                        reader.Read();
                        return new Ticket((int)reader["id"], (int)reader["idFuncionario"], (int)reader["quantidade"], ((string)reader["situacao"]).ToCharArray()[0],
                                (DateTime)reader["dataEntrega"]);
                    }
                }
            }

            return null;
        }

        public static void gerarRelatorioTickets(List<Ticket> tickets, string tituloRelatorio = "Relatório de Tickets")
        {
            if (tickets == null || tickets.Count == 0)
            {
                MessageBox.Show("A lista de tickets está vazia!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Tickets");

                    // Titúlo
                    worksheet.Cell("A1").Value = tituloRelatorio;
                    worksheet.Cell("A1").Style.Font.Bold = true;
                    worksheet.Cell("A1").Style.Font.FontSize = 14;

                    // Organizar colunas
                    worksheet.Cell("A3").Value = "Ticket ID";
                    worksheet.Cell("B3").Value = "ID Funcionário";
                    worksheet.Cell("C3").Value = "Funcionário";
                    worksheet.Cell("D3").Value = "CPF";
                    worksheet.Cell("E3").Value = "Quantidade";
                    worksheet.Cell("F3").Value = "Situação";
                    worksheet.Cell("G3").Value = "Data de Entrega";

                    // Colorir células
                    var headerRange = worksheet.Range("A3:F3");
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;

                    // Preencher os com a lista de tickets
                    int linha = 4;
                    foreach (var ticket in tickets)
                    {
                        worksheet.Cell($"A{linha}").Value = ticket.id;
                        worksheet.Cell($"B{linha}").Value = ticket.idFuncionario;
                        worksheet.Cell($"C{linha}").Value = ticket.funcionario.nome;
                        worksheet.Cell($"D{linha}").Value = ticket.funcionario.CPF;
                        worksheet.Cell($"E{linha}").Value = ticket.quantidade;
                        worksheet.Cell($"F{linha}").Value = ticket.situacao == 'A' ? "Ativo" : "Inativo";
                        worksheet.Cell($"G{linha}").Value = ticket.dataEntrega;
                        worksheet.Cell($"G{linha}").Style.DateFormat.Format = "dd/MM/yyyy";

                        linha++;
                    }

                    
                    worksheet.Columns().AdjustToContents();

                    // Nome do arquivo, salvo na área de trabalho
                    string nomeArquivo = $"Relatorio_Tickets_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    string caminhoCompleto = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nomeArquivo);

                    workbook.SaveAs(caminhoCompleto);

                    MessageBox.Show($"Relatório gerado com sucesso!\n\nArquivo salvo em:\n{caminhoCompleto}",
                                    "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao gerar relatório: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
    

