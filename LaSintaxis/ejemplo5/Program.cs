using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FUNCIONES....
            Console.WriteLine(saludar("Maxi"));
            Console.ReadKey();

            int b = 10;
            sumar(2, ref b);
        }

        static int sumar(int a, ref int z)
        {
            return a + z;
        }
        static string saludar(string nombre)
        {
            return "Hola " + nombre;
        }
    }
}
