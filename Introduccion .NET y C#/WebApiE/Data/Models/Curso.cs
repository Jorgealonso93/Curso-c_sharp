using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiE.Data.Models
{
    public partial class Curso
    {
        public Curso()
        {
            CursoAlumnos = new HashSet<CursoAlumno>();
            CursoInstructores = new HashSet<CursoInstructore>();
        }

        public short IdCurso { get; set; }
        public short? IdCatCurso { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaTermino { get; set; }
        public bool? Activo { get; set; }

        public virtual CatCurso IdCatCursoNavigation { get; set; }
        public virtual ICollection<CursoAlumno> CursoAlumnos { get; set; }
        public virtual ICollection<CursoInstructore> CursoInstructores { get; set; }
    }
}
