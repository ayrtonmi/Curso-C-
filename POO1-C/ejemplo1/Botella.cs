using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    
    internal class Botella
    {
          //CONSTRUCTOR  
        public Botella(string color, string material)
        {
            this.color = color; //color de objeto = color parametro
            this.material = material;
        }
        //sobrecarga de constructor
        public Botella() { }

        private int capacidad;
        private string color;
        private string material;

        public string Material
        {
            get{ return material; }
        }

        //PROPIEDAD
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
    }
}
