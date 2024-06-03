using ejemplo3Metodos;
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
            capacidad = 100;
            cantidadActual = 0;
        }
        //sobrecarga de constructor
        public Botella() { }

        //ATRIBUTOS
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;
        

        //PROPIEDAD
        public string Material
        {
            get{ return material; }
        }

        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CantidadActual
        {
            get { return cantidadActual;}
        }

        //PROPIEDAD
        //public int Capacidad
        //{
        //    get { return capacidad; }
        //    set { capacidad = value; }
        //}

        //METODOS
        public float recargar()
        {
            if (cantidadActual>0)
            {
                int dif = capacidad - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual+=dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public float recargar(int cantidad)//sobrecargamos el metodo
        {
            cantidadActual+=cantidad;
            return cantidad * 50 / 100;

        }
    }
}
