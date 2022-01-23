using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class ISR
    {
        static decimal[,] CargarTabla(string nombreArchivo, string rutaArchivo)
        {
            string ubicacionArchivo = rutaArchivo + "\\" + nombreArchivo + ".csv";
            StreamReader file = new StreamReader(ubicacionArchivo);
            
            char delimitador = ',';
           int i=0;
            string linea;
            string[] fila;
            decimal [,] tabla = new decimal[21, 5];

            while ((linea = file.ReadLine()) != null)
            {
                fila=linea.Split(delimitador);
                    
                        for (int j = 0; j < 5; j++)
                        {
                            tabla[i, j] = Convert.ToDecimal(fila[j]);
                        //Console.WriteLine("tabla posicion {0},{1}=>{2}", i, j, tabla[i, j]);
                        }
                i++;
                    

            }
            return tabla;
        }
        static void Calcular(decimal sueldoMensual, string nom, string ruta)
        {
            decimal sueldoQuincenal = sueldoMensual / 2;
            decimal [,]TablaISR = CargarTabla(nom,ruta);

            decimal cuotaFija = 0, excedLimInf=0, subsidio=0, LimInf=0;
            for (int i = 0; i <= 20; i++)
            {
                if (sueldoQuincenal >= TablaISR[i, 0] && sueldoQuincenal <= TablaISR[i, 1])
                {
                    LimInf = TablaISR[i, 0];
                    cuotaFija = TablaISR[i, 2];
                    excedLimInf = TablaISR[i, 3] / 100;
                    subsidio = TablaISR[i, 4];
                    break;
                }
            }
            decimal Resultado = (sueldoQuincenal - LimInf) * excedLimInf;
            decimal impuesto = (Resultado + cuotaFija) - subsidio;
            Console.WriteLine("El impuesto a pagar es de =>"+ impuesto);
            Console.ReadLine();
        }
        public void Presentacion()
        {
            Console.WriteLine("Ingresa la ruta del archivo:");
            string ruta = Console.ReadLine();
            Console.WriteLine("Ingresa el nombre del archivo:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo Mensual");
            decimal sueldoM = decimal.Parse(Console.ReadLine());

            Calcular(sueldoM, nombre, ruta);
            
        }
    }
}
