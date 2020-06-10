using System;

namespace WindowsFormsApp1
{
    class Circunferencia
    {
        public Circunferencia(double dblRadio)
        {
            radio = dblRadio;
        }
        private double radio;

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }
        public double CalcularArea()
        {
            double area;
            area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
        public double CalcularPerimetro()
        {
            double perimetro;
            perimetro = 2 * (Math.PI * radio);
            return perimetro;
        }

    }
}
