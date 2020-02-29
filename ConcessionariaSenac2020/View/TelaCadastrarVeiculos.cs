using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConcessionariaSenac2020.Model;
using ConcessionariaSenac2020.Control;


namespace ConcessionariaSenac2020.View
{
    public partial class TelaCadastrarVeiculos : Form
    {
        public TelaCadastrarVeiculos()
        {
            InitializeComponent();
        }

        private void buttonSalvarVeiculos_Click(object sender, EventArgs e)
        {
            Veiculos.Marca = comboBoxMarca.Text;
            Veiculos.Modelo = textBoxModelo.Text;
            Veiculos.Cor = textBoxCor.Text;
            Veiculos.Placa = textBoxPlaca.Text;

            ManipulaVeiculos manipulaVeiculos = new ManipulaVeiculos();
            manipulaVeiculos.cadastrarVeiculos();
                                 
        }
    }
}
