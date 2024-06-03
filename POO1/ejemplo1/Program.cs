using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona: edad, sueldo, nombre
            //int edad;
            //float sueldo;
            //string nombre;
            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];

            Persona p1 = new Persona("PEPE");
            p1.setEdad(20);

            Console.WriteLine(p1.saludar());
            Console.WriteLine("La edad de la persona es: " + p1.getEdad());
            
            Console.ReadKey();

            Botella b1 = new Botella("Rojo", "Vidrio");
            //b1.Capacidad = 200;
            //int algo = b1.Capacidad;

            Console.WriteLine("La capacidad de la botella es de: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b1.CantidadActual);
            b1.recargar();
            Console.WriteLine("Luego de la recarga, la cantidad actual es: " + b1.CantidadActual);
            Console.ReadKey();

            Perro d1 = new Perro();
            d1.Raza = "bulldog";
            d1.Nombre = "Pepe";
            d1.Edad = "adulto";
            d1.Peso = 2500;

            Console.WriteLine("La raza de " + d1.Nombre + " es " + d1.Raza + ". Es un " + d1.Edad + " de " + d1.Peso + "g.");
            Console.ReadKey();

            Perro d2 = new Perro();
            Console.WriteLine("Ingrese el nombre del perro:");
            d2.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la raza: ");
            d2.Raza = Console.ReadLine();
            Console.WriteLine("Ingrese la edad: ");
            d2.Edad = Console.ReadLine();
            Console.WriteLine("Ingrese el peso en gramos: ");
            d2.Peso = float.Parse(Console.ReadLine());
            Console.WriteLine("La raza de " + d2.Nombre + " es " + d2.Raza + ". Es un " + d2.Edad + " de " + d2.Peso + "g.");
            Console.ReadKey();  

        }
    }
}
