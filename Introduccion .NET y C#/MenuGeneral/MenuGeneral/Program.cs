using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arreglos1 arreglos = new Arreglos1();
            Poliza poliza = new Poliza();
            Archivotxt archivotxt = new Archivotxt();
            ISR iSR = new ISR();
            string opcion;
            do
            {
                Console.WriteLine("****** Menu General *****");
                Console.WriteLine("Elige una opcion:\n1. Cadenas\n2. Enteros\n3. ConvierteATipoOracion\n4. Poliza\n5. Mostrar Archivo (txt CSV)\n6. escribir TXT\n7. Calculo ISR\nF. Termina");
                opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.WriteLine("Usted seleccionó la opción 1");
                    arreglos.Cadenas();
                
                }
                else if (opcion == "2")
                {
                    Console.WriteLine("Usted seleccionó la opción 2");
                    arreglos.Enteros();
                        
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("Usted seleccionó la opción 3");
                    Console.WriteLine(".......::::::::::::: INITCAP ::::::::::::::::::::::.......");
                    Console.WriteLine("Ingresa una cadena de caracteres:");
                    string cad = Console.ReadLine();
                    arreglos.ConvierteATipoOracion(cad);
                        
                }
                else if (opcion == "4")
                {
                    Console.WriteLine("Usted seleccionó la opción 4");
                    poliza.Presentacion();
                        
                }else if (opcion == "5")
                {
                    archivotxt.Presentacion();
                }else if(opcion == "6")
                {
                    Console.WriteLine("Proporciona el nombre del Archivo txt: ");
                    string nomAr = Console.ReadLine();
                    Console.WriteLine("Proporciona la ruta del Archivo txt: ");
                    string ruta = Console.ReadLine();
                    Console.WriteLine("Codigo a escribir el archivo:\n1. UTF7\n2. UTF8\n3. Unicode\n4. UTF32\n5. ASCII");
                    string opc = Console.ReadLine();
                    archivotxt.EscribirTxt(nomAr, ruta, opc);   
                }else if( opcion == "7")
                {
                    iSR.Presentacion();
                }
            } while (opcion != "F");
            

        }
    }
}
