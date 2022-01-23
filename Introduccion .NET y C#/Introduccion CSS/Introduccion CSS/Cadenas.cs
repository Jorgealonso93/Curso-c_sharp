using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_CSS
{
    internal class Cadenas
    {
        public void HolaMundo()
        {
            Console.WriteLine("Proporciona Tu nombre:");
            string nombre = Console.ReadLine().TrimStart(' ').TrimEnd(' ');
            Console.WriteLine("Proporciona tu Primer APëllido:");
            string primerApellido = Console.ReadLine().TrimStart(' ').TrimEnd(' ');
            Console.WriteLine("Proporciona tu Segundo Apellido:");
            string segundoApellido = Console.ReadLine().TrimStart(' ').TrimEnd(' ');
            Console.WriteLine("Proporciona tu Edad:");
            string edad = Console.ReadLine().TrimStart(' ').TrimEnd(' ');

            Console.WriteLine("Hola" + " " + nombre + " " + primerApellido + " " + segundoApellido);
            Console.WriteLine("{0} {1} {2} tiene {3} años", nombre, primerApellido, segundoApellido,edad);
        
            Console.WriteLine($"Gusto en conocerte {nombre.ToUpper()} {primerApellido.ToUpper()} {primerApellido.ToUpper()}");
            Console.WriteLine(@"C:\Documentos\Diplomado.Net\{0}{1}{2}.docx", nombre, primerApellido, segundoApellido);
            Console.ReadLine();
        }
    }
}
