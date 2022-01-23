using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Poliza
    {
         enum tipoPeriodo : int
        {
            años=1,
            meses=2,
            dias=3
        }
        enum Genero : int
        {
            Femenino=1,
            Masculino=2
        }
        static void Calcular(DateTime fechaIniVig, tipoPeriodo tPeriodo, int cPeriodo, decimal sumaAsegurada, DateTime fechaNac, Genero gen)
        {
            PolizaResultado polizaTermino, prima;
            decimal [,] factor = new decimal[,] { { 0m, 20m, 1m, 0.05m }, { 21m,30m,1m,0.1m }, {31m,40m,1m,0.4m }, { 41m,50m,1m,0.5m}, { 51m, 60m, 1m, 0.65m}, { 61m, 100m, 1m, 0.85m},
                                                  { 0m, 20m, 2m, 0.05m }, { 21m,30m,2m,0.1m }, {31m,40m,2m,0.4m }, { 41m,50m,2m,0.55m}, { 51m,60m,2m, 0.7m}, { 61m, 100m, 2m, 0.9m} };
            DateTime fechaAc = DateTime.Now;
            int edad= fechaAc.Year - fechaNac.Year;
            decimal fact = 0m;
            int totalDias = 0;
            int genro = (int)gen;
            DateTime fechaT = new DateTime();

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (edad >= factor[i,j]  && edad <=factor[i,1])
                    {
                        if (genro == factor[i, 2])
                        {
                            fact = factor[i, 3];
                            break;
                        }
                        break;
                    }
                    break;
                }
            }

            if (tPeriodo == tipoPeriodo.años)
            {
                fechaT = fechaIniVig.AddYears(cPeriodo);
            }else if (tPeriodo == tipoPeriodo.meses)
            {
                fechaT = fechaIniVig.AddMonths(cPeriodo);
            }else if(tPeriodo ==  tipoPeriodo.dias)
            {
                fechaT = fechaIniVig.AddDays(cPeriodo);
            }

            polizaTermino.fechaTermino = fechaT;
            TimeSpan timeSpan = polizaTermino.fechaTermino - fechaIniVig;
            totalDias = timeSpan.Days;
            prima.prima = (sumaAsegurada * fact * totalDias) / 360;
            Console.WriteLine("La Póliza vencerá el : "+ polizaTermino.fechaTermino.ToString("dd MMMM yyyy"));
            Console.WriteLine("La prima a pagar es de: "+ prima.prima + " pesos");
            Console.ReadLine();
            //TimeSpan tdias = pol.fechaTermino - fechaIniVig;
            //totalDias = tdias.Days;
            //pol.prima = (sumaAsegurada * fact * totalDias) / 360;
            //Console.WriteLine("La póliza vencer");
        }
        public void Presentacion()
        {
            string tiempo, gen;
            decimal suma;
            DateTime fechaVig, fechaN;
            Console.WriteLine(".....:::::   POLIZA  :::::.....\n");
            Console.WriteLine("Proporciona la fecha de inicio de Vigencia:");
            fechaVig =DateTime.Parse( Console.ReadLine());
            Console.WriteLine("Proporciona para cuanto tiempo requieres la póliza (ejemplo 2 años):");
            tiempo = Console.ReadLine();
            Console.WriteLine("Proporciona la suma asegurada:");
            suma = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Proporciona la fecha de Nacimiento del asegurado:");
            fechaN = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Proporciona el género del asegurado:");
            gen = Console.ReadLine();

            string [] cantidadTiempo = tiempo.Split(' ');
            int cantTemp = int.Parse(cantidadTiempo[0]);
            tipoPeriodo Periodo = (tipoPeriodo)Enum.Parse(typeof (tipoPeriodo), cantidadTiempo[1]);
            Genero genero = (Genero)Enum.Parse(typeof(Genero), gen);
            Calcular(fechaVig, Periodo, cantTemp, suma, fechaN, genero);
        }
    }
}
