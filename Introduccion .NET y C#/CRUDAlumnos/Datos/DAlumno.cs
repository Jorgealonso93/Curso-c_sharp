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
    public class DAlumno
    {
        string conexion = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        private SqlCommand comando;
        //private List<Estatus> listEstatus = new List<Estatus>();
        string query;
        public List<Alumno> Consultar()
        {
            List<Alumno> listalumnos = new List<Alumno>();
            query = $"consultarEAlumnos";
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", -1);
                conn.Open();

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listalumnos.Add(
                     new Alumno()
                     {
                         ID = Convert.ToInt32(reader["id"].ToString()),
                         Nombre = reader["nombre"].ToString(),
                         primerApellido = reader["primerApellido"].ToString(),
                         segunndoApellido = reader["segundoApelllido"].ToString(),
                         Correo = reader["correo"].ToString(),
                         Telefono = reader["telefono"].ToString(),
                         fechaNacimiento = Convert.ToDateTime(reader["fechaNaci"].ToString()),
                         Curp = reader["curp"].ToString(),
                         sueldo = Convert.ToDecimal( reader["sueldo"].ToString()),
                         idEstado = Convert.ToInt32(reader["idEstadoOrigen"].ToString()),
                         idEstatus = Convert.ToInt32(reader["idEstatus"].ToString())

                     }
                     );
                }
                conn.Close();
            }
            return listalumnos;
        }
        public Alumno Consultar(int id)
        {
            Alumno alumxUno = new Alumno();
            query = $"consultarEAlumnos";
            using (SqlConnection con = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", id);
                con.Open();

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    alumxUno = new Alumno
                    {
                        ID = Convert.ToInt32(reader["id"].ToString()),
                        Nombre = reader["nombre"].ToString(),
                        primerApellido = reader["primerApellido"].ToString(),
                        segunndoApellido = reader["segundoApelllido"].ToString(),
                        Correo = reader["correo"].ToString(),
                        Telefono = reader["telefono"].ToString(),
                        fechaNacimiento = Convert.ToDateTime(reader["fechaNaci"].ToString()),
                        Curp = reader["curp"].ToString(),
                        sueldo = Convert.ToDecimal(reader["sueldo"].ToString()),
                        idEstado = Convert.ToInt32(reader["idEstadoOrigen"].ToString()),
                        idEstatus = Convert.ToInt32(reader["idEstatus"].ToString())
                    };
                }
                con.Close();
            }
            return alumxUno;
        }
        public void Agregar(Alumno alumno)
        {
            //int id;
            query = $"agregarAlumnos";
            using (SqlConnection con = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NOMBRE", alumno.Nombre);
                comando.Parameters.AddWithValue("@primerApellido", alumno.primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", alumno.segunndoApellido);
                comando.Parameters.AddWithValue("@correo", alumno.Correo);
                comando.Parameters.AddWithValue("@telefono", alumno.Telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", alumno.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", alumno.Curp);
                comando.Parameters.AddWithValue("@sueldo", alumno.sueldo);
                comando.Parameters.AddWithValue("@id_estado", alumno.idEstado);
                comando.Parameters.AddWithValue("@id_estatus", alumno.idEstatus);
                con.Open();
                comando.ExecuteNonQuery();
                //var idEstado = comando.ExecuteScalar();
                //id = Convert.ToInt32(idEstado);
                con.Close();

            }
            //return id;
        }
        public void actualizar(Alumno alumno)
        {
            string query = $"actualizarAlumnos";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", alumno.ID);
                comando.Parameters.AddWithValue("@NOMBRE", alumno.Nombre);
                comando.Parameters.AddWithValue("@primerApellido", alumno.primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", alumno.segunndoApellido);
                comando.Parameters.AddWithValue("@correo", alumno.Correo);
                comando.Parameters.AddWithValue("@telefono", alumno.Telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", alumno.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", alumno.Curp);
                comando.Parameters.AddWithValue("@sueldo", alumno.sueldo);
                comando.Parameters.AddWithValue("@id_estado", alumno.idEstado);
                comando.Parameters.AddWithValue("@id_estatus", alumno.idEstatus);
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void Eliminar(int id)
        {
            string query = $"eliminarAlumnos";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", id);
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
        }
        public List<TablaISR> ConsultarTablaISR()
        {
            List<TablaISR> listISR = new List<TablaISR>();
            query = $"select * from TablaISR";
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, conn);
                comando.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listISR.Add(
                     new TablaISR()
                     {
                         limInf = Convert.ToDecimal(reader["LimInf"]),
                         LimSup = Convert.ToDecimal(reader["LimSup"].ToString()),
                         cuotaFija = Convert.ToDecimal(reader["CuotaFija"].ToString()),
                         excedente = Convert.ToDecimal(reader["ExedLimInf"].ToString()),
                         subsidio = Convert.ToDecimal(reader["Subsidio"].ToString())
                     }
                     );
                }
                conn.Close();
            }
            return listISR;
        }
    }
}
