using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Mesa
    {
        private int Hsencilla;

        public int HamSencilla
        {
            get { return Hsencilla; }
            set { Hsencilla = value; }
        }
        private int Hqueso;

        public int HamQueso
        {
            get { return Hqueso; }
            set { Hqueso = value; }
        }
        private int Hespecial;

        public int HamEspecial
        {
            get { return Hespecial; }
            set { Hespecial = value; }
        }
        private int papas;

        public int Papas
        {
            get { return papas; }
            set { papas = value; }
        }
        private int refresco;

        public int Refresco
        {
            get { return refresco; }
            set { refresco = value; }
        }
        private int postre;

        public int Postre
        {
            get { return postre; }
            set { postre = value; }
        }
        private int hsencilla;
        private int hqueso;
        private int hespecial;
        private int ppas;
        private int refres;
        private int post;
        public Mesa()
        {
            hsencilla = 15;
            hqueso = 18;
            hespecial = 20;
            ppas = 8;
            refres = 5;
            post = 6;
            return;
        }
        public double CalcularCosto()
        {
            return ((Hsencilla * hsencilla) + (Hqueso * hqueso) + (Hespecial * hespecial) + (papas * ppas) + (refresco*refres) + (postre* post));
        }
    }
}
