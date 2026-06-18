using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TicketChecker.Telas
{
    public partial class telaManipulacaoFuncionario: Form
    {
        bool cadastro = false;
        public telaManipulacaoFuncionario(String nomeTela, bool cadastro = false)
        {
            
            this.cadastro = cadastro;
            InitializeComponent();
            this.Text = nomeTela;
            if (cadastro)
            {
                this.labelMenuFuncionario.Text = "Insira os dados";
                this.checkBoxAtivo.Checked = true;
                this.textBoxData.Text = DateTime.Now.ToString();
            }
            else
            {
                this.labelMenuFuncionario.Text = "Editar os dados";
            }
                 
        }

        private void retornarClickListener(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
