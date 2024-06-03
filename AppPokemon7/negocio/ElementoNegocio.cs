using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listar() //Metodo que se conecta a la DB y devuelve una lista de Elementos
        {
			List<Elemento> listado = new List<Elemento>();//Necesito un objeto Listado para guardar la lista de elementos
			
			//Necesitamos declarar un objeto de Acceso a datos
			AccesoADatos datos = new AccesoADatos();//Nace un objeto que tiene un lector, un comando y una conexion
			
			try
			{
				//Seteamos la consulta sql
				datos.setearConsulta("Select Id, Descripcion from ELEMENTOS");

				//Ejecutamos la lectura y traemos los datos para agregar al listado
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Elemento aux = new Elemento();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];

					listado.Add(aux);
				}

				return listado;
			}
			catch (Exception ex )
			{

				throw ex;
			}
			finally //En bloque finally cerramos la conexion
			{
				datos.cerrarConexion();
			}
        }
    }
}
