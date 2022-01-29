using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiE.Data.Models
{
    public partial class EstatusAlumno
    {
        public EstatusAlumno()
        {
            Alumnos = new HashSet<Alumno>();
        }

        public short IdEstatus { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Alumno> Alumnos { get; set; }
    }
}
