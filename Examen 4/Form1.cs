using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRey_Click(object sender, EventArgs e)
        {
            Rey miRey = new Rey();
            MessageBox.Show(miRey.Mover());
        }

        private void btnAlfil_Click(object sender, EventArgs e)
        {
            Alfil miAlfil = new Alfil();
            MessageBox.Show(miAlfil.Mover());
        }

        private void btnReina_Click(object sender, EventArgs e)
        {
            Reina miReina = new Reina();
            MessageBox.Show(miReina.Mover());
        }

        private void btnCaballo_Click(object sender, EventArgs e)
        {
            Caballo miCaballo = new Caballo();
            MessageBox.Show(miCaballo.Mover());
        }

        private void btnTorre_Click(object sender, EventArgs e)
        {
            Torre miTorre = new Torre();
            MessageBox.Show(miTorre.Mover());
        }

        private void btnPeon_Click(object sender, EventArgs e)
        {
            Peon miPeon = new Peon();
            MessageBox.Show(miPeon.Mover());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
