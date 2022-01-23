using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Arreglos1
    {
        public void Cadenas()
        {
            Console.WriteLine(".......::::::::::::: CADENAS::::::::::::::::::::::.......");
            Console.WriteLine("Proporciona tu nombre Completo:");
            string nombre = Console.ReadLine();
            string[] parteNombre = nombre.Split(' ');
            Console.WriteLine("Hola");
            foreach (string n in parteNombre)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Apellido Vertical:");
            string apellido = parteNombre[1];
            for (int i=0; i < apellido.Length;i++)
            {
                Console.WriteLine(apellido[i]);
            }
            Console.ReadLine();
        }
        public void Enteros()
        {
            Console.WriteLine("...........:::::::::::::: ENTEROS::::::::::::......");
            int [] Numeros = new int[5];   
            
            for(int i=0; i < Numeros.Length; i++)
            {
                Console.WriteLine("Proporciona un numero en la posicion" + i);
                Numeros[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("numero=>"+ Numeros[i]);
            }
            int pos = 0;
            int mayor = Numeros[0];
            for (int i = 1; i < Numeros.Length; i++)
            {
                if (Numeros[i] > mayor)
                {
                    mayor = Numeros[i];
                    pos = i;
                }
            }
            Console.WriteLine("El numero Mayor es =>" + mayor);
            Console.ReadLine();
        }
        public void ConvierteATipoOracion(string cadena)
        {
            string[] elemenCadena = cadena.Split(' ');
            string[] cadenaCompleta = new string[elemenCadena.Length];
            for( int i = 0; i < cadenaCompleta.Length; i++)
            {
                cadenaCompleta[i]= elemenCadena[i].Substring(0,1).ToUpper() + elemenCadena[i].Substring(1).ToLower();
            }
            Console.WriteLine("Cadena Convertida: ");
            Console.WriteLine(String.Join(" ", cadenaCompleta));
            Console.ReadLine();
        }
    }
}
