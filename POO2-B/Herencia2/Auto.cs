using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Auto : Vehiculo
    {
        public Auto() { 
        Chasis = new Chasis();
        }   
        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }


        //COMPOSICION
        public Chasis Chasis { get; }


        //AGREGACION
        public Motor Motor { get; set; } // al motor se lo puedo agregar despues
    }
}
