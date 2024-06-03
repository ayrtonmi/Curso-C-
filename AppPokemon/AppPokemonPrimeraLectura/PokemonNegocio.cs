using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //necesitamos declarar el uso de la libreria sql

namespace AppPokemonPrimeraLectura
{
    internal class PokemonNegocio //cada clase o entidad debe tener su clase de acceso a sus datos
    {
        //funcion para leer registros de la bbdd Pokemons
        public List<Pokemon> Listar() { 
        
            List<Pokemon> lista = new List<Pokemon>();
            // PRIMERO: instanciamos OBJETOS NECESARIOS
            
            SqlConnection conexion = new SqlConnection();//objeto conexion se conecta a la bbdd
            
            SqlCommand comando = new SqlCommand();//objeto comando realiza acciones
            
            SqlDataReader lector;//lector aloja los datos
            //no creamos instancia ya que el objeto comando devuelve un objeto DATAREADER,
            //que almacenaremos en lector



            try
            {
                //SEGUNDO: configuramos la CONEXION
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                                            //. para indicar nuestra pc como servidor, (o la ip si es servidor remoto)
                                            //junto al motor de base de datos
                                            //Luego indicamos la bbdd a la cual quiero conectarme,
                                            //y luego de que forma nos conectaremos: credenciales de windows, o credenciales del motor (sql server autentication) user+pass
                 
                //TERCERO: Configurar COMANDO: el comando es quien realiza la accion
                
                comando.CommandType = System.Data.CommandType.Text;//indicamos el tipo de comando (texto, procedimiento almacenado, o enlace directo)
               
                comando.CommandText = "Select Numero, Nombre, Descripcion from POKEMONS"; // aqui colocamos la consulta sql a ejecutar
                
                comando.Connection = conexion;//indicamos al comando que ejecute la accion SOBRE la conexion que establecimos

                //CUARTO: Realizamos la conexion
                conexion.Open();

                lector = comando.ExecuteReader();// realizamos la lectura a traves del comando
                                                //obtenemos el DataReader y lo almacenamos

                //QUINTO: Obtenemos los datos de la BBDD para transformarlos a objetos y mostrarlos

                while (lector.Read())//mientras exista una lectura, es decir, mientras se lea un registro, devolvera TRUE (entra al ciclo)
                                    // ademas, colocara un puntero en la primer fila, o sea apuntando al primer registro encontrado
                {
                    //Transformamos los datos leidos de la tabla en objetos para almacenarlos en la lista de Pokemons
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);//Obtenemos el dato segun el indice de la columna que necesitemos, o:
                    aux.Nombre = (string)lector["Nombre"];//Indicamos el nombre o alias de la columna que queremos asignar
                    aux.Descripcion = (string)lector["Descripcion"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw;
            }

        }


    }
}
