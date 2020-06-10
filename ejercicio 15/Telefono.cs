using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_15
{
    class Telefono
    {
        private int duracion;

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        
        public double CalcularCosto()
        {
            int llamada;
            if (duracion <= 3)
            {
                llamada = duracion * 5;
            }
            else 
            {
                llamada = (duracion * 5) + 3;
            }
            return llamada;
        }
    }
}
