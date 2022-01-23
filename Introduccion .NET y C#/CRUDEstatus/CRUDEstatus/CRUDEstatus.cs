using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    internal class CRUDEstatus
    {
        private static List<Estatus> _lstcrudEstatus= new List<Estatus>();
        Estatus estatus = new Estatus();
        private Estatus [] arr = new Estatus[0];
        public void Insertar()
        {
            try
            {
                string afir;
                do
                {
                    Console.WriteLine("Ingrese el id del Estatus:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el Estatus:");
                    string desc = Console.ReadLine();

                    _lstcrudEstatus.Add(new Estatus { Id = id, Status = desc });

                    Console.WriteLine("Desea agregar otro Estatus?: y/n...");
                    afir = Console.ReadLine();
                } while (afir != "n");
                //estatus.Id = id;
                //estatus.Status = Valor;
                //_lstcrudEstatus.Add(arr[1]);
                Console.WriteLine("Registro Exitoso: ");
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
                foreach (var oEstatus in _lstcrudEstatus)
                {
                    Console.Write($"{oEstatus.Id} {oEstatus.Status} ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void MostrarSoloUno(int idestatus)
        {
            try
            {
                Estatus st2=_lstcrudEstatus.Find(status => status.Id == idestatus);
                Console.WriteLine($"id=>{st2.Id}, Estatus=>{st2.Status}");
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Al parecer el Estatus no Existe!!");
            }
        }
        public void Actualizar(int idEstatus, string valorNuevo)
        {
            try
            {
                Estatus st1= _lstcrudEstatus.Find(status => status.Id == idEstatus);
                st1.Status = valorNuevo;

                Console.WriteLine(" Se Actualizó de manera Exitosa");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void Eliminar(int idEstatus)
        {
            try
            {
                _lstcrudEstatus.RemoveAll(x => x.Id== idEstatus);
                Console.WriteLine("Eliminado Correctamente!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
