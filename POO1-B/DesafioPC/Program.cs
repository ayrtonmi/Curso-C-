using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora pc1 = new Computadora();
            Console.WriteLine("Ingrese tipo:");
            pc1.tipo=Console.ReadLine();
            Console.WriteLine("Ingrese procesador:");
            pc1.procesador = Console.ReadLine();
            Console.WriteLine("Ingrese gpu:");
            pc1.gpu = Console.ReadLine();
            Console.WriteLine("Ingrese cantidad de ram:");
            pc1.ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de almacenamiento en Gb:");
            pc1.almacenamiento = int.Parse(Console.ReadLine());

            Console.WriteLine(pc1.Encender());
            Console.WriteLine(pc1.CargarComponentes());
            Console.WriteLine(pc1.Jugar("Starfield"));

            Console.WriteLine(pc1.Apagar());
            Console.ReadKey();
        }
    }
}
