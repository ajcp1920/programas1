using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_15
{
    public partial class Form1 : Form
    {
        Telefono miTelefono = new Telefono();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLlamada_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(textBox1.Text);
            if (n < 0)
            {
                MessageBox.Show("NUMERO EQUIVOCADO, POR FAVOR INGRESE UN NUMERO POSITIVO");
            } else
            {
                miTelefono.Duracion = int.Parse(textBox1.Text);
                MessageBox.Show($"La duracion de la llamada es de {textBox1.Text} minutos y el costo es de ${miTelefono.CalcularCosto()} pesos");
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
