using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocio
{
    public class NAlumno
    {
        private DAlumno dalumno = new DAlumno();
        public List<alumnos> Consultar()
        {
            return dalumno.Consultar();
        }
        public alumnos Consultar(int id)
        {
            return dalumno.Consultar(id);
        }
        public void Agregar(alumnos alm)
        {
            dalumno.Agregar(alm);
        }
        public void Actualizar(alumnos alm)
        {
            dalumno.Actualizar(alm);
        }
        public void Eliminar(int id)
        {
            dalumno.Eliminar(id);
        }
    }
}