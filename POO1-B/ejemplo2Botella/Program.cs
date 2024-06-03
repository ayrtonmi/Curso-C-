using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2Botella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Botella b1 = new Botella("Rojo", "Plastico");

            b1.Capacidad=200; //se settea directamente la propiedad
            
            int cap1 = b1.Capacidad; // se lee el valor de la capasidad (getter) y se guarda en la variable

            Botella b2 = new Botella("Azul", "Vidrio");
            Console.WriteLine("Capacidad de botella 2: " + b2.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b2.CantidadActual);
            b2.recargar();
            Console.WriteLine("Luego de la recargar, la cantidad es: " + b2.CantidadActual);

            b2.recargar(20);//sobrecarga de metodo
            Console.WriteLine("Luego de la recargar, la cantidad es: " + b2.CantidadActual);
            Console.ReadKey();
        }
    }
}
