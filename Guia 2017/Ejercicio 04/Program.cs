using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
            //(excluido el mismo) que son divisores del número.
            //El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            //Escribir una aplicación que encuentre los 4 primeros números perfectos.
            //Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).
            Console.Title = "Ejercicio 4 - Numero Perfecto";

            int b, s, a;
            
            Console.WriteLine("Ejercicio 4\n");
            for (int i = 2; i <= 10000; i++)
            {
                b = 0;
                s = i / 2;

                for (int j = 1; j <= s; j++)
                {
                    a = i % j;
                    if (a == 0)
                    {
                        b = b + j;
                    }
                }

                if (b == i)
                {
                    Console.WriteLine("El numero Perfecto es: " + i);
                }
            }

            Console.ReadKey();
        }
    }
}
