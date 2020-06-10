using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4
{
    public class Peon : Pieza
    {
        public override string Mover()
        {
            return ("El peon se puede mover en su primer movimiento 1 o 2 casillas, despues sus movimientos seran de 1 y se puede comer piezas solo en diagonal");
        }
    }
}
