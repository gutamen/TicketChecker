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
    public partial class TelaRelatorio: Form
    {
        private SelecaoData calendario;
        private TelaBuscaFuncionario buscaFuncionario = null;
        private Funcionario funcionario = null;
        private List<Ticket> tickets;
        public TelaRelatorio()
        {
            
            InitializeComponent();
            this.ShowDialog();
        }

        private void selectDataClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Console.WriteLine(b.Name);
            if(b.Name == "buttonDataInicial")
            {
                calendario = new SelecaoData();
                this.textBoxDataIncial.Text = calendario.dataSelecionada.ToString();
            }
            else
            {
                calendario = new SelecaoData();
                this.textBoxDataFinal.Text = calendario.dataSelecionada.ToString();
            }
            
        }

        private void buscarFuncionarioClick(object sender, EventArgs e)
        {
            this.buscaFuncionario = new TelaBuscaFuncionario(this);
            this.buscaFuncionario.ShowDialog();
            
        }

        private void retrocederClick(object sender, EventArgs e) 
        {
            this.Close();
        }

        private void onActivated(object sender, EventArgs e)
        {
            if (this.buscaFuncionario != null && this.buscaFuncionario.funcionarioSelecionado != 0)
            {
                this.funcionario = Program.buscaFuncinarioPorID(this.buscaFuncionario.funcionarioSelecionado);
                this.textBoxFuncionario.Text = funcionario.nome;
            }
        }

        private void confirmarClick(object sender, EventArgs e)
        {
            DateTime? inicial = null, final = null;
            int compareData = 0;


            if (this.textBoxDataIncial.Text.Length > 0)
            {
                inicial = DateTime.Parse(this.textBoxDataIncial.Text);
                compareData++;
            }
            if (this.textBoxDataFinal.Text.Length > 0) 
            { 
                final = DateTime.Parse(this.textBoxDataFinal.Text);
                compareData++;
            }
            if (final.HasValue && inicial.HasValue)
            {
                if (compareData == 2 && final < inicial)
                {
                    MessageBox.Show("Data inicial deve ser antes da final.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (radioData.Checked)
            {
                tickets = Program.buscaTicketsBD(funcionario, 2, inicial: inicial.HasValue ? inicial : null, final: final.HasValue ? final : null);
            }
            else if (radioId.Checked)
            {
                tickets = Program.buscaTicketsBD(funcionario, 0, inicial: inicial.HasValue ? inicial : null, final: final.HasValue ? final : null);
            }
            else
            {
                tickets = Program.buscaTicketsBD(funcionario, 1, inicial: inicial.HasValue ? inicial : null, final: final.HasValue ? final : null);
            }

            Program.gerarRelatorioTickets(tickets);

        }
    }
}
