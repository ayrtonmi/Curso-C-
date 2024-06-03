using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class EstilosNegocio//Clase para obtener los datos de estilo de los discos
    {
			List<Estilo> lista = new List<Estilo>();
			AccesoDatos datos = new AccesoDatos();//Creamos un objeto de acceso a datos para conectarnos a traves de sus metodos
        public List<Estilo> listar()//Metodo para listar los estilos de disco

        {
			try
			{
				datos.setearConsulta("Select Id, Descripcion from ESTILOS");
				datos.ejecutarLectura();

				while (datos.Lector.Read())//Traemos los datos del lector y los guardamos en cada atributo de un objeto Estilo
				{
					Estilo aux = new Estilo();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];

					lista.Add(aux);//Agregamos el objeto a la lista de estilos
				}

				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally {//cerramos conexion
				datos.cerrarConexion();
			}
        }
    }
}
