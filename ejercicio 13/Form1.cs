using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_13
{
    public partial class Form1 : Form
    {
        Segundos miDias = new Segundos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSegundos_Click(object sender, EventArgs e)
        {
            miDias.Dias = int.Parse(textBox1.Text);
            MessageBox.Show($"Los segundos en {textBox1.Text} dia(s) son {miDias.CalcularSegundos()} segundos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
