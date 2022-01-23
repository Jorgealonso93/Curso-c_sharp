using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                CRUDEstados cRUDEstados = new CRUDEstados();
                Console.WriteLine("*********:::::::::: ESTADOS:::::::::::***********");
                Console.WriteLine("Elige una opcion:\n1. Consultar todos\n2. Consultar uno\n3. Agregar\n4. Actualizar\n5. Eliminar\n6. Terminar");
                opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.WriteLine("Usted seleccionó la opción 1");
                    cRUDEstados.MostrarTodos();
                    Console.ReadLine();
                }
                else if (opcion == "2")
                {
                    Console.WriteLine("Usted seleccionó la opción 2");
                    Console.WriteLine("Ingrese el ID del Estado:");
                    int idCon= int.Parse(Console.ReadLine());
                    cRUDEstados.MostrarSoloUno(idCon);
                    Console.ReadLine();
                }
                else if (opcion == "3")
                {
                    string afir;
                    Console.WriteLine("Usted seleccionó la opción 3");
                    do
                    {
                        Console.WriteLine("Ingresar el ID del Estado:");
                        int idIng = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa la descripcion del Estado:");
                        string desc = Console.ReadLine();
                        cRUDEstados.Insertar(idIng, desc);

                        Console.WriteLine("Desea agregar otro Estado?: y/n...");
                        afir = Console.ReadLine();
                    } while (afir != "n");
                    Console.ReadLine();
                }
                else if (opcion == "4")
                {
                    Console.WriteLine("Usted seleccionó la opción 4");
                    Console.WriteLine("Ingrese el ID del Estado a actualizar:");
                    int idAct = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese Nuevo valor:");
                    string val = Console.ReadLine();
                    cRUDEstados.Actualizar(idAct, val);
                    Console.ReadLine();
                }
                else if (opcion == "5")
                {
                    Console.WriteLine("Usted seleccionó la opción 5");
                    Console.WriteLine("Ingrese el ID del Estado a eliminar:");
                    int idElim = int.Parse(Console.ReadLine());
                    cRUDEstados.Eliminar(idElim);
                    Console.ReadLine();
                }
                
            } while (opcion != "6");
        }
    }
}
