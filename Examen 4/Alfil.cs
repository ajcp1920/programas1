using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4
{
   public class Alfil : Pieza
    {
        public override string Mover()
        {
            return ("El alfil solo se puede mover en diagonal");
        }
    }
}
