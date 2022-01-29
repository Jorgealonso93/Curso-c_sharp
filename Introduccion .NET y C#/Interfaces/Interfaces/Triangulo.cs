using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Triangulo :IFigura
    {
        public decimal Base { get; set; }
        public decimal altura { get; set; }
        public decimal lado { get; set; }

        //public Triangulo(decimal Base, decimal Altura, decimal Lado)
        //{
        //    this.Base = Base;
        //    this.lado = Lado;
        //    this.altura = Altura;
        //}
        //public Triangulo()
        //{

        //}
        public decimal area()
        {
            return Base * altura / 2;
        }
        public decimal perimetro()
        {
            return lado*3;
        }
    }
}
