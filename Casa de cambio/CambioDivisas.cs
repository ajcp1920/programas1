using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_de_cambio
{
    class CambioDivisas
    {
        public CambioDivisas(double tc)
        {
            this.tipocambio = tc;
        }
        private double pesos;

        public double Pesos
        {
            get { return pesos; }
            set { pesos = value; }
        }
        private double tipocambio;

        public double TipoCambio
        {
            get { return tipocambio; }
            set { tipocambio = value; }
        }
        public double ConvertirADolares()
        {
            
            
            return Math.Round(pesos / tipocambio,2);
        }
        public double ConvertirAPesos()
        {
            return Math.Round(pesos * tipocambio, 2);
        }
    }
}
