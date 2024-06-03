using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    abstract class Empleado {
        //sealed class Empleado : sealed me permite determinar que una clase no puede ser heredada, sirve para marcar el final de una jerarquia de clases
        //abstract : no permite que la clase sea instanciada, debo heredarla para gestionar sus atributos y propiedades
        public string Nombre { get; set; }
        public string Apeliido { get; set; }

        public int Legajo { get; set; }

    }
    

    
}
