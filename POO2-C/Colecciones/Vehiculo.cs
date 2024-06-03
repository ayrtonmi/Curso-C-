using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Vehiculo
    {

        public Vehiculo() {
        
        }
        //ATRIBUTOS Y PROPIEDADES
        private int ruedas;
        public string tipo { get; set; }
        public int Puertas { get; set; }
        public int Pasajeros {  get; set; }
        public int Ruedas { 
            get { return ruedas; }
            set {
                if (value == 2 || value == 4)
                    ruedas = value;
                else 
                    ruedas = -1;
            }
        }

        public string color { get; set; }

        //METODOS
        public void Encender()
        {
            Console.WriteLine ("Encendido...");
        }

        public void CambiarMarcha(int m)
        {
            switch (m)
            {
                case 1: Console.WriteLine("Primera marcha");
                    break;
                case 2: Console.WriteLine("Segunda marcha");
                    break;
                case 3: Console.WriteLine("Tercera marcha");
                    break;
                case 4: Console.WriteLine("Cuarta marcha");
                    break;
                case 5: Console.WriteLine("Quinta marcha");
                    break;
                default: Console.WriteLine("Punto muerto");
                    break;
            }
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando...");
        }

        public string Caracteristicas()
        {
            return "Tipo de vehiculo: " + tipo + " || Cantidad de ruedas: " + Ruedas + " || Cantidad de puertas: " + Puertas + " || Cantidad de pasajeros: " + Pasajeros;
        }

        }
}
