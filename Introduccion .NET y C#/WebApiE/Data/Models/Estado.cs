using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiE.Data.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Alumnos = new HashSet<Alumno>();
        }

        public int IdEstado { get; set; }
        public string NombreEstado { get; set; }

        public virtual ICollection<Alumno> Alumnos { get; set; }
    }
}
