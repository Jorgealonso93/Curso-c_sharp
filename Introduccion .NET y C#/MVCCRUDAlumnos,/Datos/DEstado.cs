using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEstado
    {
        private instituto_tichEntities dbContext = new instituto_tichEntities();
        public List<estados> Consultar()
        {
            //List<alumnos> listAlumno = dbContext.alumnos.ToList();
            List<estados> listestados = dbContext.estados.ToList();
            //List<estatus_alumnos> listEstatus = dbContext.estatus_alumnos.ToList();
            //listAlumno = dbContext.alumnos.Include(x => x.estados).ToList();
            //listAlumno = dbContext.alumnos.Include(x => x.estatus_alumnos).ToList();

            return listestados;
        }
    }
}
