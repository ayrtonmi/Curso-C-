using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {
        //1.ATRIBUTOS
        private string modelo;
        private string marca;
        private string numeroTel;
        private int codOperador;

        //2.PROPIEDADES Y VALIDACION
        public string Modelo
        {
            get { return modelo; }
        }
        public string Marca
        {
            get { return marca; }
        }

        public string NumeroTel
        {
            get { return numeroTel; }
            set { numeroTel = value; }
        }

        public int CodOperador
        {
            get { return codOperador; }
            set
            {
                if (value > 0 && value < 4)
                    codOperador = value;
                else value = 0; }
            }

        //3.CONSTRUCTORES

        public Telefono(string modelo, string marca) { 

            this.modelo = modelo;
            this.marca = marca;
        }
        //7.METODO LLAMAR
        public string Llamar()
        {
            return "Realizando llamada...";
        }
        
        //8.SOBRECARGA DE METODO LLAMAR
        
        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto + "...";
        }

        }
    
        
}
