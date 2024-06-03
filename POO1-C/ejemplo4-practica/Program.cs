using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo4_practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora compu1 = new Computadora("Kolink", 650);
            compu1.Procesador = Console.ReadLine();// "Ryzen 5 1600AF";
            compu1.GPU = "RTX 3070";
            compu1.MemoriaRAM = 16;
            compu1.Almacenamiento = 1500;
            compu1.encender();
            
            compu1.cargarComponentes();
            compu1.cargarSO();
            
            Console.ReadKey ();
        }
    }
}
