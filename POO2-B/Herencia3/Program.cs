using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalDomestico a1 = new AnimalDomestico();
            a1.Nombre = "Baltazar";
            
            Console.WriteLine(a1.ToString());
            Console.WriteLine(a1.comunicarse());

            Gato g1 = new Gato();
            g1.Nombre = "Tini";
            
            Console.WriteLine(g1.ToString());
            Console.WriteLine(g1.comunicarse());

            Perro p1 = new Perro();
            p1.Nombre = "Apolo";

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.comunicarse());

            List<Animal> animales = new List<Animal>();
            animales.Add(a1);
            animales.Add(new Aguila());
            animales.Add(g1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(p1);
            animales.Add(new Gato());

            List<Ivolador> listaVoladores = new List<Ivolador>();
            // la interfaz funciona como una condicion para crear la instancia de una lista: solamente animales que implementen la interfaz
            //no es un tipo de dato, ni tampoco una clase u objeto, no pueden instanciarse.
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());
            listaVoladores.Add(new Perro());



            //Console.WriteLine("Ruido de animales:");
            //foreach (Animal item in animales)
            //{

            //    Console.WriteLine(item.comunicarse());
            //}

            //Animal aa1 = g1;

            //Gato g8 = (Gato)aa1; //CASTEO EXPLICITO: INDICAMOS QUE LA VARIABLE ES DE TIPO GATO EN ESTE CASO (Gato)

            //Console.WriteLine(g8.Nombre);


            Console.ReadKey();
        }
    }
}
