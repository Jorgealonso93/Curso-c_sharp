using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Datos
{
    public class DAlumno
    {
        private instituto_tichEntities1 dbContext = new instituto_tichEntities1();
        public List<alumnos> Consultar()
        {
            List<alumnos> listAlumno = dbContext.alumnos.ToList();
            List<estados> listestados = dbContext.estados.ToList();
            List<estatus_alumnos> listEstatus = dbContext.estatus_alumnos.ToList();
            listAlumno = dbContext.alumnos.Include(x => x.estados).ToList();
            listAlumno = dbContext.alumnos.Include(x => x.estatus_alumnos).ToList();

            return listAlumno;
        }
        public alumnos Consultar(int id)
        {
            alumnos alm = dbContext.alumnos.Find(id);  
            return alm;
        }
        public void Agregar(alumnos alumno)
        {
            dbContext.alumnos.Add(alumno);
            dbContext.SaveChanges();
        }
        public void Actualizar(alumnos alumno)
        {
            alumnos al = dbContext.alumnos.Find(alumno.id_alumno);
            dbContext.Entry(al).CurrentValues.SetValues(alumno);
            dbContext.SaveChanges();
        }
        public void Eliminar(int id)
        {
            alumnos alm = dbContext.alumnos.Find(id);
            dbContext.alumnos.Remove(alm);
            dbContext.SaveChanges();
        }
    }
}