using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_POO
{
    internal class Pais
    {
        public string Nombre { get; set; }
        public string Capital { get; set; }

        public Continente Continente { get; set; }

        public List<Provincia> Provincias { get; set; } = new List<Provincia>(); //REPASAR ATRIBUTOS Y PORPIEDADES
        
        

        public override string ToString()//REPASAR
        {
            return "Pais: "+this.Nombre+" "+"Capital: "+this.Capital;
        }

        public void MostrarProvincias()
        {

            foreach (Provincia item in Provincias)
            {

                Console.WriteLine(item.Nombre);
            }

        }

    }
}
