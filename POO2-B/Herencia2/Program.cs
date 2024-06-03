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
            //Vehiculo > Auto > AutoDeportivo >AutoUrbano
            //>Cambioneta
            //>Moto

            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            c1.Color = "Amarillo";
            c2.Color = "Rojo";
            c3.Color = "Blanco";

            Vehiculo v2 = new Camioneta(); //una camioneta ES un vehiculo

            //Camioneta c2 = new Vehiculo();// un vehiculo NO ES o NO SABE que es una camioneta, o un auto o cualquier otro vehiculo

            List<Camioneta> listaCamionetas = new List<Camioneta>();
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            Console.WriteLine("Cantidad de camionetas: "+ listaCamionetas.Count);
            listaCamionetas[1].Color = "Negro";
            c2.Color = "Verde";
            Console.WriteLine("El color es: " + listaCamionetas[1].Color);
            listaCamionetas.Remove(c3);
            Console.WriteLine("Cantidad de camionetas: " + listaCamionetas.Count);

            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine("Color: " + item.Color);
            }

            //ESTO ES PARA EXPLICAR ASOCIACION POR AGREGACION
            Auto a10 = new Auto();
            a10.Motor = new Motor();

            Console.ReadKey();
        }
    }
}
