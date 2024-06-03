using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono
            Telefono tel1 = new Telefono("Galaxy S9", "Samsung");
            Telefono tel2 = new Telefono("Edge 11", "Motorola");
            Telefono tel3 = new Telefono("Redmi 11 Lite", "Xiaomi");

            Console.WriteLine("Datos del equipo: " + tel1.Marca + " " +tel1.Modelo);
            Console.WriteLine("Datos del equipo: " + tel2.Marca + " " +tel2.Modelo);
            Console.WriteLine("Datos del equipo: " + tel3.Marca + " " +tel3.Modelo);
           // Console.ReadKey();

            // Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.

            //Ingresamos datos telefonicos tel1
            Console.WriteLine("Ingrese codigo de operador (1, 2 o 3:");
            tel1.CodOperador = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero telefonico...");
            tel1.NumTelefonico = (Console.ReadLine());

            //Mostramos datos telefonicos
            Console.WriteLine("Datos de la linea: " + tel1.CodOperador + " " + tel1.NumTelefonico );
            //Console.ReadKey();

            //Realizamos llamada
            Console.WriteLine(tel1.Llamar("Trabajo"));
            Console.ReadKey();

            //Ingresamos datos telefonicos tel2
            Console.WriteLine("Ingrese codigo de operador: ");
            tel2.CodOperador = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero telefonico:");
            tel2.NumTelefonico = Console.ReadLine();

            //Mostramos datos telefonicos tel2
            Console.WriteLine("Datos de la linea: " + tel2.CodOperador + " " + tel2.NumTelefonico);

            //Realizamos llamada
            Console.WriteLine(tel2.Llamar("Correo"));
            Console.ReadKey();
            

            
        }
    }
}
