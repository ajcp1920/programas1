using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grados
{
    class Temperatura
    {
        public Temperatura(double gc)
        {
            this.gradoscentigrados = gc;
        }
        private double gradoscentigrados;

        public double GradosCentigrados
        {
            get { return gradoscentigrados; }
            set { gradoscentigrados = value; }
        }
        public double ConvertirAFarenheit()
        {
            return ((gradoscentigrados * 1.8000) + 32);
        }
        public double ConvertirGrados()
        {
            return (5*(gradoscentigrados - 32) / 9);
        }
    }
}
