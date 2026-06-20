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
using TicketChecker.Modelo;

namespace TicketChecker.Telas
{
    public partial class TelaManipulacaoFuncionario : Form
    {
        bool cadastro = false;
        private int idTemporario = 0;
        private Funcionario funcionario;
        private TelaBuscaFuncionario buscaFuncionario;
        public TelaManipulacaoFuncionario(String nomeTela, bool cadastro = false)
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
                idTemporario = Program.ObterProximoIdFuncionarioBD();
                this.textBoxId.Text = idTemporario.ToString();
                this.ShowDialog();

            }
            else
            {
                this.labelMenuFuncionario.Text = "Editar os dados";
                this.buttonBuscar.Visible = true;
                buscaFuncionario = new TelaBuscaFuncionario(this);
                buscaFuncionario.ShowDialog();
                if (this.Enabled)
                {
                    this.ShowDialog();
                }
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
                switch (Program.VerificaCPF(this.textBoxCPF.Text.ToString()))
                {
                    case 1:
                        MessageBox.Show("CPF com quantidade de digitos invalido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    case 2:
                        MessageBox.Show("Somente números são permitidos no CPF.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    case 3:
                        MessageBox.Show("Já existe esse CPF cadastrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                switch (Program.VerificaCPF(this.textBoxCPF.Text.ToString()))
                {
                    case 1:
                        MessageBox.Show("CPF com quantidade de digitos invalido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    case 2:
                        MessageBox.Show("Somente números são permitidos no CPF.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    case 3:
                        if (funcionario.CPF != this.textBoxCPF.Text.ToString())
                        {
                            MessageBox.Show("Já existe esse CPF cadastrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break; 
                }

                if (this.textBoxNome.Text.Length <= 0)
                {
                    MessageBox.Show("Nenhum nome inserido");
                    return;
                }

                Program.alteraFuncionarioBD(this.idTemporario, this.textBoxNome.Text, this.textBoxCPF.Text, checkBoxAtivo.Checked);
                
            }
            this.Close();

        }

        private void buscarFuncionarioClickListener(object sender, EventArgs e)
        {
            this.buscaFuncionario = new TelaBuscaFuncionario(this);
            this.buscaFuncionario.ShowDialog();
        }

        private void onActivateForm(object sender, EventArgs e)
        {
            if (this.Enabled && !cadastro)
            {
                this.idTemporario = this.buscaFuncionario.funcionarioSelecionado;
                if (this.idTemporario == 0) this.Close();
                this.funcionario = Program.buscaFuncinarioPorID(idTemporario);
                this.textBoxId.Text = funcionario.id.ToString();
                this.textBoxNome.Text = funcionario.nome;
                this.textBoxCPF.Text = funcionario.CPF;
                this.textBoxData.Text = DateTime.Now.ToString();
                this.checkBoxAtivo.Checked = funcionario.situacao == 'A' ? true : false;
            }
        }
    }
        
}
