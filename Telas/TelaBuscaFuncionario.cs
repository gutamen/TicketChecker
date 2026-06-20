using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketChecker.Modelo;

namespace TicketChecker.Telas
{
    public partial class TelaBuscaFuncionario: Form
    {
        private List<Funcionario> listaFuncionario;
        private Form tela;
        public int funcionarioSelecionado = 0;
        public TelaBuscaFuncionario(Form tela)
        {
            this.tela = tela;
            tela.Enabled = false;
            InitializeComponent();
        }

        private void buscarFuncionarioClickListener(object sender, EventArgs e)
        {
            this.listaFuncionario = Program.buscaFuncionariosNomeBD(this.textBoxBusca.Text);
            
            List<String> temp = new List<string>();
            foreach (Funcionario c in listaFuncionario)
            {
                temp.Add(c.nome + " \tCPF:" + c.CPF);
            }

            this.listBoxFuncionario.DataSource = temp;
        }

        private void selectIndexBusca(object sender, EventArgs e)
        {
            if(this.listBoxFuncionario.Items.Count == 0)
            {
                return;
            }
            this.funcionarioSelecionado = listaFuncionario.ElementAt(this.listBoxFuncionario.SelectedIndex).id;
            this.tela.Enabled = true;
            this.Close();
        }


        private void onClose(object sender, FormClosedEventArgs e)
        {
            if (tela.GetType() == typeof(TelaManipulacaoTicket))
            {
                this.tela.Enabled = true;
                return;
            }
            if (!this.tela.Enabled) this.tela.Close();
        }

        
    }
}
