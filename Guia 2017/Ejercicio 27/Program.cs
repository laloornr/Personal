using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 27";

            // Hacerlo con 5 listas, 2 positivos y 2 negativos
            // usar el sort y crear metodo para ordenar

            // Lista
            List<int> miLista = new List<int>();
            Queue<int> miColaPositivos = new Queue<int>();
            Queue<int> miColaNegativos = new Queue<int>();
            Stack<int> miPilaPositivos = new Stack<int>();
            Stack<int> miPilaNegativos = new Stack<int>();
            Random num = new Random();

            for (int i = 0; i < 20; i++)
            {
                miLista.Add(num.Next(-10, 10));
            }
            Console.WriteLine("Muestro Numeros como fueron cargados\n\n");
            foreach (int numero in miLista)
            {
                Console.WriteLine(numero);
            }
            
            

            Console.ReadKey();
        }
    }
}
