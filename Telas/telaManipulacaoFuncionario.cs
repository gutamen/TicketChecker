using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TicketChecker.Telas
{
    public partial class telaManipulacaoFuncionario : Form
    {
        bool cadastro = false;
        private long idTemporario;
        public telaManipulacaoFuncionario(String nomeTela, bool cadastro = false)
        {

            this.cadastro = cadastro;
            InitializeComponent();
            this.Text = nomeTela;
            if (cadastro)
            {
                this.labelMenuFuncionario.Text = "Insira os dados";
                this.checkBoxAtivo.Checked = true;
                this.checkBoxAtivo.Enabled = false;
                this.textBoxData.Text = DateTime.Now.ToString();
                
                // Funciona para saber o ID na criação do funcionário, mas pode incrementar o id sem precisar
                idTemporario = Program.ObterProximoIdFuncionario();
                this.textBoxId.Text = idTemporario.ToString();

            }
            else
            {
                this.labelMenuFuncionario.Text = "Editar os dados";
                this.buttonBuscar.Visible = true;
            }

        }

        private void retornarClickListener(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmarClickListener(object sender, EventArgs e)
        {
            if (cadastro)
            {
                switch(Program.VerificaCPF(this.textBoxCPF.Text.ToString()))
                {
                    case 1:
                        MessageBox.Show("CPF com quantidade de digitos invalido.");
                        return;
                    case 2:
                        MessageBox.Show("Somente números são permitidos no CPF.");
                        return;
                    case 3:
                        MessageBox.Show("Já existe esse CPF cadastrado.");
                        return;
                }
                if (this.textBoxNome.Text.Length <= 0)
                {
                    MessageBox.Show("Nenhum nome inserido");
                    return;
                }

                Program.insereFuncionarioBD(this.idTemporario, this.textBoxNome.Text, this.textBoxCPF.Text, checkBoxAtivo.Checked, DateTime.Parse(this.textBoxData.Text));
                
            }
            else
            {

            }
        }
    }
        
}
