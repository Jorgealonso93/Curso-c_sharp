using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Datos
{
    public class DEstatusAlumo
    {
        private instituto_tichEntities1 dbContext = new instituto_tichEntities1();
        public List<estatus_alumnos> Consultar()
        {
            //List<alumnos> listAlumno = dbContext.alumnos.ToList();
            //List<estados> listestados = dbContext.estados.ToList();
            List<estatus_alumnos> listEstatus = dbContext.estatus_alumnos.ToList();
            //listAlumno = dbContext.alumnos.Include(x => x.estados).ToList();
            //listAlumno = dbContext.alumnos.Include(x => x.estatus_alumnos).ToList();

            return listEstatus;
        }
    }
}