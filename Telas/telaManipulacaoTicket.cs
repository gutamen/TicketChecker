using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketChecker.Modelo;

namespace TicketChecker.Telas
{
    
    public partial class TelaManipulacaoTicket: Form
    {
        private bool cadastro = false;
        private bool selecaoFuncionario = false;
        private Funcionario funcionario;
        private Ticket ticket;
        private int idTemporario = 0;
        private int idFuncionarioTemporario = 0;
        private TelaBuscaFuncionario buscaFuncionario;
        private TelaBuscaTicket buscaTicket;
        private SelecaoData calendario;
        public TelaManipulacaoTicket(String nomeTela, bool cadastro = false)
        {

            this.cadastro = cadastro;
            InitializeComponent();
            this.Text = nomeTela;
            if (cadastro)
            {
                this.labelMenuTicket.Text = "Insira os dados";
                this.checkBoxAtivo.Checked = true;
                this.checkBoxAtivo.Enabled = false;
                this.textBoxData.Text = DateTime.Now.ToString();

                // Funciona para saber o ID na criação do ticket, mas pode incrementar o id sem precisar
                idTemporario = Program.ObterProximoIdTicketBD();
                this.textBoxId.Text = idTemporario.ToString();
                this.ShowDialog();

            }
            else
            {
                this.labelMenuTicket.Text = "Edite os dados";
                buscaTicket = new TelaBuscaTicket(this);
                buscaTicket.ShowDialog();
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
            if (this.cadastro)
            {
                if (this.textBoxFuncionarioID.Text.Length == 0)
                {
                    MessageBox.Show("Selecione um Funcionário para atribuir o ticket.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Program.insereTicketBD(this.idTemporario, Convert.ToInt32(this.textBoxFuncionarioID.Text.ToString()),
                    Convert.ToInt32(this.upDownQuantidade.Value), checkBoxAtivo.Checked, DateTime.Now);
                
            }
            else
            {
                Program.alteraTicketBD(this.idTemporario, Convert.ToInt32(this.textBoxFuncionarioID.Text.ToString()),
                    Convert.ToInt32(this.upDownQuantidade.Value), checkBoxAtivo.Checked, DateTime.Parse(this.textBoxData.Text));
            }
            this.Close();
        }

        private void alterarFuncionarioClickListener(object sender, EventArgs e)
        {
            this.buscaFuncionario = new TelaBuscaFuncionario(this);
            this.selecaoFuncionario = true;
            this.buscaFuncionario.ShowDialog();
        }
        private void onActivateForm(object sender, EventArgs e)
        {
            if (this.Enabled && !this.cadastro && !this.selecaoFuncionario)
            {
                this.idTemporario = this.buscaTicket.ticketSelecionado;
                if (idTemporario == 0) this.Close();

                ticket = Program.buscaTicketPorID(idTemporario);
                this.textBoxId.Text = idTemporario.ToString();
                this.textBoxFuncionarioID.Text = ticket.idFuncionario.ToString();
                this.upDownQuantidade.Value = ticket.quantidade;
                this.checkBoxAtivo.Checked = ticket.situacao == 'A' ? true : false;

                funcionario = Program.buscaFuncinarioPorID(ticket.idFuncionario);
                //this.textBoxFuncionarioID.Text = funcionario.id.ToString();
                this.textBoxFuncionarioNome.Text = funcionario.nome;
                this.textBoxData.Text = ticket.dataEntrega.ToString();

            }
            else if (this.selecaoFuncionario)
            {
                this.selecaoFuncionario = false;
                this.idFuncionarioTemporario = this.buscaFuncionario.funcionarioSelecionado;
                if (this.idFuncionarioTemporario == 0) return;

                funcionario = Program.buscaFuncinarioPorID(idFuncionarioTemporario);
                this.textBoxFuncionarioID.Text = funcionario.id.ToString();
                this.textBoxFuncionarioNome.Text = funcionario.nome;

                this.idFuncionarioTemporario = 0;
            }

        }

        private void selectDataClick(object sender, EventArgs e)
        {
            
            calendario = new SelecaoData();
            this.textBoxData.Text = calendario.dataSelecionada.ToString();
            
        }
    }
}
