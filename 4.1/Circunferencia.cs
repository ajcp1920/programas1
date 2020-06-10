using System;
using System.Collections.Generic;
using System.Text;

namespace _4._1
{
	public class Circunferencia : Figura
	{
		protected double Radio;

		public double radio
		{
			get
			{
                return Radio;
			}
			set
			{
                Radio = value;
			}
		}

		public override double CalcularArea()
		{
            return Math.Pow(radio,2) * Math.PI;
		}

        
    }
}
