﻿using System;
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
            ejer2();
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
    }
}

