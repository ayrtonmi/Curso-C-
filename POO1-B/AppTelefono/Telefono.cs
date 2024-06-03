using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppTelefono
{
    internal class Telefono
    {
        //3. Agregar ATRIBUTOS
        //  Modelo string.
        //Marca string.
        //NumeroTelefonico string.
        //CodigoOperador int (1, 2 o 3).

        //private string modelo;
        private string marca;
        //private string nroTelefonico;
        private int codOperador;
        
        //4. Aagragar PROPIEDADES

        // Modelo: solo lectura.Es decir, solo get.
        //Marca: solo lectura.
        //NumeroTelefonico: lectura y escritura.
        //CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.

        public string modelo { get; } // al usar forma corta, el atributo y sus metodos se establecen juntos
           // get { return modelo; }
        
        public string Marca
        {
            get { return marca; }
        }
        public string NroTelefonico { get; set; }
        

        public int CodOperador
        {
            get { return codOperador; }
            
            set { //validamos que el codOperador solo admita 1, 2 o 3
                if (value <= 3 && value > 0)
                    codOperador = value;
                else codOperador = 0;

            }
        }

        //5. Agregar CONSTRUCTOR que reciba modelo y marca
        public Telefono(string modelo, string marca) { 
            this.modelo = modelo;
            this.marca = marca;
            
        }

        //6. Crear algunos objetos y mostrar el estado del Telefono
       //7. Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
       public string Llamar()
        {
            return "Realizando llamada...";
        }
        //8. Sobrecargar el método Llamar(string contacto) para que reciba un contacto y
        //devuelva un string con la leyenda "Llamando a " + contacto
        public string Llamar(string contacto)
        {
            return "Llamando a..." + contacto;
        }



       //9.  Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.
    }
}
