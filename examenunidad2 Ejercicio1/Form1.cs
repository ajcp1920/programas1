using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenunidad2_Ejercicio1
{
    public partial class Form1 : Form
    {
        iPhone miIphone = new iPhone();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Procesador miProcesador = new Procesador();
            Accesorios miAccesorio = new Accesorios();
            miIphone.nombre = txtNombre.Text;
            miIphone.numeromodelo = int.Parse(txtModelo.Text);
            miIphone.numeroserie = int.Parse(txtSerie.Text);
            miIphone.modelo = textBox1.Text;
            miIphone.almacenamiento = int.Parse(txtCapacidad.Text);
            miIphone.tamanopantalla = double.Parse(txtPantalla.Text);
            miProcesador.nombrechip = txtProcesador.Text;
            if (chbAudifonos.Checked)
            {
                miAccesorio.audifonos = true;
            }
            else
            {
                miAccesorio.audifonos = false;
            }
            if (chbCargador.Checked)
            {
                miAccesorio.cargador = true;
            }
            else
            {
                miAccesorio.cargador = false;
            }
            miIphone.AgregarProcesador(miProcesador);
            miIphone.AgregarAccesorios(miAccesorio);
            Limpiar();
            MostrarDatos();
            MessageBox.Show("El iPhone ha sido agregado");
        }
        public void Limpiar()
        {
            txtCapacidad.Clear();
            txtModelo.Clear();
            txtNombre.Clear();
            txtPantalla.Clear();
            txtProcesador.Clear();
            txtSerie.Clear();
            textBox1.Clear();
            chbAudifonos.Checked = false;
            chbCargador.Checked = false;
        }

        public void MostrarDatos()
        {
            dataGridView1.Rows.Clear();
            foreach (Accesorios d in miIphone.ListaAccesorios)
            {
                foreach (Procesador p in miIphone.ListaProcesador)
                {
                    dataGridView1.Rows.Add(miIphone.nombre, miIphone.numeromodelo, miIphone.numeroserie, miIphone.modelo, miIphone.almacenamiento, miIphone.tamanopantalla, p.nombrechip, d.audifonos, d.cargador);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

