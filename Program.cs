using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static long ObterProximoIdFuncionario()
        {
            using (var conexao = new NpgsqlConnection(conexaoString))
            {
                conexao.Open();

                string sql = "SELECT nextval('funcionario_id_seq');";

                using (var cmd = new NpgsqlCommand(sql, conexao))
                {
                    long proximoId = Convert.ToInt64(cmd.ExecuteScalar());
                    return proximoId;
                }
            }
        }
        public static void testarConexao()
        {
            using (var connection = new NpgsqlConnection(conexaoString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conectado");


                    using (var comando = new NpgsqlCommand("SELECT version()", connection))
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
                Console.WriteLine(i);
                int teste = i;
                Console.WriteLine(teste);
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
            using (var conexao = new NpgsqlConnection(conexaoString))
            {
                conexao.Open();

                string sql = "SELECT cpf from funcionario where cpf='" + CPF + "';";

                using (var comando = new NpgsqlCommand(sql, conexao))
                {
                    Object proximoId = comando.ExecuteScalar();
                    if(proximoId != null)
                    {
                        return 3;
                    }
                }
            }

            return 0;
        }

        public static void insereFuncionarioBD(long id, string nome, string cpf, bool situacao, DateTime data)
        {
            using (var conexao = new NpgsqlConnection(conexaoString))
            {
                conexao.Open();

                string sql = @"
                    INSERT INTO funcionario (id, nome, cpf, situacao, dataalteracao) 
                    VALUES (@id, @nome, @cpf, @situacao, @dataalteracao);";

                using (var comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@cpf", cpf);
                    comando.Parameters.AddWithValue("@situacao", situacao? 'A' : 'I');
                    comando.Parameters.AddWithValue("@dataalteracao", data);

                    comando.ExecuteScalar();
                }
            }
        }

    }

}
    

