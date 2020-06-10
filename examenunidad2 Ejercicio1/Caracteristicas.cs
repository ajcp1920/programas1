using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenunidad2_Ejercicio1
{
    class Caracteristicas
    {
        private int _intAlmacenamiento;

        public int almacenamiento
        {
            get { return _intAlmacenamiento; }
            set { _intAlmacenamiento = value; }
        }
        private string _strModelo;

        public string modelo
        {
            get { return _strModelo; }
            set { _strModelo = value; }
        }
        private double _dblTamanoPantalla;

        public double tamanopantalla
        {
            get { return _dblTamanoPantalla; }
            set { _dblTamanoPantalla = value; }
        }

    }
}
