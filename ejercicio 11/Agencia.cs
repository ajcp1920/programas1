using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_11
{
    public class Agencia
    {
        private double coste;

        public double Coste
        {
            get { return coste; }
            set { coste = value; }
        }
        public double CalcularGanancia()
        {
            return Math.Round(coste * 0.12,2);
        }
        public double CalcularImpuesto()
        {
            return Math.Round(coste * 0.06,2);
        }
        public double CalcularTotal()
        {
            return Math.Round(coste + CalcularGanancia() + CalcularImpuesto(),2);
        }
    }
}
