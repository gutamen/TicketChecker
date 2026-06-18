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

namespace TicketChecker
{
    public partial class Inicio: Form
    {

        
        public Inicio()
        {
            InitializeComponent();
        }

        private void cadastrarFuncionarioClickListener(object sender, EventArgs e)
        {
            telaManipulacaoFuncionario cadastro = new telaManipulacaoFuncionario("Cadastrar Funcionário", true);
            cadastro.ShowDialog();
        }

        private void editarFuncionarioClickListener(object sender, EventArgs e)
        {
            telaManipulacaoFuncionario edicao = new telaManipulacaoFuncionario("Editar Funcionário", false);
            edicao.ShowDialog();
        }

    }
}
