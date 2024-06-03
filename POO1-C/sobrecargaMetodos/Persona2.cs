using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona2
    {
        //ATRIBUTOS O MIEMBROS
        private int edad;
        private float sueldo;
        private string nombre;

        public Persona2(string n)
        {
            this.nombre = n;
        }
        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }

        public string Nombre { 
            get { return nombre; }
            
        }

        //METODOS
        public string saludar() {
            return "Hola, soy " + nombre;
        }

        public string saludar(string nombre) //sobrecargamos el metodo
        {
            return "Hola "+nombre+", soy..." + this.nombre;
        }

    }
}
