using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class AccesoADatos
    { //Declaramos como atributos los objetos necesarios para la conexion
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
            
        //Necesitamos leer el objeto lector (privado), entonces creamos una property
            //para acceder desde el exterior
        public SqlDataReader Lector
        {
           get { return lector; }
        }

      //Establecemos los datos de conexion en el constructor de la clase AccesoADatos, asi cuando
      //se crea un objeto, este nace con la conexion
      public AccesoADatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true");//Nace con conexion
            comando = new SqlCommand(); //El objeto nace con un objeto comando
        }

        //Creamos otra funcion para configurar el comando y la consulta SQL
        public void setearConsulta(string consulta)//Recibe como parametro la consulta SQL
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        //Creamos una funcion que abre la conexion y ejecuta la consulta (lectura)
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //Funcion para ejecutar el Insert (o alta) en la DB
        public void ejecutarAlta()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //Por ultimo, creamos funcion para cerrar la conexion
        public void cerrarConexion()
        {   
            if (lector != null) //Es importante evaluar si hay un lector previo utilizandose,  para cerrarlo
                lector.Close();
            conexion.Close();
        }
    }
}
