using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grados
{
    public partial class Form1 : Form
    {
        Temperatura miTemperatura = new Temperatura(40);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if(txtCantidad.Text == "")
            {
                
                    if (radCentigrados.Checked)
                    {
                        MessageBox.Show($"Los grados Centigrados son: {miTemperatura.ConvertirGrados().ToString()}");
                    }
                    if (radFah.Checked)
                    {
                        MessageBox.Show($"Los grados Farenheit son: {miTemperatura.ConvertirAFarenheit().ToString()}");
                    }
                
            }
            else
            {
                miTemperatura.GradosCentigrados = double.Parse(txtCantidad.Text);
                if (radCentigrados.Checked)
                {
                    MessageBox.Show($"Los grados Centigrados son: {miTemperatura.ConvertirGrados().ToString()}");
                }
                if (radFah.Checked)
                {
                    MessageBox.Show($"Los grados Farenheit son: {miTemperatura.ConvertirAFarenheit().ToString()}");
                }
            }
        }
    }
}
