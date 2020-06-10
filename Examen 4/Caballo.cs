using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4
{
    public class Caballo : Pieza
    {
        public override string Mover()
        {
            return ("El caballo se mueve solamente en forma L");
        }
    }
}
