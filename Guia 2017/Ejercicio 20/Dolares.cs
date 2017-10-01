using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetin
{
    public class Dolares
    {
        double _valor;

        //Constructores
        public Dolares()
        {
            this._valor = 0;
        }

        public Dolares(double cantidad)
        {
            this._valor = cantidad;
        }


        public static explicit operator double(Dolares dolar)
        {
            return dolar._valor;
        }


        public static double operator +(Dolares dolar1, Dolares dolar2)
        {
            return dolar1._valor + dolar2._valor;
        }

        public static double operator -(Dolares dolar1, Dolares dolar2)
        {
            return dolar1._valor - dolar2._valor;
        }

        public static double operator *(Dolares dolar1, double oper1)
        {
            return dolar1._valor * oper1;
        }

        public static double operator /(Dolares dolar1, double oper1)
        {
            return dolar1._valor / oper1;
        }

        public static bool operator ==(Dolares dolar1, Dolares dolar2)
        {
            return (dolar1._valor == dolar2._valor);
        }

        public static bool operator !=(Dolares dolar1, Dolares dolar2)
        {
            return !(dolar1._valor == dolar2._valor);
        }


        // Dolar y Peso
        public static double operator +(Dolares dolar, Pesos peso)
        {
            return dolar._valor + (peso / 17.55);
        }

        public static double operator -(Dolares dolar, Pesos peso)
        {
            return dolar._valor - (peso / 17.55);
        }


        //Dolar y Euro

        public static double operator +(Dolares dolar, Euros euro)
        {
            return dolar._valor + (euro * 1.3642);
        }

        public static double operator -(Dolares dolar, Euros euro)
        {
            return dolar._valor - (euro * 1.3642);
        }
    }
}
