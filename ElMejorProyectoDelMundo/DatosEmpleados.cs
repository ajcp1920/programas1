using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElMejorProyectoDelMundo
{
    class DatosEmpleados
    {
        private int _intID;

        public int ID
        {
            get { return _intID; }
            set { _intID = value; }
        }
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private string _strPuesto;

        public string Puesto
        {
            get { return _strPuesto; }
            set { _strPuesto = value; }
        }
        private string _strTelefono;

        public string Telefono
        {
            get { return _strTelefono; }
            set { _strTelefono = value; }
        }
        private string _strSueldo;

        public string Sueldo
        {
            get { return _strSueldo; }
            set { _strSueldo = value; }
        }

        
    }
}
