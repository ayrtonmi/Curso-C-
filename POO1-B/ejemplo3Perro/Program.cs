using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3Perro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Perro p1 = new Perro();

            Console.WriteLine("Ingrese nombre de su perro...");
            p1.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su raza...");
            p1.Raza = Console.ReadLine();

            Console.WriteLine("Ingrese su peso en gramos...");
            p1.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine(p1.Nombre + " es un " + p1.Raza + " y pesa " + p1.Peso + " gramos.");
            Console.ReadKey();
            Console.Clear();

            Perro p2 = new Perro();

            Console.WriteLine("Ingrese nombre de su perro...");
            p2.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su raza...");
            p2.Raza = Console.ReadLine();

            Console.WriteLine("Ingrese su peso en gramos...");
            p2.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine(p2.Nombre + " es un " + p2.Raza + " y pesa " + p2.Peso + " gramos.");


            Console.ReadKey(); 



        }
    }
}
