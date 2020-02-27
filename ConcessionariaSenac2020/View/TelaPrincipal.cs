using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcessionariaSenac2020.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarVeiculos telaCadastrarVeiculos = new TelaCadastrarVeiculos();
            telaCadastrarVeiculos.ShowDialog();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaVisualizarVeiculos telaVisualizarVeiculos = new TelaVisualizarVeiculos();
            telaVisualizarVeiculos.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterarVeiculos telaAlterarVeiculos = new TelaAlterarVeiculos();
            telaAlterarVeiculos.ShowDialog();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeletarVeiculos telaDeletarVeiculos = new TelaDeletarVeiculos();
            telaDeletarVeiculos.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
