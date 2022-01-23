using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                CRUDEstatus estatus = new CRUDEstatus();
                Console.WriteLine("*********:::::::::: ESTATUS:::::::::::***********");
                Console.WriteLine("Elige una opcion:\n1. Consultar todos\n2. Consultar uno\n3. Agregar\n4. Actualizar\n5. Eliminar\n6. Terminar");
                opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.WriteLine("Usted seleccionó la opción 1");
                    estatus.MostrarTodos();
                    Console.ReadLine();
                }
                else if (opcion == "2")
                {
                    Console.WriteLine("Usted seleccionó la opción 2");
                    Console.WriteLine("Ingrese el estatus a buscar:");
                    int idCon = int.Parse(Console.ReadLine());
                    estatus.MostrarSoloUno(idCon);
                    Console.ReadLine();
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("Usted seleccionó la opción 3");
                    
                    estatus.Insertar();
                    Console.ReadLine();
                }
                else if (opcion == "4")
                {
                    Console.WriteLine("Usted seleccionó la opción 4");
                    Console.WriteLine("Ingrese el id del Estatus a actualizar:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese Nuevo valor:");
                    string valN = Console.ReadLine();
                    estatus.Actualizar(id, valN);
                    Console.ReadLine();
                }
                else if (opcion == "5")
                {
                    Console.WriteLine("Usted seleccionó la opción 5");
                    Console.WriteLine("Ingrese el id del Estatus a eliminar:");
                    int idElim = int.Parse(Console.ReadLine());
                    estatus.Eliminar(idElim);
                    Console.ReadLine();
                }

            } while (opcion != "6");
        }
    }
}
