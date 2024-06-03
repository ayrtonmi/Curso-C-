using ejemplo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Botella B1 = new Botella("Rojo", "Vidrio");
            Console.WriteLine("Capacidad de botella: "+B1.Capacidad);
            Console.WriteLine("La cantidad actual es: "+B1.CantidadActual);

            B1.recargar(20);//metodo sobrecargado
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + B1.CantidadActual);
            B1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + B1.CantidadActual);


            Console.ReadKey();
        }
    }
}
