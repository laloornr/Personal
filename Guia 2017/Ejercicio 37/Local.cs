using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    public class Local : Llamada
    {
        protected float costo;

        #region Propiedades

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        #endregion

        #region Constructores

        public Local(Llamada llamada, float costo):this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        #endregion

        #region Metodos

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine("Costo Llamada: " + this.CostoLlamada);
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return this.costo * base.Duracion;
        }

        #endregion
    }
}
