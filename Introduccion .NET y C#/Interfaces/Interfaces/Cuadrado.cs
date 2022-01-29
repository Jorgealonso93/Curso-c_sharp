using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Cuadrado : IFigura
    {
        public decimal Base { get; set; }
        public decimal altura { get; set; }
        public decimal lado { get; set; }
        //public Cuadrado(decimal baseC, decimal lado, decimal altura)
        //{
        //    this.Base = baseC;
        //    this.altura = altura;
        //    this.lado = lado;
        //}
        //public Cuadrado()
        //{

        //}
        public decimal area()
        {
            return Base* altura;
        }
        public decimal perimetro()
        {
            return lado * 4;
        }
    }
}
