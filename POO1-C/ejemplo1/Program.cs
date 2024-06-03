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
           Persona p1 = new Persona("Lucas");
            p1.setEdad(20);
            Console.WriteLine(p1.saludar());
            Console.WriteLine("La edad de la persona es: "+ p1.getEdad());


            Botella b1 = new Botella("azul", "plastico");
            b1.Capacidad = 200;//asignacion de la propiedad Capacidad
            Botella b2 = new Botella();

            int algo = b1.Capacidad;//lectura del valor
            
            Perro perro1 = new Perro();
            perro1.Nombre = "Apolo";
            perro1.Raza = "Caniche";
            perro1.Peso = 10;

            Perro perro2 = new Perro();
            perro2.Nombre = "Negro";
            perro2.Raza = "Cruza galgo labrador";
            perro2.Peso = 25.5F;

            Console.WriteLine(perro1.Nombre +" " + perro1.Raza + " " + perro1.Peso);
            Console.WriteLine(perro2.Nombre +" " + perro2.Raza + " " + perro2.Peso);

            Console.ReadKey();
        }
    }
}
