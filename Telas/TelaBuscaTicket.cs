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
    public partial class TelaBuscaTicket: Form
    {
        private List<Ticket> listaTicket;
        private Form tela;
        public int ticketSelecionado = 0;
        private int funcionarioSelecionado;
        public TelaBuscaTicket(Form tela)
        {
            
            InitializeComponent();
            this.tela = tela;
            tela.Enabled = false;
            
        }

        private void buscarClickListener(object sender, EventArgs e)
        {
            this.listaTicket = Program.buscaTicketsBD();
            
            List<String> temp = new List<string>();
            foreach (Ticket c in listaTicket)
            {
                // ABSURDAMENTE ruim, somente para ficar mais rápido de fazer, o correto era um join
                Funcionario temporario = Program.buscaFuncinarioPorID(c.idFuncionario);

                String adiciona = temporario.nome;
                adiciona += " \tQuantiade de tickets :" + c.quantidade.ToString() + " \tEntregues em:" + c.dataEntrega.ToString();
                temp.Add(adiciona);
            }

            this.listBuscaTicket.DataSource = temp;
        }

        private void selectIndexBusca(object sender, EventArgs e)
        {
            if(this.listBuscaTicket.Items.Count == 0)
            {
                return;
            }
            this.ticketSelecionado = listaTicket.ElementAt(this.listBuscaTicket.SelectedIndex).id;
            this.tela.Enabled = true;
            this.Close();
        }

        
        private void onClose(object sender, FormClosedEventArgs e)
        {
            if (!this.tela.Enabled) this.tela.Close();
        }

        
    }
}
