using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //Persona: edad, sueldo, nombre

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        //ATRIBUTOS O MIEMBROS
        private int edad;
        private float sueldo;
        private string nombre;

        //funcion para escribir la edad
        public void setEdad(int e)
        {
            edad = e;
        }

        //metodo para obtener o leer la edad
        public int getEdad() { 
            return edad; 
        }

        

        //Metodos
        public string saludar()
        {
            return "Hola, soy " + nombre;
        }

        public string saludar(string personaje)
        {
            return "Hola, " +personaje + " soy... " + nombre;          
        }
    }
}
