using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4
{
    public class Reina : Pieza
    {
        public override string Mover()
        {
            return ("La reina se puede mover en diagonal y cruz");
        }
    }
}
