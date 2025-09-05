using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_03_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer3();
            Console.ReadKey(); //realizando detenimiento de consola
        }


        static void ejer1()
        {
            string nombre, carrera;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al curso de Fundamentos de Algoritmos de {carrera}");


        }

        static void ejer2()
        {
            Console.WriteLine("\"Victor\"");
        }

        static void ejer3()
        {
            Console.WriteLine("Ingrese x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = x + y;
            double division = (double)x / (double)y; 

            Console.WriteLine("\nSuma: " +sum);
            Console.WriteLine("Resta: " + (x - y));
            Console.WriteLine("Multiplicacion: " + (x * y));
            Console.WriteLine("Division: " +division);
        }
    }
}

