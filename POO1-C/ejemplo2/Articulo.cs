using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Articulo
    {
        //private int codArticulo;
        //private float precio;
        private int codMarca;//atributo
        
         public int CodigoArticulo { get; set; }//forma corta de la propiedad, se crea el atributo junto a su set y get

        public float Precio { get; set; }
         

        public int CodigoMarca//forma larga de propiedad
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
            }
        }

    }
}
