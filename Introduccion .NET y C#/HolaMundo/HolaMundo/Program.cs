using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saludo hola = new Saludo();
            string nombre;
            nombre = hola.leer();
            hola.imprimir(nombre);
        }
 
    }
}
