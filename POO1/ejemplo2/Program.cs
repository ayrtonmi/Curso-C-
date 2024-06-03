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

            //cargar vector con articulos
            for (int i = 0; i < 10; i++)
            {
                articulos[i] = new Articulo();
                Console.WriteLine("Ingrese los datos del producto...");
                Console.WriteLine("Código: ");
                articulos[i].CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 a 10): ");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());

                

            }
                //cargar venta
                Venta venta = new Venta();
                Console.WriteLine("Ingrese la venta...");
                Console.WriteLine("Codigo de Cliente:");
                venta.CodCliente = int.Parse(Console.ReadLine());
           
            while (venta.CodCliente != 0)
                { 
                    
                    Console.WriteLine("Codigo Articulo");
                    venta.CodArticulo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Cantidad: ");
                    venta.Cantidad = int.Parse(Console.ReadLine());
                    //trabajamos....

                    //pido cliente nuevamente: 
                    Console.WriteLine("Ingrese la venta...");
                    Console.WriteLine("Codigo de Cliente:");
                    venta.CodCliente = int.Parse(Console.ReadLine());
                }
            
        }
    }
}
