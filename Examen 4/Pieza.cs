using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4
{
    public abstract class Pieza
    {
        private string _strPosicion;

        public string posicion
        {
            get { return _strPosicion; }
            set { _strPosicion = value; }
        }
        private string _strNombre;

        public string nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private double _dblMedida;

        public double medida
        {
            get { return _dblMedida; }
            set { _dblMedida = value; }
        }
        private string _strColor;

        public string MyProperty
        {
            get { return _strColor; }
            set { _strColor = value; }
        }
        public abstract string Mover();

    }
}
