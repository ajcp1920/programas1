using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangulo
{
    public partial class Form1 : Form
    {
        //Objeto
        Rectangulo1 pared = new Rectangulo1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double CalcularTiempo()
        {
            
            return pared.CalcularArea() * 10;
        }


        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            pared.Largo = double.Parse(txtLargo.Text);
            pared.Ancho = double.Parse(txtAncho.Text);
            MessageBox.Show($"El area de su pared es de: {pared.CalcularArea()}m^2 y el tiempo que le llevara pintar su pared es de: {CalcularTiempo()} minutos", "Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConsLar_Click(object sender, EventArgs e)
        {
            pared.Largo = double.Parse(txtLargo.Text);
            MessageBox.Show($"El largo de la pared es: {pared.Largo}");
        }

        private void btnConsAnc_Click(object sender, EventArgs e)
        {
            pared.Ancho = double.Parse(txtAncho.Text);
            MessageBox.Show($"El ancho de la pared es: {pared.Ancho}");
        }

        private void btnModAnc_Click(object sender, EventArgs e)
        {
            pared.Ancho = double.Parse(txtAncho.Text);
            MessageBox.Show($"El ancho ha sido modificado, su valor es: {pared.Ancho}");
        }

        private void btnModLar_Click(object sender, EventArgs e)
        {
            pared.Largo = double.Parse(txtLargo.Text);
            MessageBox.Show($"El largo ha sido modificado, su valor es: {pared.Largo}");
        }
    }
}
