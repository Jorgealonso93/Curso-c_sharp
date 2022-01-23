using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\Tichs\Documents\Desarrollo .NET\Introduccion .NET y C#\isr.csv"));
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                listA.Add(values[0]);
                listB.Add(values[1]);
                foreach (var coloumn1 in listA)
                {
                    Console.WriteLine(coloumn1);
                }
                foreach (var coloumn2 in listA)
                {
                    Console.WriteLine(coloumn2);
                }

                //      string filePath =
                //@"C:\Users\Tichs\Documents\Desarrollo .NET\Introduccion .NET y C#\Alumnos.csv";
                //      StreamReader reader = null;
                //      if (File.Exists(filePath))
                //      {
                //          reader = new StreamReader(File.OpenRead(filePath));
                //          List<string> listA = new List<string>();
                //          while (!reader.EndOfStream)
                //          {
                //              var line = reader.ReadLine();
                //              var values = line.Split(',');
                //              foreach (var item in values)
                //              {
                //                  listA.Add(item);
                //              }
                //              foreach (var coloumn1 in listA)
                //              {
                //                  Console.WriteLine(coloumn1);
                //              }
                //          }
                //      }
                //      else
                //      {
                //          Console.WriteLine("File doesn't exist");
                //      }
                //      Console.ReadLine();
            }
        }
    }
}
