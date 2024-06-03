using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona/Empleado > lider > developer > tester
            Empleado e1 = new Empleado();

            Developer d1 = new Developer();
            
            Lider l1 = new Lider();
        }
    }
}
