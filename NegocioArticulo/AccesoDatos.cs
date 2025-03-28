using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace NegocioArticulo
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
            conexion = new SqlConnection("server=(local)\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion; // Asegurar que el comando esté vinculado a la conexión

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); // ejecutar acciones que no devuelven datos (INSERT, UPDATE, DELETE)
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close(); // Cerrar la conexión al final
            }
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion; // Vincular la conexión antes de ejecutar el lector

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader(); // Ejecutar la lectura
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void setearParametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();

            conexion.Close();
        }
    }
}