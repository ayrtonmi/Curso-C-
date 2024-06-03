using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        //Botella: capacidad, color, material
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        //constructor
        public Botella(string color, string material)
        {
            this.color = color; 
            this.material = material;
            capacidad = 100;
            cantidadActual = 0; 
        }


        //PROPIEDAD
        //public int Capacidad
        //{
        //    get { return capacidad;}
        //    set { capacidad = value; }
        //}
        public int Capacidad { 
            get { return capacidad; }

        }
        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        //METODOS
        public float recargar()
        {
            if(cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                //100 50
                //dif
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }
    }
}
