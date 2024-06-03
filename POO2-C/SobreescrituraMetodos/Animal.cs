using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraMetodos
{
    internal class Animal
    {
        public virtual string Comunicarse() // VIRTUAL permite sobreescribir dicho metodo
        {
            return "Ruido...ruido...";
        }
    }
}
