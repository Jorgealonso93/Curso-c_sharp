using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiE.Data.Models
{
    public partial class Alumno
    {
        public Alumno()
        {
            CursoAlumnos = new HashSet<CursoAlumno>();
        }

        public int IdAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Curp { get; set; }
        public decimal Sueldo { get; set; }
        public int IdEstado { get; set; }
        public short IdEstatus { get; set; }

        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual EstatusAlumno IdEstatusNavigation { get; set; }
        public virtual ICollection<CursoAlumno> CursoAlumnos { get; set; }
    }
}
