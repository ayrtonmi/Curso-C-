using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Canario : AnimalDomestico, Ivolador// la interfaz se implementa igual que la herencia, con (:)
    {
        public string volar()//se define el metodo de la interfaz
        {
            return "vuela como un canario...";
        }
    }
}
