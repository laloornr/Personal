using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetin
{
    public class Euros
    {
        double _valor;

        //Constructores
        public Euros()
        {
            this._valor = 0;
        }

        public Euros(double cantidad)
        {
            this._valor = cantidad;
        }

        public static explicit operator double(Euros euro)
        {
            return euro._valor;
        }


        public static double operator +(Euros euro1, Euros euro2)
        {
            return euro1._valor + euro2._valor;
        }

        public static double operator -(Euros euro1, Euros euro2)
        {
            return euro1._valor - euro2._valor;
        }

        public static double operator *(Euros euro1, double oper1)
        {
            return euro1._valor * oper1;
        }

        public static bool operator ==(Euros euro1, Euros euro2)
        {
            return (euro1._valor == euro2._valor);
        }

        public static bool operator !=(Euros euro1, Euros euro2)
        {
            return !(euro1._valor == euro2._valor);
        }

        //Euro y Peso

        public static double operator +(Euros euro, Pesos peso)
        {
            return euro._valor + ((peso / 17.55) / 1.3642 );
        }

        public static double operator -(Euros euro, Pesos peso)
        {
            return euro._valor - ((peso / 17.55) / 1.3642);
        }
    }
}
