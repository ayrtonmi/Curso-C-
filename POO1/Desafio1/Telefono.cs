using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {
        //    Agregale los siguientes atributos:

        //Modelo string.
        //Marca string.
        //NumeroTelefonico string.
        //CodigoOperador int (1, 2 o 3).

        private string modelo;
        private string marca;
        private string numTelefonico;
        private int codOperador;

        //    Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.
        //    Modelo: solo lectura. Es decir, solo get.
        //Marca: solo lectura.
        //NumeroTelefonico: lectura y escritura.
        //CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.

        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca
        {
            get { return marca; }

        }

        public string NumTelefonico { get; set; }

        public int CodOperador
        {
            get { return codOperador; }

            set
            {
                if (value >= 1 && value <= 3)
                    codOperador = value;
                else
                    codOperador = 0;
            }
        }

        //Agregar Constructor que reciba Modelo y Marca.

        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }
        //Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".

        public string Llamar()
        {
            return ("Realizando llamada...");
        }

        //Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
        public string Llamar(string contacto)
        {
            return ("Llamando a... " + contacto);
        }




    }



}
