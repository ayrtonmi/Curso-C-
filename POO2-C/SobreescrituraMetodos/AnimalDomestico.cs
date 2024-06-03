using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraMetodos
{
    internal class AnimalDomestico : Animal
    {
        public string  Nombre { get; set; }

        public override string ToString() //sobreescribimos el metodo to string heredado de la clase object
        {
            return "Animal Domestico: "+ Nombre;
        }
    }
}
