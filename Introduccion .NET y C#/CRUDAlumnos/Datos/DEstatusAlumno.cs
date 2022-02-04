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
    public class DEstatusAlumno
    {
        string conexion = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        private SqlCommand comando;
        string query;

        public List<EstatusAlum> estatus = new List<EstatusAlum>();

        public List<EstatusAlum> Consultar()
        {
            List<EstatusAlum> listEstatus = new List<EstatusAlum>();
            query = $"consultarEstatusAlumnos";
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEstatus", -1);
                conn.Open();

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listEstatus.Add(
                     new EstatusAlum()
                     {
                         IdEstatus = Convert.ToInt32(reader["id_estatus"]),
                         Clave = reader["clave"].ToString(),
                         nombreEstatus = reader["nombre"].ToString()
                     }
                     );
                }
                conn.Close();
            }
            return listEstatus;
        }
        public EstatusAlum Consultar(int id)
        {
            EstatusAlum EstatusxUno = new EstatusAlum();
            query = $"consultarEstatusAlumnos";
            using (SqlConnection con = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEstatus", id);
                con.Open();

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    EstatusxUno = new EstatusAlum
                    {
                        IdEstatus = Convert.ToInt32(reader["id_estatus"].ToString()),
                        Clave = reader["clave"].ToString(),
                        nombreEstatus = reader["nombre"].ToString(),
                    };
                }
                con.Close();
            }
            return EstatusxUno;
        }
    }
}
