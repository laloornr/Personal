using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 26";
            int[] numeros = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Ingrese Un Numero: ");
                while(!int.TryParse(Console.ReadLine(), out numeros[i]) || numeros[i] == 0)
                {
                    Console.Write("Error, Reingrese: ");
                }
                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine("Los numeros ingresados fueron \n\n");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}",numeros[i]);
            }
            Console.WriteLine("\n\nDe mayor a menor\n\n");
            for (int i = 0; i < 19; i++)
            {
                int aux;
                for (int j = i + 1; j < 20; j++)
                {
                    if (numeros[i] < numeros[j])
                    {
                        aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                if (numeros[i] > 0)
                {
                    Console.WriteLine("{0}", numeros[i]);
                }
            }

            Console.WriteLine("\n\nDe menor a mayor\n\n");
            for (int i = 0; i < 19; i++)
            {
                int aux;
                for (int j = i + 1; j < 20; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.WriteLine("{0}", numeros[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
