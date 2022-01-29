using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiE.Data.Models
{
    public partial class AlumnosBaja
    {
        public int IdAlumnosBaja { get; set; }
        public string NombreAlumno { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaBaja { get; set; }
    }
}
