using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppPokemon2
{
    internal class PokemonDatos
    {
        public List<Pokemon> Listar()//EL METODO DEVUELVE UNA LISTA DE POKEMONS CUYOS DATOS SE TRAEN DESDE LA BD
        {
            List<Pokemon> lista = new List<Pokemon>();

            //OBJETOS NECESARIOS PARA LA CONEXION
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;



            try 
            {   //COMO ME VOY A CONECTAR A LA BD
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                //QUE ACCION VOY A REALIZAR SOBRE LA BD
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero,Nombre,Descripcion,UrlImagen from POKEMONS";
                //INDICAMOS QUE VAMOS A EJECUTAR EL COMANDO EN NUESTRA CONEXION
                comando.Connection = conexion;
                
                //ABRIR CONEXION
                conexion.Open();
                //REALIZAMOS LA LECTURA
                lector = comando.ExecuteReader(); //ESTE METODO DEVUELVE UN SQLDATAREADER QUE ALMACENAMOS EN LECTOR
                //...AQUI YA TENEMOS NUESTROS DATOS EN LA VARIABLE lector
                //GENERANDO UNA ESPECIE DE TABLA VIRTUAL CON UN PUNTERO SEÑALADOR

                while (lector.Read())//SI EXISTE UN REGISTRO, DEVUELVE TRUE Y POSICIONA EL PUNTERO SOBRE EL REGISTRO LEIDO 
                {
                    //ASIGNAMOS LOS DATOS LEIDOS A CADA PROPIEDAD O ATRIBUTO DEL OBJETO A MOSTRAR
                    //...lector NOS PERMITE TRAER CADA DATO A ASIGNAR
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);//0 REPRESENTA EL INDICE DE LA COLUMNA Nombre QUE INDIQUE EN LA CONSULTA SQL

                    aux.Nombre = (string)lector["Nombre"];//INDICAMOS A LECTOR EL NOMBRE O ALIAS DE LA COLUMNA DE LA CONSULTA
                    //DEBEMOS INDICAR EXPLICITAMENTE EL TIPO DE DATO YA QUE lector TRAE LOS DATO EN TIPO OBJECT
                    aux.Descripcion = (string)lector["Descripcion"];

                    aux.UrlImagen = (string)lector["UrlImagen"];

                    //AGREGAMOS UN OBJETO Pokemon A LA LISTA QUE VAMOS A MOSTRAR
                    lista.Add(aux);
                }
            //CERRAMOS CONEXION
            conexion.Close();

            //DEVOLVEMOS LA LISTA    
            return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
          


        }
    }
}
