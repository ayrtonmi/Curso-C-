using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato();
            g1.Nombre = "PEPE";

            Perro p1 = new Perro();
            p1.Nombre = "PIPO";

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(new Canario());
            animales.Add(new Aguila());
            animales.Add(g1);
            animales.Add(new Pez());
            animales.Add(new Gato());

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.comunicarse());
            }

            List<Flyable> voladores = new List<Flyable>();
            voladores.Add(new Canario()); //puedo agregar cualquier animal que implemente la interface
            voladores.Add(new Aguila()); // no puedo instanciar un Flyable porque no es una clase
            //voladores.Add(new Perro()); //no puedo agregar un Perro porque no implementa la inferfaz




            Animal a1 = g1;

            Gato g2 = (Gato)a1; //casteo explicito: le indico al compilador que el objeto que asigno a g2 es de tipo Gato
            g2.Nombre = "BLANQUITO";


            Console.WriteLine(g1.ToString());
            Console.WriteLine(g1.comunicarse());

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.comunicarse());
            Console.ReadKey();
        }
    }
}
