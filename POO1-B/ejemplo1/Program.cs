using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
     class Program
    {
        static void Main(string[] args)
        {

            //construimos un objeto de tipo Persona
            
            Persona p1 = new Persona("PEPE");
            p1.setEdad(27);
            Console.WriteLine(p1.saludar());

            Console.WriteLine("La edad de la persona es: " + p1.getEdad());

            Console.WriteLine(p1.saludar());
            Console.WriteLine(p1.saludar("MAXI"));
            Console.ReadKey();
        }
    }
}
