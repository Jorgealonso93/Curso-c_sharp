using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imms
{
    internal class CalculadoraImms
    {
        enum colaborador : int
        {
            Trabajador = 1,
            Patron = 2,
        }
        public struct Aportaciones
        {
            public decimal EnfermedadMaternidad, InvalidezVida, Retiro, Cesantia, Infonavit;
            public Aportaciones(decimal maternidad, decimal invalVida, decimal Ret, decimal cesant, decimal info)
            {
                this.EnfermedadMaternidad = maternidad;
                this.InvalidezVida = invalVida;
                this.Retiro = Ret;
                this.Cesantia = cesant;
                this.Infonavit = info;
            }
        }

        static void Calcular (decimal salarioBase, decimal UMA, colaborador indicador)
        {
            int indi = (int)indicador;
            Aportaciones aportacion = new Aportaciones();
            decimal calculoMaternidad = (salarioBase - (3 * UMA));
            decimal SBC = salarioBase;

            if (indi == 1)
            {
                aportacion.EnfermedadMaternidad = (SBC - calculoMaternidad) * 0.4m;
                aportacion.InvalidezVida = salarioBase * 0.625m;
                aportacion.Retiro = salarioBase * 0;
                aportacion.Cesantia =   salarioBase * 1.125m;
                aportacion.Infonavit = salarioBase * 0;

                Console.WriteLine ("Prestacion\tTrabajador\tImporte Base\n" +
                    "Enfermedades y Maternidad\t{0}\t{1}\n" +
                    "Invalidez y Vida\t{2}\t{3}\n" +
                    "Retiro\t{4}\t{3}\n" +
                    "Cesantia\t{5}\t{3}\n" +
                    "Credito Infonavit\t{6}\t{3}", aportacion.EnfermedadMaternidad, calculoMaternidad, aportacion.InvalidezVida, SBC, aportacion.Retiro, aportacion.Cesantia, aportacion.Infonavit);
                Console.ReadLine ();
            }
            else
            {
                //decimal calculoMaternidad = (salarioBase - (3 * UMA));
                //decimal SBC = salarioBase;
                aportacion.EnfermedadMaternidad = (SBC - calculoMaternidad) * 1.1m;
                aportacion.InvalidezVida = salarioBase * 1.75m;
                aportacion.Retiro = salarioBase * 2;
                aportacion.Cesantia = salarioBase * 3.150m;
                aportacion.Infonavit = salarioBase * 5;

                Console.WriteLine("Prestacion\tPatron\tImporte Base\n" +
                    "Enfermedades y Maternidad\t{0}\t{1}\n" +
                    "Invalidez y Vida\t{2}\t{3}\n" +
                    "Retiro\t{4}\t{3}\n" +
                    "Cesantia\t{5}\t{3}\n" +
                    "Credito Infonavit\t{6}\t{3}", aportacion.EnfermedadMaternidad, calculoMaternidad, aportacion.InvalidezVida, SBC, aportacion.Retiro, aportacion.Cesantia, aportacion.Infonavit);
                Console.ReadLine();
            }
        }
        public void Presentacion()
        {
            Console.WriteLine("******CALCULADORA IMSS *********");
            Console.WriteLine("Ingrese el sueldo Base de Cotizacion");
            decimal sueldo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Unidad de Medida de Actualizacion");
            decimal unidad = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Elija una Opcion\n1. Trabajador\n2. Patron");
            int indi = int.Parse(Console.ReadLine());

            Calcular(sueldo, unidad, (colaborador)indi);
        }
    }
}

