using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketChecker.Telas
{
    
    public partial class telaManipulacaoTicket: Form
    {
        bool cadastro = false;
        public telaManipulacaoTicket(String nomeTela, bool cadastro = false)
        {

            this.cadastro = cadastro;
            InitializeComponent();
            this.Text = nomeTela;
            if (cadastro)
            {
                this.labelMenuTicket.Text = "Insira os dados";
            }
            else
            {
                this.labelMenuTicket.Text = "Edite os dados";
            }

        }
        private void retornarClickListener(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarFuncionarioClickListener(object sender, EventArgs e)
        {
            telaBusca buscarFuncionario = new telaBusca();
            buscarFuncionario.ShowDialog();
        }
    }
}
