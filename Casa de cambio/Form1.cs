using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casa_de_cambio
{
    public partial class Form1 : Form
    {
        CambioDivisas tipodecambio = new CambioDivisas(19.50);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtDinero.Text == "")
            {
                MessageBox.Show("Por favor ingrese la cantidad que desea cambiar");
            }else
            {
                tipodecambio.Pesos = double.Parse(txtDinero.Text);
                MessageBox.Show($"El cambio es de: $ {tipodecambio.ConvertirADolares().ToString()} dolares");
            }
                
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por su compra, vuelva pronto :D");
            Application.Exit();
        }

        private void btnPesos_Click(object sender, EventArgs e)
        {
            if (txtDinero.Text == "")
            {
                MessageBox.Show("Por favor ingrese la cantidad que desea cambiar");
            }
            else
            {
                tipodecambio.Pesos = double.Parse(txtDinero.Text);
                MessageBox.Show($"El cambio es de: $ {tipodecambio.ConvertirAPesos().ToString()} pesos");
            }
        }
    }
}
