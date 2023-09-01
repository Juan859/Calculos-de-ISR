
using System;

namespace CalculadoraISR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora ISR");
            Console.WriteLine("----------------");

            // Solicitar los datos del empleado
            Console.Write("Ingrese el nombre del empleado: ");
            string nombreEmpleado = Console.ReadLine();

            Console.Write("Ingrese la edad del empleado: ");
            int edadEmpleado = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el departamento del empleado: ");
            string departamentoEmpleado = Console.ReadLine();

            Console.Write("Ingrese el sueldo del empleado: ");
            double sueldo = double.Parse(Console.ReadLine());

            // Calcular el ISR
            double isr = CalcularISR(sueldo);

            // Calcular el sueldo con la deducción de ISR aplicada
            double sueldoConDeduccion = sueldo - isr;

            // Mostrar los resultados
            Console.WriteLine("----------------");
            Console.WriteLine("Nombre del empleado: " + nombreEmpleado);
            Console.WriteLine("Edad del empleado: " + edadEmpleado);
            Console.WriteLine("Departamento del empleado: " + departamentoEmpleado);
            Console.WriteLine("Sueldo sin deducción de ISR: " + sueldo);
            Console.WriteLine("Monto del ISR a deducir: " + isr);
            Console.WriteLine("Sueldo con deducción de ISR aplicada: " + sueldoConDeduccion);

            Console.ReadLine();
        }

        static double CalcularISR(double sueldo)
        {
            // Implementar la lógica para calcular el ISR aquí
            // Puedes usar la tabla de la DGII u otra fuente confiable para realizar los cálculos
            // Por simplicidad, aquí solo se devolverá un valor constante como ejemplo

            // En este ejemplo, se supone que el ISR es un 10% del sueldo
            return sueldo * 0.1;
        }
    }
}
