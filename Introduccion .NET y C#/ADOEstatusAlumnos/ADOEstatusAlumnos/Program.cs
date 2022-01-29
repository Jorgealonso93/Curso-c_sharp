using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOEstatusAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ADOEstatus ado = new ADOEstatus();
            ado.Presentacion();
            Console.ReadKey();

        }
    }
}
