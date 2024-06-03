using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_POO
{
    internal class Continente
    {
        public string Nombre { get; set; }

        public List<Pais> Paises { get; set; } = new List<Pais>(); //REPASAR ATRIBUTOS Y PORPIEDADES



        public override string ToString() //REPASAR 
        {
            return "Continente: "+this.Nombre;
        }

        public void MostrarPaises() {
        
          foreach (Pais item in Paises) {

                Console.WriteLine(item.Nombre);
            }
        
        }

    }
}
