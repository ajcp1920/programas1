using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolinera
{
    public partial class Form1 : Form
    {
        Gasolinera miGasolinera = new Gasolinera();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            miGasolinera.Galones = double.Parse(txtGalones.Text);
            MessageBox.Show($"El precio total a pagar es: $ {miGasolinera.CalcularPrecio().ToString()}");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
