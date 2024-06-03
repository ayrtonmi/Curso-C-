using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Perro
    {
        //ATRIBUTOS
        private string nombre;
        private string raza;
        private string sexo;
        private float peso;
        private string edad;

        //PROPIEDADES
        public string Nombre
        {
            get {return nombre; }
            set { nombre = value; }
        }

        public string Raza
        { get { return raza; } 
          set {  raza = value; } 
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }

    }
}
