using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEstado
    {
        private DEstado destado = new DEstado();
        public List<estados> Consultar()
        {
            return destado.Consultar();
        }
    }
}
