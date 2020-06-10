using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_6
{
    public partial class Form1 : Form
    {
        Articulo miArticulo = new Articulo(8768, "Comestible", 19.20, 5);
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(textBox3.Text);
            int clave = int.Parse(txtClave.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            string descripcion = txtDesc.Text;
            double iva = precio * .16 + precio;
            MessageBox.Show($"La clave del producto es: {clave}\n Cantidad de producto: {cantidad}\n El prodcuto es: {descripcion}\n El precio final es de $ {iva}");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"La clave es: {miArticulo.Clave}\n La cantidad del producto es: {miArticulo.Cantidad}\n El precio del producto es: {miArticulo.Precio}\n El articulo es: {miArticulo.Descripcion}");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            miArticulo.Precio = double.Parse(textBox3.Text);
            miArticulo.Clave = int.Parse(txtClave.Text);
            miArticulo.Cantidad = int.Parse(txtCantidad.Text);
            miArticulo.Descripcion = txtDesc.Text;
            MessageBox.Show("Los datos se han modificado correctamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtClave.Clear();
            txtDesc.Clear();
            textBox3.Clear();
            txtClave.Focus();
        }
    }
}
