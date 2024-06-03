using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Aguila : AnimalSalvaje, Ivolador //La interfaz se implementa igual que la herencia con (:)
    {
        public string volar()//defino el metodo de la interfaz
        {
            return "vuela como aguila...";
        }
    }
}
