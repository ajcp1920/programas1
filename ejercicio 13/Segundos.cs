using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_13
{
    class Segundos
    {
        private int dias;

        public int Dias
        {
            get { return dias; }
            set { dias = value; }
        }
        public double CalcularSegundos()
        {
            return Dias * 86400;
        }
    }
}
