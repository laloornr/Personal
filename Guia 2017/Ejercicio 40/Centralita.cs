using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Propiedades

        public float GananciasPorLocal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }

        #endregion

        #region Constructores

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        #endregion

        #region Metodos

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0, local = 0, provincial = 0;

            foreach (Llamada l in this.Llamadas)
            {
                if (l.GetType() == typeof(Local))
                {
                    local += ((Local)l).CostoLlamada;
                }
                else
                {
                    provincial += ((Provincial)l).CostoLlamada;
                }
            }

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    retorno = local;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    retorno = provincial;
                    break;
                case Llamada.TipoLlamada.Todas:
                    retorno = local + provincial;
                    break;
            }

            return retorno;
        }

        public void OrdernarLlamadas()
        {
            this.listaDeLlamadas.Sort(this.listaDeLlamadas.First().OrdenarPorDuracion);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----- Centralita -----");
            sb.AppendLine("Razon Social: " + this.razonSocial);
            sb.AppendLine("Ganancias Totales: " + this.GananciasPorTotal);
            sb.AppendLine("Ganancias Locales: " + this.GananciasPorLocal);
            sb.AppendLine("Ganancias Provinciales: " + this.GananciasPorProvincial);
            sb.AppendLine("----- Llamadas -----");
            foreach (Llamada l in this.listaDeLlamadas)
            {
                sb.AppendLine(l.ToString());
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        static public bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;

            foreach (Llamada l in c.listaDeLlamadas)
            {
                if (llamada == l)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        static public bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        static public Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
                c.AgregarLlamada(nuevaLlamada);

            return c;
        }

        #endregion
    }
}
