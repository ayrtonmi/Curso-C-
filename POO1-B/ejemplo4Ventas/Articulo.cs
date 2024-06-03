using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo4Ventas
{
    internal class Articulo
    {
        //ATRIBUTOS
        //private int codArticulo;
       // private float precio;
        private int codMarca;

        //PROPIEDADES
        public int codArticulo { get; set; } //forma corta, el atributo y su getter y setter se establecen aqui

        public float precio { get; set; }

        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)

                    codMarca = value;
                else codMarca = -1;
            }
        }


    }
}
