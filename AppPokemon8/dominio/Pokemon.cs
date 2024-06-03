using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Pokemon
    {
        //ANNOTATIONS
        [DisplayName ("Número")] //Modifica el nombre del atributo para verlo correctamente en la grilla, por ej
        public int Numero { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
        public Elemento Tipo { get; set; }
        public Elemento Debilidad { get; set; }

        public int Id { get; set; }

    }
}
