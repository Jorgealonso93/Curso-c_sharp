using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    internal class Calculadora1
    {
       public enum tipoOperacion : int
        {
            sumar = 1,
            restar = 2,
            multiplicar = 3,
            dividir = 4,
            modulo = 5
        }
        public void Sumar (decimal num1, decimal num2)
        {
            decimal result = 0;
            result = num1 + num2;
            Console.WriteLine("Resultado de la operacion =>" +result);
        }

        public void Restar(decimal num1, decimal num2)
        {
            decimal result = 0;
            result = num1 -num2;
            Console.WriteLine("Resultado de la operacion =>" + result);
        }

        public void Multiplicar(decimal num1, decimal num2)
        {
            decimal result = 0;
            result = num1 * num2;
            Console.WriteLine("Resultado de la operacion =>" + result);
        }

        public void Dividir(decimal num1, decimal num2)
        {
            decimal result = 0;
            result = num1 / num2;
            Console.WriteLine("Resultado de la operacion =>" + result);
        }

        public void Modulo(decimal num1, decimal num2)
        {
            decimal result = 0;
            result = num1 % num2;
            Console.WriteLine("Resultado de la operacion =>" + result);
        }

        public struct operacion
        {
            public decimal num1, num2;
            public tipoOperacion operando;

            public operacion(decimal operando1, decimal operando2, tipoOperacion operador)
            {
                num1 = operando1;
                num2 = operando2;
                operando = operador;
            }
        }

        public void Operacion(tipoOperacion operacionAritmetica, decimal number1, decimal number2)
        {

            switch(operacionAritmetica)
            {
                case tipoOperacion.sumar:
                    Sumar(number1 , number2);
                    break;
                case tipoOperacion.restar:
                    Restar(number1, number2);
                    break;
                case tipoOperacion.multiplicar:
                    Multiplicar(number1, number2);
                    break;
                case tipoOperacion.dividir:
                    Dividir(number1, number2);
                    break;
                case tipoOperacion.modulo:
                    Modulo(number1, number2);
                    break;
                default:
                    Console.WriteLine("El tipo de operacion no existe.");
                    break;
            }
        }
      
        public struct Resultados
        {
            public int sumar, restar, multiplicar, dividir, modulo;
            public Resultados(int sum, int res, int multi, int div, int mod)
            {
                this.sumar = sum;
                this.restar = res;
                this.multiplicar = multi;
                this.dividir = div;
                this.modulo = mod;
            }
        }

        static void simultaneas(decimal numero1, decimal numero2)
        {
            Resultados resultados = new Resultados();
            Calculadora1 opera = new Calculadora1();
            resultados.sumar = 1;
            resultados.restar = 2;
            resultados.multiplicar = 3;
            resultados.dividir = 4;
            resultados.modulo = 5;
            //int i = 0;
            int[] todas = new int[5] { resultados.sumar, resultados.restar, resultados.multiplicar, resultados.dividir, resultados.modulo };
            for (int i = 0; i <=4; i++)
            {
                opera.Operacion((tipoOperacion)todas[i], numero1, numero2);
            }
        }

       public void Presentacion()
        {
            //Resultados result;
            Console.WriteLine("Operacion a Realizar");
            Console.WriteLine("1. Suma\n2. Resta\n3. multiplicacion\n4.Dividir\n5.Modulo\n6. Todas");
            Console.WriteLine("Selecciona Operacion a Realizar:");
            int Opera = int.Parse(Console.ReadLine());
            Console.WriteLine("Porporciona el Primer Operando:");
            decimal operando1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Proporciona el Segundo Operador:");
            decimal operando2 = decimal.Parse(Console.ReadLine());

            if (Opera == 6)
            {
                simultaneas(operando1, operando2);
                Console.ReadLine();
            }
            else
            {
                Operacion((tipoOperacion)Opera, operando1,operando2);
                Console.ReadLine();
            }
        }
    }
}
