using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
            //por consola.
            //Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%)
            Console.Title = "Ejercicio 3 - Numeros Primos";
            int numero, flag = 0;
            
            //Pido Numero
            Console.Write("Ingrese Numero: ");
            while(! int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Error, Reingrese Numero");
            }

            //Calcula los Primos y Muestra
            for (int i = 2; i <= numero; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        flag = 1;
                    }
                }
                if (flag != 1)
                {
                    Console.WriteLine(i);
                }
                flag = 0;
            }          
            Console.ReadKey();
        }
    }
}
