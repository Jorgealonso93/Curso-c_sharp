using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Estado
    {
        private int idestado;
        private string nombreEstado;

        public Estado()
        {

        }

        public Estado(int id_estado, string nomEstado)
        {
            idestado = id_estado;
            nombreEstado = nomEstado;
        }
        public int idEstado { get; set; }
        public string nomEstado { get; set;}
    }
}
