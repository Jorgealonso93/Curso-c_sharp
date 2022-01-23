using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_Venta
{
    public abstract class ItemBase
    {
        private int _Id;
        private string _Nombre;
        private decimal _Precio;
        private int _Cantidad;
        public int Id { get; set; }
        public string Nombre { get; set;}
        public decimal Precio { get; set;}
        public int Cantidad { get; set;}

        public ItemBase(int id, string nombre, decimal precio, int cantidad)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
        public ItemBase()
        {

        }
        public decimal Subtotal()
        {
            decimal subtotal = Precio * Cantidad;
            return subtotal;
        }
        public virtual decimal Total()
        {
            decimal total = Precio * Cantidad;
            return total;
        }
        public abstract string Imprimir();

    }
}
