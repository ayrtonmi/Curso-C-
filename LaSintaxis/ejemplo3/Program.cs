using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CICLOS
            //for, while, do while
            // ++ -- += -=
            int a = 10;
            for (int i = 0; i < 10; i++)
            {
                while (a != 0)
                {
                    Console.WriteLine("Hola " + a);
                    a--;
                }
            }
            Console.ReadKey();

            do { 
            }
            while (true);
        }
    }
}
