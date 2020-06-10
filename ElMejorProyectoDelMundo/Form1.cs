using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElMejorProyectoDelMundo
{
    public partial class Form1 : Form
    {
        public delegate void Mensaje(string mensaje);
        TaqueriaBD miTaqueria = new TaqueriaBD();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosEmpleados miempleado = new DatosEmpleados();
            if (miTaqueria.RegistroPersona(Convert.ToInt32(txtID.Text)) == 0)
            {
                miempleado.ID = int.Parse(txtID.Text);
                miempleado.Nombre = txtNombreEmpleado.Text;
                miempleado.Puesto = txtPuesto.Text;
                miempleado.Telefono = txtTelefono.Text;
                miempleado.Sueldo = txtSueldo.Text;
                MessageBox.Show(miTaqueria.AgregarEmpleado(miempleado.ID, miempleado.Nombre, miempleado.Puesto, miempleado.Telefono, miempleado.Sueldo));
                miTaqueria.MostrarEmpleados(dgListaEmpleados);
                txtNombreEmpleado.Clear();
                txtPuesto.Clear();
                txtTelefono.Clear();
                txtSueldo.Clear();
                txtID.Clear();
                Mensaje miMensaje = new Mensaje(new Mensaje1().msj); //delegado
                miMensaje(txtNombreEmpleado.Text);
                txtID.Focus();
            }
            else
            {
                MessageBox.Show("No se puede registrar, ya hay un registro igual", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miTaqueria.Eliminar(Convert.ToInt32(txtID.Text)));
            miTaqueria.MostrarEmpleados(dgListaEmpleados);

            txtNombreEmpleado.Clear();
            txtPuesto.Clear();
            txtTelefono.Clear();
            txtSueldo.Clear();
            txtID.Clear();
            txtID.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            miTaqueria.MostrarEmpleados(dgListaEmpleados);
            txtID.Focus();
        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DatosEmpleados miempleado = new DatosEmpleados();
            miempleado.ID = int.Parse(txtID.Text);
            miempleado.Nombre = txtNombreEmpleado.Text;
            miempleado.Puesto = txtPuesto.Text;
            miempleado.Telefono = txtTelefono.Text;
            miempleado.Sueldo = txtSueldo.Text;
            MessageBox.Show(miTaqueria.Modificar(miempleado.ID, miempleado.Nombre, miempleado.Puesto, miempleado.Telefono, miempleado.Sueldo));
            miTaqueria.MostrarEmpleados(dgListaEmpleados);
            txtNombreEmpleado.Clear();
            txtPuesto.Clear();
            txtTelefono.Clear();
            txtSueldo.Clear();
            txtID.Focus();
        }

        private void EventoClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgListaEmpleados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgListaEmpleados.CurrentRow.Selected = true;
                txtID.Text = dgListaEmpleados.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                txtNombreEmpleado.Text = dgListaEmpleados.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();
                txtPuesto.Text = dgListaEmpleados.Rows[e.RowIndex].Cells["Puesto"].FormattedValue.ToString();
                txtTelefono.Text = dgListaEmpleados.Rows[e.RowIndex].Cells["Telefono"].FormattedValue.ToString();
                txtSueldo.Text = dgListaEmpleados.Rows[e.RowIndex].Cells["Sueldo"].FormattedValue.ToString();

            }
        }

        private void gbEmpleados_Enter(object sender, EventArgs e)
        {

        }

        private void btnText_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombreEmpleado.Clear();
            txtPuesto.Clear();
            txtSueldo.Clear();
            txtTelefono.Clear();
            txtID.Focus();

        }


        public class Mensaje1
        {
            public void msj(string msj)
            {
                MessageBox.Show("Bienvenido a la Taqueria");
            }

        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            if (radID.Checked == true)
            {
                miTaqueria.OrdenarBD(dgListaEmpleados, "ID");
                return;
            }
            if (radNombre.Checked == true)
            {
                miTaqueria.OrdenarBD(dgListaEmpleados, "Nombre");
                return;
            }
            if (radPuesto.Checked == true)
            {
                miTaqueria.OrdenarBD(dgListaEmpleados, "Puesto");
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
     
}
