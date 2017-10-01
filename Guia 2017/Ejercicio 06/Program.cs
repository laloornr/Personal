using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que determine si un año es bisiesto.
            //Un año es bisiesto si es múltiplo de 4.Los años múltiplos de 100 no son bisiestos, salvo si ellos
            //también son múltiplos de 400.Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            //Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).

          Console.Title = "Ejercicio 6 - Año Biciesto";

            float anio;
            
            Console.Write("Ingrese año: ");
            if (float.TryParse(Console.ReadLine(), out anio))
            {

                if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
                {
                    Console.WriteLine("Es biciesto");
                }
                else
                {
                    Console.WriteLine("No es biciesto");
                }
            }

            Console.ReadKey();
        }
    }
}
