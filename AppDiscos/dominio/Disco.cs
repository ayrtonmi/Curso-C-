using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Disco
    {
        //ANOTATIONS
        public int Id { get; set; }

        [DisplayName("Título")]
        public string Titulo { get; set; }

        [DisplayName("Fecha")]
        public DateTime FechaLanzamiento { get; set; }

        [DisplayName("Cantidad de canciones")]
        public int CantidadCanciones { get; set; }

        public string UrlImagenTapa { get; set; }

        [DisplayName("Edición")]
        public TipoEdicion Edicion { get; set; }

        public Estilo Estilo { get; set; }
    }
}
