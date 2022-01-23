using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Archivotxt
    {
        static void MostrarTxt(string rutaArchivo, string nombreArchivo)
        {
            string rutaCompleta = rutaArchivo + "\\" + nombreArchivo+".txt";
           // rutaCompleta = rutaCompleta.Replace(@"\", "\\");
            System.IO.StreamReader archivoTxt = new System.IO.StreamReader(rutaCompleta);
            string linea;
            while((linea = archivoTxt.ReadLine()) != null)
            {
                Console.Write(linea);
            }
            Console.ReadLine();
        }
        static void MostrarCSV(string ruta, string nomArchivo)
        {
            string ubicacionArchivo = ruta + "\\" + nomArchivo + ".csv";
            System.IO.StreamReader file = new System.IO.StreamReader(ubicacionArchivo);
            char delimitador = ',';
            string linea;
            string[] fila;

            file.ReadLine();

            while((linea = file.ReadLine()) != null)
            {
                fila = linea.Split(delimitador);
                foreach(string fil in fila)
                {
                    Console.WriteLine(fil);
                }
            }
    
        }
        public void EscribirTxt(string nomArchivo, string ruta, string codigo) 
        {
            string ubicacionArchivo = ruta + "\\" + nomArchivo + ".txt";
            string nombre, pApellido, sApellido, edad, estado, datosCompletos, afir;
      
            if(codigo == "1")
            {
                if (!File.Exists(ubicacionArchivo))
                {
                    using (StreamWriter sw = new StreamWriter(ubicacionArchivo, true, Encoding.UTF7))
                    {
                        do
                        {
                            Console.WriteLine("Ingresa el noombre del Alumno:");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingresa el primer Apellido:");
                            pApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa el segundo Apellido:");
                            sApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa la edad del alumno:");
                            edad = Console.ReadLine();
                            Console.WriteLine("Ingresa el estado:");
                            estado = Console.ReadLine();
                            datosCompletos = $"{nombre},{pApellido},{sApellido},{edad},{estado}";

                            sw.WriteLine(datosCompletos);

                            Console.WriteLine("Desea agregar otro Estado?: y/n...");
                            afir = Console.ReadLine();
                        } while (afir != "n");
                    }
                }
            }else if (codigo == "2")
            {
                if (!File.Exists(ubicacionArchivo))
                {
                    using (StreamWriter sw = new StreamWriter(ubicacionArchivo, true, Encoding.UTF8))
                    {
                        do
                        {
                            Console.WriteLine("Ingresa el noombre del Alumno:");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingresa el primer Apellido:");
                            pApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa el segundo Apellido:");
                            sApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa la edad del alumno:");
                            edad = Console.ReadLine();
                            Console.WriteLine("Ingresa el estado:");
                            estado = Console.ReadLine();
                            datosCompletos = $"{nombre},{pApellido},{sApellido},{edad},{estado}";

                            sw.WriteLine(datosCompletos);

                            Console.WriteLine("Desea agregar otro Estado?: y/n...");
                            afir = Console.ReadLine();
                        } while (afir != "n");
                    }
                }
            }else if (codigo == "3")
            {
                if (!File.Exists(ubicacionArchivo))
                {
                    using (StreamWriter sw = new StreamWriter(ubicacionArchivo, true, Encoding.Unicode))
                    {
                        do
                        {
                            Console.WriteLine("Ingresa el noombre del Alumno:");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingresa el primer Apellido:");
                            pApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa el segundo Apellido:");
                            sApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa la edad del alumno:");
                            edad = Console.ReadLine();
                            Console.WriteLine("Ingresa el estado:");
                            estado = Console.ReadLine();
                            datosCompletos = $"{nombre},{pApellido},{sApellido},{edad},{estado}";

                            sw.WriteLine(datosCompletos);

                            Console.WriteLine("Desea agregar otro Estado?: y/n...");
                            afir = Console.ReadLine();
                        } while (afir != "n");
                    }
                }
            }else if(codigo == "4")
            {
                if (!File.Exists(ubicacionArchivo))
                {
                    using (StreamWriter sw = new StreamWriter(ubicacionArchivo, true, Encoding.UTF32))
                    {
                        do
                        {
                            Console.WriteLine("Ingresa el noombre del Alumno:");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingresa el primer Apellido:");
                            pApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa el segundo Apellido:");
                            sApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa la edad del alumno:");
                            edad = Console.ReadLine();
                            Console.WriteLine("Ingresa el estado:");
                            estado = Console.ReadLine();
                            datosCompletos = $"{nombre},{pApellido},{sApellido},{edad},{estado}";

                            sw.WriteLine(datosCompletos);

                            Console.WriteLine("Desea agregar otro Estado?: y/n...");
                            afir = Console.ReadLine();
                        } while (afir != "n");
                    }
                }
            }else if(codigo == "5")
            {
                if (!File.Exists(ubicacionArchivo))
                {
                    using (StreamWriter sw = new StreamWriter(ubicacionArchivo, true, Encoding.ASCII))
                    {
                        do
                        {
                            Console.WriteLine("Ingresa el noombre del Alumno:");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingresa el primer Apellido:");
                            pApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa el segundo Apellido:");
                            sApellido = Console.ReadLine();
                            Console.WriteLine("Ingresa la edad del alumno:");
                            edad = Console.ReadLine();
                            Console.WriteLine("Ingresa el estado:");
                            estado = Console.ReadLine();
                            datosCompletos = $"{nombre},{pApellido},{sApellido},{edad},{estado}";

                            sw.WriteLine(datosCompletos);

                            Console.WriteLine("Desea agregar otro Estado?: y/n...");
                            afir = Console.ReadLine();
                        } while (afir != "n");
                    }
                }
            }
        }
        public void Presentacion()
        {
            Console.WriteLine("\n****** Mostrar Archivo (txt CSV) *****\n");
            Console.WriteLine("Elige una opcion:\n1. Mostrar Archivo TXT\n2. Mostrar Archivo CSV");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.WriteLine("Proporciona el nombre del Archivo txt: ");
                string nomAr = Console.ReadLine();
                Console.WriteLine("Proporciona la ruta del Archivo txt: ");
                string ruta = Console.ReadLine();

                MostrarTxt(ruta, nomAr);
            }else if (opcion == "2")
            {
                Console.WriteLine("Proporciona el nombre del Archivo CSV: ");
                string nomAr = Console.ReadLine();
                Console.WriteLine("Proporciona la ruta del Archivo CSV: ");
                string ruta = Console.ReadLine();

                MostrarCSV(ruta, nomAr);
            }
        }
    }
}
