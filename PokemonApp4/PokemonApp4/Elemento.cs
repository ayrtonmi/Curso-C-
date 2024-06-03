using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp4
{
    internal class Elemento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }


        public override string ToString()
        {
            return Descripcion;
        }
    }
}
