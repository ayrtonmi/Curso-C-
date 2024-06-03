using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3Perro
{
    internal class Perro
    {
        //atributos
        private string nombre;
        private string raza;
        private float peso;

        //propiedades

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Raza {
            get { return raza; }
            set { raza = value; }

        }

        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }
    }
}
