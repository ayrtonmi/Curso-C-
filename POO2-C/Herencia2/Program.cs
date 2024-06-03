using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();

            Vehiculo v2;
            v2 = new Camioneta();//guardamos un objeto camioneta en una variable vehiculo, una camioneta ES un vehiculo
            Vehiculo v3 = new Camioneta();

            // Camioneta c2 = new Vehiculo();// no se puede guardar un objeto vehiculo en una variable camioneta ya que no sabemos si vehiculo ES una camioneta




            Camioneta c4 = new Camioneta();
            c4.tipo = "Camioneta";
            c4.Ruedas = 4;
            c4.CargaMaxima = 500;
            c4.Pasajeros = 2;
            c4.Puertas= 5;
            c4.Encender();
            c4.CambiarMarcha(1);
            Console.WriteLine("Frenar? 1: si // 2: no");
            int op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                c4.Frenar();
                
            }else if (op == 2)
            {
                c4.Acelerar();
            }
            Console.WriteLine("-------------------");
            Console.WriteLine(c4.Caracteristicas(500));
            Console.WriteLine("----------------------");

            Moto m1 = new Moto();
            m1.Cilindradas = 150;
            m1.Pasajeros = 2;
            m1.Puertas = 0;
            m1.tipo = "Moto";
            m1.Ruedas = 2;
            m1.Encender();
            m1.Acelerar();
            m1.CambiarMarcha(1);
            Console.WriteLine("Frenar? 1: si // 2: no");
            int opm1 = int.Parse(Console.ReadLine());
            if (opm1 == 1)
            {
                m1.Frenar();

            }
            else if (opm1 == 2)
            {
                m1.Acelerar();
            }
            Console.WriteLine("-------------------");
            Console.WriteLine(m1.Caracteristicas(150));



            Console.ReadKey ();

        }
    }
}
