using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Moto : Vehiculo
    {
        private int cilindradas;

        public int Cilindradas
        {
            get { return cilindradas; }
            set { cilindradas = value; }
        }

        public string Caracteristicas(int cilindradas)
        {
            Cilindradas=cilindradas;
            return "Tipo de vehiculo: " + tipo + " || Cantidad de ruedas: " + Ruedas + " || Cantidad de puertas: " + Puertas + " || Cantidad de pasajeros: " + Pasajeros+" || Cilindradas: "+Cilindradas;
        }
    }
}
