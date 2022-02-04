using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEstatusAlumno
    {
        private DEstatusAlumno destatusAlumno = new DEstatusAlumno();
        public List<estatus_alumnos> Consultar()
        {
            return destatusAlumno.Consultar();
        }
    }
}
