using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        Mesa m1 = new Mesa();
        Mesa m2 = new Mesa();
        Mesa m3 = new Mesa();
        Mesa m4 = new Mesa();
        Mesa m5 = new Mesa();
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

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            switch (cmbMesas.Text)
            {
                case "Mesa 1": 
                    MessageBox.Show("Capturado en Mesa 1");
                    m1.HamSencilla = int.Parse(txtHS.Text);
                    m1.HamQueso = int.Parse(txtHQ.Text);
                    m1.HamEspecial = int.Parse(txtHE.Text);
                    m1.Papas = int.Parse(txtPapas.Text);
                    m1.Refresco = int.Parse(txtRefresco.Text);
                    m1.Postre = int.Parse(txtPostres.Text);
                    break;
                case "Mesa 2":
                    MessageBox.Show("Capturado en Mesa 2");
                    m2.HamSencilla = int.Parse(txtHS.Text);
                    m2.HamQueso = int.Parse(txtHQ.Text);
                    m2.HamEspecial = int.Parse(txtHE.Text);
                    m2.Papas = int.Parse(txtPapas.Text);
                    m2.Refresco = int.Parse(txtRefresco.Text);
                    m2.Postre = int.Parse(txtPostres.Text);
                    break;
                case "Mesa 3":
                    MessageBox.Show("Capturado en Mesa 3");
                    m3.HamSencilla = int.Parse(txtHS.Text);
                    m3.HamQueso = int.Parse(txtHQ.Text);
                    m3.HamEspecial = int.Parse(txtHE.Text);
                    m3.Papas = int.Parse(txtPapas.Text);
                    m3.Refresco = int.Parse(txtRefresco.Text);
                    m3.Postre = int.Parse(txtPostres.Text);
                    break;
                case "Mesa 4":
                    MessageBox.Show("Capturado en Mesa 4");
                    m4.HamSencilla = int.Parse(txtHS.Text);
                    m4.HamQueso = int.Parse(txtHQ.Text);
                    m4.HamEspecial = int.Parse(txtHE.Text);
                    m4.Papas = int.Parse(txtPapas.Text);
                    m4.Refresco = int.Parse(txtRefresco.Text);
                    m4.Postre = int.Parse(txtPostres.Text);
                    break;
                case "Mesa 5":
                    MessageBox.Show("Capturado en Mesa 5");
                    m5.HamSencilla = int.Parse(txtHS.Text);
                    m5.HamQueso = int.Parse(txtHQ.Text);
                    m5.HamEspecial = int.Parse(txtHE.Text);
                    m5.Papas = int.Parse(txtPapas.Text);
                    m5.Refresco = int.Parse(txtRefresco.Text);
                    m5.Postre = int.Parse(txtPostres.Text);
                    break;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch(cmbMesas.Text)
            {
                case "Mesa 1":
                    MessageBox.Show($"Cuenta: $ {m1.CalcularCosto()} pesos");
                    break;
                case "Mesa 2":
                    MessageBox.Show($"Cuenta: $ {m2.CalcularCosto()} pesos");
                    break;
                case "Mesa 3":
                    MessageBox.Show($"Cuenta: $ {m3.CalcularCosto()} pesos");
                    break;
                case "Mesa 4":
                    MessageBox.Show($"Cuenta: $ {m4.CalcularCosto()} pesos");
                    break;
                case "Mesa 5":
                    MessageBox.Show($"Cuenta: $ {m5.CalcularCosto()} pesos");
                    break;

            }
        }

        private void cmbMesas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
