using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOEstatusAlumnos
{
    public class ADOEstatus : ICRUD
    {
        //public ADOEstatus()
        //{
        //    string conexion = @"Data Source=DESKTOP-PP98M3C\SQLEXPRESS;Initial Catalog=instituto_tich;Integrated Security=True";
        //    SqlConnection con = new SqlConnection(conexion);
        //    con.Open();
        //    con.Close();
        //}
        string conexion = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        private SqlCommand comando;
        private List<Estatus> listEstatus = new List<Estatus>();
        string query;
        public List<Estatus> Consultar()
        {
            //List<Estatus> listEstatus = new List<Estatus>();
            query = $"select * from estatus_alumnos";
            using(SqlConnection conn = new SqlConnection(conexion))
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
            query = $"select * from estatus_Alumno where idEstatus ={id}";
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

            using(SqlConnection conn = new SqlConnection(conexion))
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
            using(SqlConnection con = new SqlConnection(conexion))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType= CommandType.Text;
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public void Presentacion()
        {
            string opcion = "";
            Console.WriteLine("*****::::: ESTATUS :::::*****");
            do
            {
                Console.WriteLine("1. Consultar Todos\n2. Consultar solo uno\n3. Agregar\n4. Actualizar\n5. Eliminar\n6. Terminar");
                opcion = Console.ReadLine();

                if (opcion == "1")
                {
                  
                    foreach (var i in Consultar())
                    {
                        Console.WriteLine($"ID: {i.id} Clave: {i.clave} Nombre: {i.nombre}");
                    }

                }else if (opcion == "2")
                {
                    try
                    {
                        Console.WriteLine("Ingrese el Id del Estatus a Buscar:");
                        int id = int.Parse(Console.ReadLine());
                        var item = Consultar(id);
                        Console.WriteLine($"ID= {item.id} Clave= {item.clave} Nombre= {item.nombre}");
                    }catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }else if(opcion == "3")
                {
                    try
                    {
                        Console.WriteLine("Ingresa la Clave del Estatus");
                        string clave = Console.ReadLine();
                        Console.WriteLine("Ingresa la descripcion del Estatus:");
                        string nombreE = Console.ReadLine();
                        Estatus estatus = new Estatus { clave = clave, nombre = nombreE };
                        var it = Agregar(estatus);
        
                        Console.WriteLine($"Registro Agregado con exito con el ID= {it}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }else if (opcion == "4")
                {
                    try
                    {
                        Console.WriteLine("Ingrese el id del Estatus a actualizar");
                        int idAct = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa la nueva descripcion del Estatus:");
                        string nnombreE = Console.ReadLine();
                        Estatus nestatus = new Estatus { id = idAct, nombre = nnombreE };
                        Actualizar(nestatus);
                        Console.WriteLine("Registro Actualizado con Exito.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }else if (opcion == "5")
                {
                    try
                    {
                        Console.WriteLine("Ingrese el id del estatus a eliminar:");
                        int idElim = int.Parse(Console.ReadLine());
                        Eliminar(idElim);
                        Console.WriteLine("Registro Eliminado con exito...");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }

            } while (opcion!="6");
        }
    }
}
