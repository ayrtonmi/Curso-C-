using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camioneta c1 = new Camioneta();
            c1.color = "Negro";
            Camioneta c2 = new Camioneta();
            c2.color = "Blanco";
            Camioneta c3 = new Camioneta();
            c3.color = "Azul";

            List<Camioneta> listaCamionetas = new List<Camioneta>(); 
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            //Console.WriteLine("Cantidad de camionetas: "+ listaCamionetas.Count);
            ////listaCamionetas[1].color = "Gris";
            //c2.color = "Rojo";
            //Console.WriteLine("El color es: " + listaCamionetas[1].color);
            //listaCamionetas.Remove(c3);
            //Console.WriteLine("Cantidad de camionetas: " + listaCamionetas.Count);
            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine("Color " + item.color);
            }





            Console.ReadKey ();
              
        }
    }
}
