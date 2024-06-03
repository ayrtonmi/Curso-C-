using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPC
{
    internal class Computadora
    {
        //PROPIEDADES
        public string tipo { get; set; }
        public string procesador { get; set; }
        public string gpu { get; set; }
        public int ram { get; set; }
        public int almacenamiento { get; set; }

        //METODOS
        public string Encender() {
            return "Encendiendo...";
        }

        public string Apagar()
        {
            return "Se apagara el sistema... presione una tecla.";
        }

        public string CargarComponentes()
        {
            return "Componentes: "+ tipo +" "+procesador+" "+ gpu +" "+ ram +" "+ almacenamiento+ " cargados."; 
        }

        public string Jugar(string juego)
        {
            return "Ejecutando " + juego + "...";
        }

    }
}
