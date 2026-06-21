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
    
    public partial class SelecaoData: Form
    {
        public DateTime dataSelecionada;
        public SelecaoData()
        {
            InitializeComponent();
            this.ShowDialog();
            
        }

        private void dateSelected(object sender, DateRangeEventArgs e)
        {
            this.dataSelecionada = e.Start;
            this.Close();
        }
    }
}
