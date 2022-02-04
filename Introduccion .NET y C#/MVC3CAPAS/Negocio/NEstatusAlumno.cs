using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocio
{
    public class NEstatusAlumno
    {
        private DEstatusAlumo destatusAlumno = new DEstatusAlumo();
        public List<estatus_alumnos> Consultar()
        {
            return destatusAlumno.Consultar();
        }
    }
}