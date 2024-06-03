using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2Botella
{
    internal class Botella
    {

        public Botella(string color, string material) { 
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        //sobrecarga de constructor
        public Botella() { }

        //BOTELLA: capacidad, color, material
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        //PROPIEDAD en c# (getter y setter)
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }

        }

        public string Material
        {
            get { return material; }
        }

        public int CantidadActual
        {
           get { return cantidadActual;  }
        }

        //METODOS
        public float recargar()
        {
            if (cantidadActual > 0 )
            {
                int dif = 100 - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public float recargar( int cantidad) //sobrecarga
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
        }
    }
}
