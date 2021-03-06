﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 };
        protected Franja franjaHoraria;

        #region Propiedades

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        #endregion

        #region Constructores

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        #endregion

        #region Metodos

        private float CalcularCosto()
        {
            float retorno=0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = (float)(0.99 * base.Duracion);
                    break;
                case Franja.Franja_2:
                    retorno = (float)(1.25 * base.Duracion);
                    break;
                case Franja.Franja_3:
                    retorno = (float)(0.66 * base.Duracion);
                    break;
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine("Costo Llamada: " + this.CostoLlamada);
            return sb.ToString();
        }

        #endregion
    }
}
