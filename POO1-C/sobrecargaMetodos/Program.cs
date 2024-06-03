using ejemplo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecargaMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona2 p1 = new Persona2("PEPE");
            p1.setEdad(20);
            Console.WriteLine(p1.saludar());
            Console.WriteLine(p1.saludar("MAXI"));//metodo sobrecargado
            Console.WriteLine("La edad de "+p1.Nombre+ " es: "+p1.getEdad());

            Console.ReadKey();
        }
    }
}
