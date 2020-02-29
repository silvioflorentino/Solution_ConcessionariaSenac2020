using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConcessionariaSenac2020.Control;
using ConcessionariaSenac2020.Model;

namespace ConcessionariaSenac2020.View
{
    public partial class TelaVisualizarVeiculos : Form
    {
        public TelaVisualizarVeiculos()
        {
            InitializeComponent();
        }

        private void buttonBuscaCodigoVeiculo_Click(object sender, EventArgs e)
        {
          Veiculos.Codigo = Convert.ToInt32(textBoxBuscaCodigoVeiculo.Text);

            ManipulaVeiculos manipulaVeiculos = new ManipulaVeiculos();
            manipulaVeiculos.visualizarCodigoVeiculos();

            textBoxMarca.Text = Veiculos.Marca;
            textBoxModelo.Text = Veiculos.Modelo;
            textBoxCor.Text = Veiculos.Cor;
            textBoxPlaca.Text = Veiculos.Placa;






        }
    }
}
