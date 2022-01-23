using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
     class Saludo
    {
        public void imprimir(string cadena)
        {
            
            Console.WriteLine("Hola " + cadena);
            Console.ReadLine();

        }
        public string leer()
        {
            String cadena;

            Console.WriteLine("Como te llamas?");
            cadena = Console.ReadLine();
            return cadena;
        }
        public void Presentacion()
        {
            String cadena;

            Console.WriteLine("Como te llamas?");
            cadena = Console.ReadLine();
            Console.ReadLine();
        }

    }
}
