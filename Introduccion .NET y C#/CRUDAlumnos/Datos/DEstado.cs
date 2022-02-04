using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEstado
    {
        string conexion = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        private SqlCommand comando;
        string query;

        public List<Estado> estado = new List<Estado>();

        public List<Estado> Consultar()
        {
            List<Estado> listEstado = new List<Estado>();
            query = $"consultarEstados";
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEstado", -1);
                conn.Open();

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listEstado.Add(
                     new Estado()
                     {
                         IdEstado = Convert.ToInt32(reader["id_estado"]),
                         NombreEstado = reader["nombre_estado"].ToString(),
                     }
                     );
                }
                conn.Close();
            }
            return listEstado;
        }
        public Estado Consultar(int id)
        {
            Estado EstadoxUno = new Estado();
            query = $"consultarEstados";
            using (SqlConnection con = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEstado", id);
                con.Open();

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    EstadoxUno = new Estado
                    {
                        IdEstado = Convert.ToInt32(reader["id_estado"].ToString()),
                        NombreEstado = reader["nombre_estado"].ToString(),
                    };
                }
                con.Close();
            }
            return EstadoxUno;
        }
    }
}
