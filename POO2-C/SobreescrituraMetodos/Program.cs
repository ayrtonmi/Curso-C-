using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalDomestico a1 = new AnimalDomestico();
            a1.Nombre = "PEPE";

            Console.WriteLine(a1.ToString());
            Console.WriteLine(a1.Comunicarse());

            Gato g1 = new Gato();
            g1.Nombre = "PEPA";
            Console.WriteLine(g1.ToString());
            Console.WriteLine(g1.Comunicarse());

            Perro p1  = new Perro();
            p1.Nombre = "Negrito";
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.Comunicarse());

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(new Canario());
            animales.Add(new Pez());
            animales.Add(g1);
            animales.Add(new Aguila());
            animales.Add(new Gato());

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.Comunicarse()); //POLIMORFISMO: CADA OBJETO SE COMPORTA DISTINTO FRENTE AL MISMO ESTIMULO
                                                       //CADA OBJETO TIENE SU PROPIA DEFINICION DEL METODO QUE HEREDA
            }

            Animal animal = g1;

            Gato g2 = (Gato) animal; //CASTEO EXPLICITO: LE DIGO AL COMPILADOR QUE ESTOY SEGURO DEL TIPO DE OBJETO QUE QUIERO GUARDAR
            g2.Nombre = "PEPITA";

            Console.WriteLine(g2.Nombre);
            Console.WriteLine(g1.Nombre); //TODAS ESTAS VARIABLES APUNTAN AL OBJETO g1
            


            Console.ReadKey();
        }
    }
}
