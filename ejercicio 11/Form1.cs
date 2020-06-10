using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_11
{
    public partial class Form1 : Form
    {
        Agencia miAgencia = new Agencia();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            miAgencia.Coste = double.Parse(textBox1.Text);
            MessageBox.Show($"El costo del automovil es de: $ {textBox1.Text} pesos \n La ganancia seria de: ${miAgencia.CalcularGanancia().ToString()} pesos \n El impuesto implementado es de: ${miAgencia.CalcularImpuesto().ToString()} pesos \n  El total a pagar es: ${miAgencia.CalcularTotal().ToString()} pesos");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
