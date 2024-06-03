using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class AnimalDomestico: Animal
    {
        public string Nombre { get; set; }

        public override string ToString() //SOBREESCRIBIMOS EL METODO TOSTRING HEREDADO DE LA CLASE OBJECT
        {
            return "Nombre del animal domestico: "+ Nombre;
        }
    }
}
