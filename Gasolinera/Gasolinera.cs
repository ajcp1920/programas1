using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera
{
    class Gasolinera
    {
        private double galones;

        public double Galones
        {
            get { return galones; }
            set { galones = value; }
        }
        private double litros;
        public Gasolinera()
        {
            litros = 3.785;
        }
        

        public double CalcularPrecio()
        {
            return Math.Round(galones * litros ,2);
        }
    }
}
