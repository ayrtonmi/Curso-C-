using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono tel1 = new Telefono("Galaxy", "Samsung");
            Console.WriteLine("Ingrese nro telefonico: ");
            tel1.NumeroTel = Console.ReadLine();
            Console.WriteLine("Ingrese codigo de operador: ");
            tel1.CodOperador = int.Parse(Console.ReadLine());
            Console.WriteLine(tel1.Marca+" "+tel1.Modelo+" " + tel1.CodOperador + tel1.NumeroTel);
            Console.WriteLine("------------------------------");
           
            Telefono tel2 = new Telefono("Edge 30", "Moto");
            Console.WriteLine("Ingrese nro telefonico: ");
            tel2.NumeroTel = Console.ReadLine();
            Console.WriteLine("Ingrese codigo de operador;");
            tel2.CodOperador= int.Parse(Console.ReadLine());
            Console.WriteLine(tel2.Marca+" "+tel2.Modelo+" "+tel2.CodOperador + tel2.NumeroTel);
            Console.WriteLine("------------------------------");

            Console.WriteLine(tel1.Llamar());
            Console.WriteLine(tel2.Llamar(tel1.NumeroTel));
            Console.WriteLine(tel1.Llamar("Maxi"));
            

            Console.ReadKey ();
        }
    }
}
