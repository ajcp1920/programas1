using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Circunferencia rueda = new Circunferencia(10.2);
        Circunferencia moneda = new Circunferencia(1.4);
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (radRueda.Checked)
            {
                rueda.Radio = double.Parse(txtRadio.Text);
                MessageBox.Show($"El radio de la rueda fue modificado, su valor es: {rueda.Radio}");
            }
            else
            {
                moneda.Radio = double.Parse(txtRadio.Text);
                MessageBox.Show($"El radio de la moneda fue modificado, su valor es: {moneda.Radio}");

            }
        }

        private void radRueda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radMoneda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            if (RadioChecked())
            {
                double area = rueda.CalcularArea();
                MessageBox.Show($"El area de su rueda es {area}");

            }
            else
            {
                double area = moneda.CalcularArea();
                MessageBox.Show($"El area de su moneda es {area}");

            }
        }
        public bool RadioChecked()
        {
            if (radRueda.Checked) return true;
            else
                return false;


        }

        private void btnCalcularPerimetro_Click(object sender, EventArgs e)
        {
            if (RadioChecked()) MessageBox.Show($"El perimetro de su rueda es: {rueda.CalcularPerimetro()}");
            else MessageBox.Show($"El perimetro de su moneda es: {moneda.CalcularPerimetro()}");



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
