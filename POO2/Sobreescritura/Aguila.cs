using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura
{
    internal class Aguila : AnimalSalvaje, Flyable
    {
        public string volar()
        {
            return "El aguila esta volando...";
        }
    }
}
