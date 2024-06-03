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
            //Condicionales
            //IF  = != > < >= <=  !negacion &&and ||or
            //SWITCH
            int a = 10;
            int b = 12;

            if (a == b && a >= 10)
            {
                Console.WriteLine("Se cumple");

            }
            else if (a == b && a >= 12)
            {
                Console.WriteLine("No se cumple");
            }
            
            //SWITCH
            switch (a)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
