using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    abstract class Llamada
    {
        public enum TipoLlamada { Local, Provincial, Todas };
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region Propiedades

        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public abstract float CostoLlamada
        {
            get;
        }

        #endregion

        #region Constructores

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        #endregion

        #region Metodos

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion: " + this.duracion);
            sb.AppendLine("Nro Destino: " + this.nroDestino);
            sb.AppendLine("Nro Origen: " + this.nroOrigen);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }
            else if (llamada1.duracion < llamada2.duracion)
            {
                retorno = -1;
            }
            return retorno;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;
            if (object.Equals(l1.GetType(), l2.GetType()))
            {
                retorno = l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen;
            }
            return retorno;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        #endregion
    }
}
