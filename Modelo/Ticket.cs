using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketChecker.Modelo
{
    class Ticket
    {
        public int id { get; set; }
        public int idFuncionario { get; set; }
        public int quantidade { get; set; }
        public char situacao { get; set; }
        public DateTime dataEntrega { get; set; }

        public Ticket(int id, int idFuncionario, int quantidade, char situacao, DateTime dataEntrega)
        {
            this.id = id;
            this.idFuncionario = idFuncionario;
            this.quantidade = quantidade;
            this.situacao = situacao;
            this.dataEntrega = dataEntrega;
        }
    }
}
