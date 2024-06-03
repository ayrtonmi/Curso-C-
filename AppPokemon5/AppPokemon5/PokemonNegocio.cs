using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Declaramos la libreria necesaria para la conexion

namespace AppPokemon5
{
    internal class PokemonNegocio//Clase para crear los metodos de acceso a datos para los objetos Pokemon
    {
        public List<Pokemon> listar() //Metodo para leer datos y traer una lista de Pokemons desde la DB
        {
            List<Pokemon> lista = new List<Pokemon>();//Lista para almacenar los Pokemons

            //Declaramos los objetos necesarios para la conexion
                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true"; //Indicamos a donde nos vamos a conectar y las credenciales de seguridad
                comando.CommandType = System.Data.CommandType.Text;//Indicamos tipo de comando
                comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion as Tipo, D.Descripcion as Debilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdTipo and D.Id=P.IdDebilidad";//Consulta SQL
                comando.Connection = conexion; //Indicamos en qué conexion ejecutar la sentencia sql

                conexion.Open();//Abrimos la conexion
                lector = comando.ExecuteReader();//Ejecutamos la lectura para guardarlo en el objeto lector
                
                
                while (lector.Read())//Si pudo leer, entra al while.
                    //Ademas posiciona el puntero en el primer registro de la tabla
                {
                    Pokemon aux = new Pokemon();//Objeto Pokemon auxiliar para almacenar los datos
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];
                    lista.Add(aux);//Agregamos cada Pokemon a la lista de Pokemons
                }

            conexion.Close();//Cerramos la conexion luego de leer
            return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }




        }
    }
}
