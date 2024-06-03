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
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true");
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();//Ejecuta el lector
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();//Ejecuta la sentencia INSERT, no es de lectura
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public void setearParametro(string nombre, object valor)//Seteamos parametros del comando para resolver la consulta sql (@)
        {
            comando.Parameters.AddWithValue(nombre, valor );//recibe un string (nombre del parametro) y un object (valor,
                                                            //cualquier tipo de dato)
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

    }
}
