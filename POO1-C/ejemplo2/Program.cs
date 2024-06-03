using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulos = new Articulo[10];
            //articulos[6].CodigoMarca = 3;

            //cargamos el vector de 10 articulos articulos
            for (int x = 0; x < 10; x++)
            {
                articulos[x] = new Articulo();

                Console.WriteLine("Ingrese los datos del producto..");
                Console.WriteLine("Codigo: ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio:");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 a 10):");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            //vector cargado


            //REGISTRO DE LAS VENTAS
            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta:");
            Console.WriteLine("Codigo de cliente:");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                
                Console.WriteLine("Codigo articulo...");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad:");
                venta.Cantidad = int.Parse(Console.ReadLine());
                //trabajamos...
                //pide cliente nuevamente...
                Console.WriteLine("Ingrese la venta:");
                Console.WriteLine("Codigo de cliente:");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
