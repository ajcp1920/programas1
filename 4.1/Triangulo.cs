using System;
using System.Collections.Generic;
using System.Text;

namespace _4._1
{
	public class Triangulo : Figura
	{
		protected double Altura;
		protected double Ancho;

		public double altura
		{
			get
			{
                return Altura;
			}
			set
			{
                Altura = value;
			}
		}

		public double ancho
		{
			get
			{
                return Ancho;
			}
			set
			{
                Ancho = value;
			}
		}

		public override double CalcularArea()
		{
            return ancho * altura / 2;
		}
	}
}
