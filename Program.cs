using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketChecker.Modelo;

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


        public static List<Ticket> buscaTicketsBD()
        {
            List<Ticket> retorno = new List<Ticket>();

            using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoString))
            {
                conexao.Open();

                string sql = @"
                    SELECT id, idfuncionario, quantidade, situacao, dataEntrega  
                        FROM ticket;"; 

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {

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

    }

}
    

