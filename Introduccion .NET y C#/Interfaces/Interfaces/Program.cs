using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigura[] figuras = { new Cuadrado { Base = 5.0m, altura = 5.0m, lado = 5.0m }, new Triangulo { Base = 4.0m, altura = 4.0m, lado = 4.0m } };

            foreach (IFigura f in figuras)
            {
                Console.WriteLine($"{f.ToString()} Area= {f.area()} Perimetro= {f.perimetro()}");
                //decimal areaC= cuadrado.area(f.Base,f.altura);
                //decimal areaT = triangulo.area(f.Base,f.altura);
            }
            Console.ReadKey();
        }
    }
}
