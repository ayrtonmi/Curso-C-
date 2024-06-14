using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class DiscosNegocio
    {
        public List<Disco> listar()
        {
            List<Disco> listadiscos = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion as Estilo, T.Descripcion as Edicion, E.Id, T.Id from dbo.DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id And D.Activo=1";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)lector["Id"];
                    aux.Titulo = (string)lector["Titulo"];

                    if (lector["FechaLanzamiento"] != DBNull.Value)
                    {
                        aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    }

                    //Puede que la URL sea nulla, y debemos validarla 
                    //if(!(lector.IsDBNull(lector.GetOrdinal("UrlImagenTapa"))))//Si NO es null lo que quiero leer de la DB, se lee

                    // aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    //sino no se lee

                    //Otra forma:
                    if (!(lector["UrlImagenTapa"] is DBNull))
                    {
                        aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    }

                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    aux.Edicion = new TipoEdicion();
                    aux.Estilo = new Estilo();
                    aux.Edicion.Descripcion = (string)lector["Edicion"];
                    aux.Edicion.Id = (int)lector["Id"];
                    aux.Estilo.Descripcion = (string)lector["Estilo"];
                    aux.Estilo.Id = (int)lector["Id"];
                    listadiscos.Add(aux);
                }
                conexion.Close();  
                return listadiscos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregar (Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();//Necesito un objeto datos para conectarme
            try
            {
                //Seteamos consulta INSERT
                datos.setearConsulta("Insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion, UrlImagenTapa, Activo) values (@titulo ,@fecha, @ncanciones, @IdEstilo, @IdEdicion, @UrlImagen, @estado)");
                //Seteamos parametros del comando: cuando se ejecute la sentencia sql, se reemplaza la variable @ por el valor seteado
                datos.setearParametro("@titulo", nuevo.Titulo);
                datos.setearParametro("@fecha", nuevo.FechaLanzamiento);
                datos.setearParametro("@ncanciones", nuevo.CantidadCanciones);
                datos.setearParametro("@idestilo", nuevo.Estilo.Id);
                datos.setearParametro("@idedicion", nuevo.Edicion.Id);
                datos.setearParametro("@UrlImagen", nuevo.UrlImagenTapa);
                datos.setearParametro("@estado", 1);
                //Ejecutamos la consulta INSERT
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar (Disco disco)
        {
       //     // Verificar que la fecha esté dentro del rango permitido
       //     if (nuevo.FechaLanzamiento < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ||
       //nuevo.FechaLanzamiento > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
       //     {
       //         // Establecer una fecha predeterminada válida
       //         nuevo.FechaLanzamiento = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
       //     }
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update DISCOS set Titulo = @titulo, FechaLanzamiento = @fecha, CantidadCanciones = @ncanciones, UrlImagenTapa = @urlimg, IdEstilo = @estilo, IdTipoEdicion = @edicion where Id =@id");
                datos.setearParametro("@titulo", disco.Titulo);
                datos.setearParametro("@fecha",disco.FechaLanzamiento);
                datos.setearParametro("@ncanciones",disco.CantidadCanciones);
                datos.setearParametro("@urlimg",disco.UrlImagenTapa);
                datos.setearParametro("@estilo",disco.Estilo.Id);
                datos.setearParametro("@edicion",disco.Edicion.Id);
                datos.setearParametro("@id",disco.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarFisico (int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from DISCOS where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void eliminarLogico(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("update DISCOS set Activo = 0 where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Disco> filtrar(string campo, string criterio, string filtro)
        {
            List<Disco> lista = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                
                
                string consulta = "Select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion as Estilo, T.Descripcion as Edicion, E.Id, T.Id from dbo.DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id And D.Activo=1 And ";
                
                if (campo == "Pistas")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "CantidadCanciones > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "CantidadCanciones < " + filtro;
                            break;
                        default:
                            consulta += "CantidadCanciones = " + filtro;
                            break;

                    }
                }
                else if (campo == "Título")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Titulo like '" + filtro + "%' " ;
                            break;
                        case "Contiene":
                            consulta += "Titulo like '%" + filtro + "%' ";
                            break;
                        default:
                            consulta += "Titulo like '%" + filtro + "' ";
                            break;

                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "E.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Contiene":
                            consulta += "E.Descripcion like '%" + filtro + "%' ";
                            break;
                        default:
                            consulta += "E.Descripcion like '%" + filtro + "' ";
                            break;

                    }
                }


                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];

                    if (datos.Lector["FechaLanzamiento"] != DBNull.Value)
                    {
                        aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    }

                    
                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                    {
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];
                    }

                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.Edicion = new TipoEdicion();
                    aux.Estilo = new Estilo();
                    aux.Edicion.Descripcion = (string)datos.Lector["Edicion"];
                    aux.Edicion.Id = (int)datos.Lector["Id"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.Estilo.Id = (int)datos.Lector["Id"];
                    lista.Add(aux);
                }
                

                return lista;
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }
    }
}
