using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTelefono
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("Galaxy A12 ", "Samsung");
            t1.NroTelefonico = "344245123";
            t1.CodOperador = 4;
            Console.WriteLine("Telefono #1: " + t1.Marca + " " + t1.modelo +" "+ t1.CodOperador +" "+ t1.NroTelefonico); 
            

            Telefono t2 = new Telefono("Edge 30 ", "Moto");
            t2.NroTelefonico = "3442212444";
            t2.CodOperador = 1;
            Console.WriteLine("Telefono #2: " + t2.Marca + " " + t2.modelo + " " + t1.CodOperador + " " + t2.NroTelefonico);

            Console.WriteLine(t2.Llamar());
            Console.WriteLine(t1.Llamar("Juan"));

            Console.ReadKey();
        }
    }
}
