﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Gato : AnimalDomestico
    {
        public override string comunicarse()//SOBREESCRIBIMOS EL METODO COMUNICARSE HEREDADO DE LA CLASE ANIMAL
        {
            return "miau...miau...";
        }
    }
}
