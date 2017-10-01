using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_31
{
    class PuestoAtencion
    {
        public enum Puesto {caja1,caja2};

        static int numeroActual;
        Puesto puesto;


        static PuestoAtencion()
        {
            numeroActual = 0;
        }


        public PuestoAtencion(Puesto puesto) 
        {
            this.puesto = puesto;
        }


        public int NumeroActual
        {
            get 
            {
                numeroActual++;
                return numeroActual; 
            }
        }

        public bool Atender(Cliente cli)
        {
            
            
            


            return true;
        }
    }
}
