using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicketChecker.Modelo
{
    class Funcionario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string CPF { get; set; }
        public char situacao { get; set; }
        public DateTime dataAlteracao { get; set; }

        public Funcionario(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public Funcionario(int id, string nome, string cpf, char situacao, DateTime data)
        {
            this.id = id;
            this.nome = nome;
            this.CPF = cpf;
            this.situacao = situacao;
            this.dataAlteracao = data;
        }
    }
}
