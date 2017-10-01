using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Por teclado se ingresa el valor hora, el nombre, la antigüedad(en años) y la cantidad de horas
            //trabajadas en el mes de ‗n‘ empleados de una fábrica.
            //Se pide calcular el importe a cobrar teniendo en cuenta que el total(que resulta de multiplicar el
            //valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
            //multiplicados por $ 150, y al total de todas esas operaciones restarle el 13 % en concepto de
            //descuentos.
            //Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
            //bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
            //Nota: Utilizar estructuras repetitivas y selectivas.

            Console.Title = "Ejercicio 08 - Calcular Sueldo";

            float valorHora, añosAntiguedad, horasPorMes, totalHotas, totalAntiguedad, totalBruto, totalDescuento, totalNeto;
            string nombreEmpleado;
            
            Console.Write("Ingrese el valor de la hora del empleado: ");
            while (!float.TryParse(Console.ReadLine(), out valorHora) || valorHora <= 0)
            {
                Console.Write("Error, Reingrese el Valor por Horas: ");
            }

            Console.Write("Ingrese nombre del empleado: ");
            nombreEmpleado = Console.ReadLine();

            Console.Write("Ingrese antiguedad: ");
            while (!float.TryParse(Console.ReadLine(), out añosAntiguedad) || añosAntiguedad < 0)
            {
                Console.Write("Error, Reingrese Los Años de Antiguedad: ");
            }

            Console.Write("Ingrese la cantidad de horas trabajadas en el mes: ");
            while (!float.TryParse(Console.ReadLine(), out horasPorMes) || horasPorMes <= 0)
            {
                Console.Write("Error, Reingrese Las Horas Trabajadas: ");
            }


            totalHotas = valorHora * horasPorMes;
            totalAntiguedad = añosAntiguedad * 30;
            totalBruto = totalHotas + totalAntiguedad;
            totalDescuento = (float)(totalBruto * 1.13) - totalBruto;
            totalNeto = totalBruto - totalDescuento;

            //Mostrar en pantalla
            Console.Clear();
            Console.WriteLine("   Recibo de sueldo:" + "\n" +
                            "   -----------------" + "\n" +
                            "             Nombre: " + nombreEmpleado + "\n" +
                            "         Antiguedad: " + añosAntiguedad + "\n" +
                            "     Valor por hora: " + valorHora + "\n" +
                            " Total sueldo bruto: " + totalBruto + "\n" +
                            "         Descuentos: " + totalDescuento + "\n" +
                            "Valor neto a cobrar: " + totalNeto + "\n");

            Console.ReadLine();
        }
    }
}
