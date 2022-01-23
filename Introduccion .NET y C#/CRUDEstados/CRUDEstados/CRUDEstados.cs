using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    internal class CRUDEstados
    {
        private static Dictionary<int, string> _crudEstados = new Dictionary<int,string>();

        public void Insertar(int id, string Valor)
        {
                try
                {
                    _crudEstados.Add(id, Valor);
                    Console.WriteLine("Registro Exitoso: " + id + "," + Valor);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }
        public void MostrarTodos()
        {
            try
            {
                foreach (KeyValuePair<int, string> kvp in _crudEstados)
                {
                    Console.Write("ID= {0} Valor= {1}", kvp.Key, kvp.Value);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void MostrarSoloUno(int id)
        {
            string definicion;
            try
            {
                definicion= _crudEstados[id];
                Console.WriteLine("Estado=> "+definicion);
            }
            catch(KeyNotFoundException)
            {
                Console.WriteLine("Al parecer ese Estado no Existe!!");
            }
        }
        public void Actualizar(int id, string valor)
        {
            try
            {
                _crudEstados[id] = valor;
                Console.WriteLine(id + "," + valor + " Se Actualizó de manera Exitosa");

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void Eliminar(int id)
        {
            try
            {
                _crudEstados.Remove(id);
                Console.WriteLine(_crudEstados[id]+"Eliminado Correctamente!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
