using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        
        public Cliente Cliente
        {
            get { return clientes.Dequeue(); }

            set 
            {
                bool flag=false;

                foreach (Cliente cliente in clientes)
                {
                    if ( cliente == value)
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    clientes.Enqueue(value);
                }

            }
        }

        


        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            foreach(Cliente i in n.clientes)
            {
                if (i == c)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {

            }

            return true;
        }

    }
}
