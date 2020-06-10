using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6
{
    class Articulo
    {
        public Articulo(int c, string d,double p, int ca)
        {
            this.clave = c;
            this.descripcion = d;
            this.precio = p;
            this.cantidad = ca;
        }

        

        private int clave;

        public int Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private int cantidad;
        private int v;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public double CalcularIVA()
        {
            return Precio * .16;
        }

    }
}
