using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    class Local : Llamada
    {
        protected float costo;

        #region Propiedades

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        #endregion

        #region Constructores

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        #endregion

        #region Metodos

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine("Costo Llamada: " + this.CostoLlamada);
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return this.costo * base.Duracion;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj.GetType());
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
