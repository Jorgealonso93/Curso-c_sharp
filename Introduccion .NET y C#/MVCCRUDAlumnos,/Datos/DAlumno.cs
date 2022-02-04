using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Datos
{
    public class DAlumno
    {
        private instituto_tichEntities dbContext = new instituto_tichEntities();
        public List<alumnos> Consultar()
        {
            List <alumnos> listalum = dbContext.alumnos.ToList();
            List<estados> listEstados = dbContext.estados.ToList();
            List<estatus_alumnos> listEstatus = dbContext.estatus_alumnos.ToList();
            listalum = dbContext.alumnos.Include(x => x.estados).ToList();
            listalum= dbContext.alumnos.Include(x => x.estatus_alumnos).ToList();

            return listalum;
        }
        public alumnos Consultar(int id)
        {
            alumnos alm = dbContext.alumnos.Find(id);
           // ViewBag.nombre_
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
