using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class AccesoDatos
    {
        //Declaramos como atributos los objetos necesarios para la conexion
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector//Propiedad para obtener el lector desde el exrterior
        {
            get { return lector; }
        }
        public AccesoDatos()//Al momento de crear un objeto de acceso a datos, este nace con conexion y un comando
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true");
            comando = new SqlCommand();

        }
        public void setearConsulta(string consulta)//Cramos metodo para setear la consulta sql que se recibe como parametro
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()//Funcion para ejecutar la lectura en esa conexion
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex )
            {

                throw ex;
            }
            
        }
        public void ejecutarAccion()//Funcion para ejecutar accion de no lectura (alta, por ej)
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw (ex);
            }
            finally {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            
        }
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void cerrarConexion()
        {
            if (lector !=null)
                lector.Close();//Si hay un lector usandose, se debe cerrar
            conexion.Close();
        }


    }
}
