using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._1
{
    public partial class Form1 : Form
    {
        Triangulo miTrian = new Triangulo();
        Rectangulo miRect = new Rectangulo();
        Circunferencia miCirc = new Circunferencia();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (radRectangulo.Checked)
            {
                miRect.largo = double.Parse(txtLargo.Text);
                miRect.ancho = double.Parse(txtAncho.Text);
                
                MessageBox.Show($"El area del rectangulo es: {miRect.CalcularArea().ToString()} cm");
                txtLargo.Clear();
                txtAncho.Clear();
                radRectangulo.Checked = false;
                txtAltura.Enabled = true;
                txtRadio.Enabled = true;
            }
            if (radCircunferencia.Checked)
            {
                miCirc.radio = double.Parse(txtRadio.Text);
                
                MessageBox.Show($"El area de la circunferencia es: {miCirc.CalcularArea().ToString()} cm");
                txtRadio.Clear();
                radCircunferencia.Checked = false;
                txtLargo.Enabled = true;
                txtAncho.Enabled = true;
                txtAltura.Enabled = true;
            }
            if (radTriangulo.Checked)
            {
                miTrian.altura = double.Parse(txtAltura.Text);
                miTrian.ancho = double.Parse(txtAncho.Text);
                
                MessageBox.Show($"El area de la circunferencia es: {miTrian.CalcularArea().ToString()}");
                txtAltura.Clear();
                txtAncho.Clear();
                radTriangulo.Checked = false;
                txtLargo.Enabled = true;
                txtRadio.Enabled = true;
            }else
            {
                MessageBox.Show("Seleccione una figura");
            }

        }           

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            txtRadio.Enabled = false;
            txtAltura.Enabled = false;
            txtLargo.Enabled = true;
            txtAncho.Enabled = true;
        }

        private void radCircunferencia_CheckedChanged(object sender, EventArgs e)
        {
            txtLargo.Enabled = false;
            txtAncho.Enabled = false;
            txtAltura.Enabled = false;
            txtRadio.Enabled = true;
        }

        private void radTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            txtLargo.Enabled = false;
            txtRadio.Enabled = false;
            txtAltura.Enabled = true;
            txtAncho.Enabled = true;
        }
    }
}
