using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un número y mostrar: el cuadrado y el cubo del mismo.Se debe validar que el número sea
            //mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
            //Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
            Console.Title = "Ejercicio 02";
            double numero, cuadrado = 0, cubo = 0;

            // Pido el Numero
            Console.Write("Ingrese Numero: ");
            while (!double.TryParse(Console.ReadLine(), out numero) || numero <0)
            {
                Console.Write("Error, Reingrese Numero: ");
            }
            //Calculo Cuadrado
            cuadrado = Math.Pow(numero, 2);
            //Calculo Cubo
            cubo = Math.Pow(numero, 3);

            //Muestro Resultado
            Console.WriteLine("\n\nNumero: {0}\nCuadrado: {1}\nCubo: {2}", numero,cuadrado,cubo);
            Console.ReadKey();
        }
    }
}
