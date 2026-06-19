using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketChecker.Telas;
using Npgsql;

namespace TicketChecker
{
    public partial class Inicio: Form
    {
        

        public Inicio()
        {
            //testarConexao();
            InitializeComponent();
        }

        private void cadastrarFuncionarioClickListener(object sender, EventArgs e)
        {
            TelaManipulacaoFuncionario cadastro = new TelaManipulacaoFuncionario("Cadastrar Funcionário", true);
            cadastro.ShowDialog();
        }

        private void editarFuncionarioClickListener(object sender, EventArgs e)
        {
            TelaManipulacaoFuncionario edicao = new TelaManipulacaoFuncionario("Editar Funcionário", false);
            edicao.ShowDialog();
        }
        private void editarTicketClickListener(object sender, EventArgs e)
        {
            TelaManipulacaoTicket edicao = new TelaManipulacaoTicket("Editar Ticket", false);
            edicao.ShowDialog();
        }
        private void cadastraTicketClickListener(object sender, EventArgs e)
        {
            TelaManipulacaoTicket cadastro = new TelaManipulacaoTicket("Cadastrar Ticket", true);
            cadastro.ShowDialog();
        }
        

    }
}
