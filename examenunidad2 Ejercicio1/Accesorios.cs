using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenunidad2_Ejercicio1
{
    class Accesorios
    {
        private bool _boolAudifonos;

        public bool audifonos
        {
            get { return _boolAudifonos; }
            set { _boolAudifonos = value; }
        }
        private bool _boolCargador;

        public bool cargador
        {
            get { return _boolCargador; }
            set { _boolCargador = value; }
        }

    }
}
