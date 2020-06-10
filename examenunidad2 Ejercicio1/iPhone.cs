using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenunidad2_Ejercicio1
{
    class iPhone : Caracteristicas
    {
        private string _strNombre;

        public string nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private int _NumeroModelo;

        public int numeromodelo
        {
            get { return _NumeroModelo; }
            set { _NumeroModelo = value; }
        }
        private int _intNumeroSerie;
        private List<Procesador> miListaProcesador;
        private List<Accesorios> miListaAccesorios;

        public int numeroserie
        {
            get { return _intNumeroSerie; }
            set { _intNumeroSerie = value; }
        }
        public iPhone()
        {
            miListaProcesador = new List<Procesador>();
            miListaAccesorios = new List<Accesorios>();
        }
        ~iPhone()
        {
            miListaProcesador.Clear();
        }
       
        
        public void AgregarProcesador(Procesador p)
        {
           miListaProcesador.Add(p);
        }
        public void AgregarAccesorios(Accesorios a)
        {
            miListaAccesorios.Add(a);
        }
        public IEnumerable<Procesador> ListaProcesador
        {
            get
            {
                foreach (Procesador c in miListaProcesador)
                    yield return c;
                yield break;
            }
        }
        public IEnumerable<Accesorios> ListaAccesorios
        {
            get
            {
                foreach (Accesorios f in miListaAccesorios)
                    yield return f;
                yield break;
            }
        }
    }
}
