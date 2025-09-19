using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_de_campo_4
{
    internal class Program
    {
        // CASO 1: Método (void) que muestra la suma en pantalla
        static void MostrarSuma(int a, int b)
        {
            int suma = a + b;
            Console.WriteLine($"La suma de {a} + {b} es: {suma}");
        }

        // CASO 2: Función (con retorno) que calcula el promedio de 3 notas
        static double CalcularPromedio(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3;
        }

        static void Main(string[] args)
        {
            // ----------- CASO 1 ---------------
            Console.WriteLine("CASO 1: SUMA DE DOS NÚMEROS ");
            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            MostrarSuma(num1, num2); // Llamada al método

            // ----------- CASO 2 ---------------
            Console.WriteLine("\nCASO 2: PROMEDIO DE NOTAS ");
            Console.Write("Ingrese la primera nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la tercera nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            double promedio = CalcularPromedio(nota1, nota2, nota3); // Llamada a la función
            Console.WriteLine($"El promedio de las notas es: {promedio:F2}");

            // Pausa la consola
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
