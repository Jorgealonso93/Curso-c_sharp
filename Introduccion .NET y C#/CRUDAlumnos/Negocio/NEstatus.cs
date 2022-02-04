using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class NEstatus
    {
        DEstatusAlumno destatusAlumno = new DEstatusAlumno();
        List<EstatusAlum> listEstatusAlumno = new List<EstatusAlum>();

        public List<EstatusAlum> Consultar()
        {
            return destatusAlumno.Consultar();
        }
        public EstatusAlum Consultar(int id)
        {
            return destatusAlumno.Consultar(id);
        }
    }
}
