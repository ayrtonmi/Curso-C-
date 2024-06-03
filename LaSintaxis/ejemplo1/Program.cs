using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        private static float f20;

        static void Main(string[] args)
        {
            //Declarar variables
            int a;
            String name;
            float price;

            a = 0;
            name = "Pedro";
            price = f20;
           
            Console.WriteLine("Hola, ingrese un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero ingresado es: " + a);
            Console.ReadKey();
        }
    }
}
