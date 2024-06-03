using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo4Ventas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Articulo a1 = new Articulo();

            Articulo[] articulos = new Articulo[10]; // vector de 10 articulos

            //articulos[6].CodigoMarca = 3;

            for (int i = 0; i < 10; i++)
            {
                articulos[i] = new Articulo();
                Console.WriteLine("Ingrese los datos del producto...");
                Console.WriteLine("Codigo: ");
                articulos[i].codArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio:");
                articulos[i].precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1-10):");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());
            }
            //vector cargado
            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Codigo Cliente:");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Codigo articulo:");
            venta.CodArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad:");
            venta.Cantidad = int.Parse(Console.ReadLine());
           
            while (venta.CodigoCliente != 0)
            {
                
                Console.WriteLine("Codigo articulo:");
                venta.CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad:");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //pedimos cliente nuevamente
                Console.WriteLine("Codigo Cliente:");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

            }
            Console.ReadKey ();
        }
    }
}
