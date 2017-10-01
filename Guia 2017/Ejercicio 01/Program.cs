using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 5 números por consola, guardándolos en una variable escalar.Luego calcular y mostrar: el
            //valor máximo, el valor mínimo y el promedio.
            Console.Title = "Ejercicio 01";
            double numero, max=0, min=0, prom, suma=0;

            for(int i=0;i<5;i++)
            {
                // Pido el Numero
                Console.Write("Ingrese Numero: ");
                while(! double.TryParse(Console.ReadLine(),out numero))
                {
                    Console.Write("Error, Reingrese Numero: ");
                }
                // Hago la Suma total
                suma = suma + numero;

                // La primera vuelta guardo max y min
                if(i==0)
                {
                    max = numero;
                    min = numero;
                }
                else
                {
                    //Verifico Maximo y Minimo
                    if(max<numero)
                    {
                        max = numero;
                    }
                    if(min>numero)
                    {
                        min = numero;
                    }
                }
            }

            //Calculo Promedio
            prom = suma / 5;
            //Muestro Resultado
            Console.WriteLine("\n\nValor Maximo: {0}\nValor Minimo: {1}\nPromedio: {2}",max,min,prom);
            Console.ReadKey();
        }
    }
}
