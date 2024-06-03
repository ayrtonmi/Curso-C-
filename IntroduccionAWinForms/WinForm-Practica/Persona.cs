using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Practica
{
    internal class Persona
    {
        //ATRIBUTOS Y PROPIEDADES
        private string nombre;
        private string apellido;
        private string email;
        private List<string> heladoFav = new List<string>();
        private string estadoCivil;
        private string fecha;
        private string nacionalidad;
        private List<string> mascotas = new List<string>();


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public List<string> HeladoFav
        {
            get { return heladoFav; }
            set { heladoFav = value; }
        }
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string EstadoCivil
        {
            get { return estadoCivil;}
            set { estadoCivil = value;}
        }

        public List<string> Mascotas
        {

            get { return mascotas;  }
            set { mascotas = value; }
        }

        //METODOS
        
    }
}
