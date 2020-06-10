using System;
using System.Collections.Generic;
using System.Text;

namespace _4._1
{
	public class Rectangulo : Figura
	{
		protected double Largo;
		protected double Ancho;

		public double largo
		{
			get
			{
                return Largo;
			}
			set
			{
                Largo = value;
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
            return ancho * largo;
		}
	}
}
