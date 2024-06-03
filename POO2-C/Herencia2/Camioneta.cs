using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Camioneta : Vehiculo
    {
        public float CargaMaxima { get; set; }

        public string Caracteristicas(float carga)
        {
            CargaMaxima = carga;
            return "Tipo de vehiculo: " + tipo + " || Cantidad de ruedas: " + Ruedas + " || Cantidad de puertas: " + Puertas + " || Cantidad de pasajeros: " + Pasajeros+" || CargaMaxima: "+CargaMaxima;
        }
        
    }
}
