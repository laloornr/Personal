using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Cliente
    {
        private string nombre;
        private int numero;

#region Propiedades
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        } 

        public int Numero
        {
            get { return this.numero; }
        }
#endregion


        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero,string nombre)
        {
            this.numero = numero;
            this.nombre = nombre;
        }


        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            return (cliente1.numero == cliente2.numero);
        }

        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1.numero == cliente2.numero);
        }

    }
}
