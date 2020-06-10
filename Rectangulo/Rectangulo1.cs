using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo
{
    class Rectangulo1
    {
        //atributos privados
        private double ancho;
        private double largo;
        //propiedades
        public double Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        public double Largo
        {
            get { return largo; }
            set { largo = value; }
        }
        //metodos
        public double CalcularArea()
        {
            // area rectangulo = b x h
            double area;
            area = Ancho * Largo;
            return area;
        }
    }
}
