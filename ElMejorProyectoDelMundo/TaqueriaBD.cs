using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ElMejorProyectoDelMundo
{
    class TaqueriaBD : DatosEmpleados
    {
        SqlConnection taqueriacn;
        SqlCommand taqueriacmd;
        SqlDataReader taqueriadr;
        DataTable taqueriadt;
        SqlDataAdapter taqueriada;
        
        public TaqueriaBD()
        {
            try
            {
                taqueriacn = new SqlConnection("Data Source=.;Initial Catalog=Taqueria;Integrated Security=True");
                taqueriacn.Open();
                MessageBox.Show("La prueba de conexion con la base de datos se realizo correctamente", "Microsoft Visual Studio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede probar esta conexion por que no se ha especificado ningun nombre de servidor" + ex.ToString());
            }
        }
        public string AgregarEmpleado(int ID, string nombre, string puesto, string telefono, string sueldo)
        {
            string salida = "El Empleado se agrego correctamente";
            try
            {
                taqueriacmd = new SqlCommand("Insert into Datos(Id,Nombre,Puesto,Telefono,Sueldo) values(" + ID + ",'" + nombre + "','" + puesto + "','" + telefono + "', '" + sueldo + "')", taqueriacn);
                taqueriacmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public int RegistroPersona(int id)  
        {
            int contador = 0;
            try
            {
                taqueriacmd = new SqlCommand("Select * from Datos where Id=" + id + "", taqueriacn);
                taqueriadr = taqueriacmd.ExecuteReader();
                while (taqueriadr.Read())
                {
                    contador++;
                }
                taqueriadr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
       
        public void MostrarEmpleados(DataGridView dgv)
        {
            try
            {
                taqueriada = new SqlDataAdapter("Select * from Datos", taqueriacn);
                taqueriadt = new DataTable();
                taqueriada.Fill(taqueriadt);
                dgv.DataSource = taqueriadt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la lista" + ex.ToString());
            }
        }
      
        public string Modificar(int id, string nombre, string puesto, string telefono, string sueldo)
        {
            string salida = "Se han modificado los datos del empleado";
            try
            {
                taqueriacmd = new SqlCommand("Update Datos set Nombre = '" + nombre + "' ,Puesto= '" + puesto + "' ,Telefono= '" + telefono + "' ,Sueldo= '" + sueldo + "' where ID=" + id + "", taqueriacn);
                taqueriacmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se modificaron los datos del empleado" + ex.ToString();
            }
            return salida;
        }
        public string Eliminar(int id)
        {
            string salida = "Se ha eliminado al empleado";
            try
            {
                taqueriacmd = new SqlCommand("delete from Datos where ID= " + id + "", taqueriacn);
                taqueriacmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se econtro los datos: " + ex.ToString();
            }
            return salida;
        } 
        
        public void OrdenarBD(DataGridView dgv, string Tipo)
        {
            try
            {
                taqueriada = new SqlDataAdapter("Select * from Datos Order by "+Tipo, taqueriacn);
                taqueriadt = new DataTable();
                taqueriada.Fill(taqueriadt);
                dgv.DataSource = taqueriadt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
