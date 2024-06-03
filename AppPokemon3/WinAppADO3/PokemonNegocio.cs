using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinAppADO3
{
    internal class PokemonNegocio //Clase de acceso a datos
    {
        public List<Pokemon> listar() {//Metodo que devuelve una lista de objetos de tipo Pokemon con los datos de la BD
        
            List<Pokemon> lista = new List<Pokemon> ();
            SqlConnection conexion = new SqlConnection ();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader lector;



           

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";//Indicamos a
      //          donde nos vamos a conectar
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select Numero, Nombre, Descripcion, UrlImagen from POKEMONS"; //Consulta SQL a ejecutar
                cmd.Connection = conexion;//Indicamos que la consulta se ejecute en la conexion que establecimos

                conexion.Open ();//Abrimos conexion
                lector = cmd.ExecuteReader ();//EJECUTAMOS la lectura que devuelve un sqlDataReader y lo guardamos en lector
                //lector almacena la tabla completa, sin selecciones

                
                //Obtenemos datos de la tabla y los almacenamos en la lista de Pokemons
                while (lector.Read ())//Metodo .Read lee la tabla en busca de registros, si encuentra uno, devuelve true
                {
                    Pokemon aux = new Pokemon ();//Creamos un pokemon auxiliar para almacenar cada dato obtenido
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];//Indicamos el tipo de dato obtenido ya que lector devuelve un Object
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"];

                    lista.Add (aux); //Agrego ese pokemon con sus datos a la lista que devuelve el metodo
                }

                //RESUMEN: configuramos y realizamos la conexion, lee una tabla de DB, transforma los datos a objetos y los
                //muestra en una lista
                conexion.Close ();
                return lista;
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }
    }

}
