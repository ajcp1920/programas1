using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Unidad_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta;
            Respuesta =MessageBox.Show("¿Está seguro que desea salir?", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Respuesta == DialogResult.Yes)
                Application.Exit();
            else
                textBox1.Focus();
                
        }
    }
}
