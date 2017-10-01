using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
            //una pirámide como la siguiente:
            //      *
            //     ***
            //    *****
            //   *******
            //  *********
            //Nota: Utilizar estructuras repetitivas y selectivas.
            Console.Title = "Ejercicio 10 - Piramide";

            int altura;
            int i, j, k;
           
            Console.Write("Ingrese Altura: ");
            //altura = int.Parse(Console.ReadLine());                   Asi puede dar Error
            if (int.TryParse(Console.ReadLine(), out altura))//         Asi no da Error
            {
                Console.WriteLine();

                for (i = 0; i < altura; i++)
                {
                    Console.WriteLine();
                    for (j = 0; j < altura - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 0; k <= i * 2; k++)
                    {
                        Console.Write("*");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error.");
            }
            Console.ReadKey();
        }
    }
}
