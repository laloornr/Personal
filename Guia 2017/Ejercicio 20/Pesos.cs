using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetin
{
    public class Pesos
    {
        double _valor;

        //Constructores
        public Pesos()
        {
            this._valor = 0;
        }

        public Pesos(double cantidad)
        {
            this._valor = cantidad;
        }

        public static explicit operator double(Pesos peso)
        {
            return peso._valor;
        }


        public static double operator +(Pesos peso1, Pesos peso2)
        {
            return peso1._valor + peso2._valor;
        }

        public static double operator -(Pesos peso1, Pesos peso2)
        {
            return peso1._valor - peso2._valor;
        }

        public static double operator *(Pesos peso1, double oper1)
        {
            return peso1._valor * oper1;
        }

        public static double operator /(Pesos peso1, double oper1)
        {
            return peso1._valor / oper1;
        }

        public static bool operator ==(Pesos peso1, Pesos peso2)
        {
            return (peso1._valor == peso2._valor);
        }

        public static bool operator !=(Pesos peso1, Pesos peso2)
        {
            return !(peso1._valor == peso2._valor);
        }

        
        //Peso y Dolar
        public static double operator +(Pesos peso, Dolares dolar)
        {
            return peso._valor + (dolar * 17.55) ;
        }

        public static double operator -(Pesos peso, Dolares dolar)
        {
            return peso._valor - (dolar * 17.55);
        }

        //Peso y Euro
        public static double operator +(Pesos peso, Euros euro)
        {
            return  peso._valor + ( (euro * 1.3642) * 17.55 );
        }

        public static double operator -(Pesos peso, Euros euro)
        {
            return peso._valor - ((euro * 1.3642) * 17.55);
        }
        
    }
}
