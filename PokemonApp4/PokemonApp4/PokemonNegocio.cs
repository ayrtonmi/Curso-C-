using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PokemonApp4
{
    internal class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            //Instanciamos objetos de la libreria SQLClient necesarios para conectar y traer datos desde la DB
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {//1º CONFIGURAR A DONDE ME VOY A CONECTAR 
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
            
            //2º CONFIGURAR COMANDO PARA REALIZAR LA ACCION CON LA SENTENCIA SQL QUE QUIERO EJECUTAR
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion as Tipo, D.Descripcion as Debilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo and D.Id = P.IdDebilidad\r\n";
                //Indico ejecutar el comando en la conexion 
                    comando.Connection = conexion;

            //3ª ABRIR CONEXION
                conexion.Open();

            //4ª EJECUTAR LA LECTURA Y ASIGNARLA AL OBJETO LECTOR 
               lector = comando.ExecuteReader();//Se genera una suerte de tabla con un puntero
            

            //5ª TRAEMOS LOS DATOS DE LA TABLA Y LOS ASIGNAMOS A LOS ATRIBUTOS DE UN POKEMON Y CARGAMOS LA LISTA DE POKEMONS
                while (lector.Read())//Si el lector encuentra una lectura, posiciona el puntero en la primera fila y devuelve
                                     //true
                {
                    Pokemon aux = new Pokemon();//Asignamos datos 
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];
                    lista.Add(aux);//Agregamos el pokemon a la lista
                }
            //6ª CERRAR CONEXION
                conexion.Close();
            
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
