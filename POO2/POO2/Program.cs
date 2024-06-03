using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Empleado e1 = new Empleado(); // Empleado es una clase abstract
            e1.Nombre = "Luis";
            Developer d1 = new Developer();
            Developer d2 = new Developer();
            Developer d3 = new Developer();

            d1.Nombre = "Esteban";
            d1.Stack = "MERN";
            d2.Stack = "MEAN";
            d3.Stack = "MEAN";
            Lider l1 = new Lider();// Lider es una clase static
            Lider l2 = new Lider();
            l1.Nombre = "Carlos";
            l2.Nombre = "Maria";

            Lider.algo();// clase estatica: no necesita ser instanciada, solo se usa
            
            //crear listas
            List<Developer> listaDeveloper = new List<Developer>();

            List<Lider> listaLideres = new List<Lider>();

            List<Empleado> listaEmpleados = new List<Empleado>();

            //agregar objetos a las listas
            listaDeveloper.Add(d1);
            listaDeveloper.Add(d2);
            listaDeveloper.Add(d3);

            listaLideres.Add(l1)
;           listaLideres.Add (l2);

            listaEmpleados.Add(e1);


            Console.WriteLine("La cantidad de developers es: " + listaDeveloper.Count);
            //listaDeveloper[1].Stack = "MERN";
            d2.Stack = "No tiene";

            Console.WriteLine("El stack del segundo developer es: " + listaDeveloper[1].Stack);
            
            listaDeveloper.Remove(d1); // remover objeto
            Console.WriteLine("La cantidad de developers es: " + listaDeveloper.Count);

            foreach (Developer dev in listaDeveloper) //foreach sirve para recorrer listas
            {
                Console.WriteLine("Stack: "+ dev.Stack); 
            }

            Console.ReadKey();
        }
    }
}
