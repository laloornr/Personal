using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que imprima por pantalla una pirámide como
            //la siguiente:
            //*
            //***
            //*****
            //*******
            //*********
            //El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
            //ejemplo anterior la altura ingresada fue de 5.
            //Nota: Utilizar estructuras repetitivas y selectivas.
            Console.Title = "Ejercicio 09 - Piramide";

            int altura;
            int i, j;
            
            Console.Write("Ingrese Altura: ");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (i = altura; i > 0; i--)
            {
                for (j = 0; j < altura - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.ReadKey();
        }
    }
}
