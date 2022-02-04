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
        public List<Estado> listEstado = new List<Estado>();
        DEstado destado = new DEstado();

        public List<Estado> Consultar()
        {
            return destado.Consultar();
        }
        public Estado Consultar(int id)
        {
            return destado.Consultar(id);
        }
    }
}
