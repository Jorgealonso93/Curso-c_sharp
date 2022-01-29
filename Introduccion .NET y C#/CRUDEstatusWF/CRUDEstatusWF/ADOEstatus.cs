using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUDEstatusWF
{
    public class ADOEstatus
    {
        string conexion = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        private SqlCommand comando;
        private List<Estatus> listEstatus = new List<Estatus>();
        string query;
        public List<Estatus> Consultar()
        {
            //List<Estatus> listEstatus = new List<Estatus>();
            query = $"select * from estatus_alumnos";
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, conn);
                comando.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listEstatus.Add(
                     new Estatus()
                     {
                         id = Convert.ToInt32(reader["id_estatus"]),
                         clave = reader["clave"].ToString(),
                         nombre = reader["nombre"].ToString()
                     }
                     );
                }
                conn.Close();
            }
            return listEstatus;
        }
        public Estatus Consultar(int id)
        {
            Estatus estatusPorUno = new Estatus();
            query = $"select * from estatus_alumnos where id_estatus ={id}";
            using (SqlConnection con = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    estatusPorUno = new Estatus { id = Convert.ToInt32(reader["id_estatus"]), clave = reader["clave"].ToString(), nombre = reader["nombre"].ToString() };
                }
                con.Close();
            }
            return estatusPorUno;
        }
        public int Agregar(Estatus estatus)
        {
            int id;
            query = $"insert into estatus_alumnos(clave,nombre) values(@clave, @nombre)\nselect SCOPE_IDENTITY();";
            using (SqlConnection con = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@clave", estatus.clave);
                comando.Parameters.AddWithValue("@nombre", estatus.nombre);
                con.Open();
                var idEstado = comando.ExecuteScalar();
                id = Convert.ToInt32(idEstado);
                con.Close();

            }
            return id;
        }
        public void Actualizar(Estatus estatus)
        {
            string query = $"update estatus_alumnos set nombre ='{estatus.nombre}' where id_estatus={estatus.id}";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, conn);
                comando.CommandType = CommandType.Text;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void Eliminar(int id)
        {
            query = $"delete estatus_alumnos where id_estatus={id}";
            using (SqlConnection con = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}