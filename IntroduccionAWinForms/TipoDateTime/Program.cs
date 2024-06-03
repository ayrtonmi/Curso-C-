using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2004,4,1);//Establecemos la fecha por parametros YY/MM/DD
            
            DateTime fecha2 = DateTime.Now;//Establecemos la fecha actual de nuestro sistema

            Console.WriteLine("La fecha es: "+fecha2.ToString("dddd MM/yyyy"));//La variable fecha tiene varios metodos para
                                                                               //mostrar info de diferentes maneras

            DateTime fecha3 = new DateTime(2004, 4, 1);

            Console.WriteLine("La fecha es: " + fecha3.ToString());
            fecha3 = DateTime.Now;
            Console.WriteLine("La fecha de hoy es: "+fecha3.ToShortDateString());
            Console.WriteLine("La fecha de hoy es: " + fecha3.ToString("dd MM yyyy"));



            Console.ReadKey();
        }
    }
}
