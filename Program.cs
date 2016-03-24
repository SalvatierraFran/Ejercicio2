using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());

            cuadrado = Math.Pow(num, 2);
            cubo = Math.Pow(num, 3);

            Console.Write("\nSu cuadrado es " + cuadrado);
            Console.Write("\nSu cubo es " + cubo);

            Console.ReadKey();
        }
    }
}
