using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiE.Data.Models
{
    public partial class Instructore
    {
        public Instructore()
        {
            CursoInstructores = new HashSet<CursoInstructore>();
        }

        public short IdInstructor { get; set; }
        public string NombreInstructor { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public decimal CuotaHora { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<CursoInstructore> CursoInstructores { get; set; }
    }
}
