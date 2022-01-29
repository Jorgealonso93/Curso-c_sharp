using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiE.Data.Models
{
    public partial class CatCurso
    {
        public CatCurso()
        {
            Cursos = new HashSet<Curso>();
            InverseIdPrerequisitoNavigation = new HashSet<CatCurso>();
        }

        public short IdCatCurso { get; set; }
        public string ClaveCatCurso { get; set; }
        public string NombreCatCurso { get; set; }
        public string DescCatCurso { get; set; }
        public byte Horas { get; set; }
        public short? IdPrerequisito { get; set; }
        public bool? Activo { get; set; }

        public virtual CatCurso IdPrerequisitoNavigation { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual ICollection<CatCurso> InverseIdPrerequisitoNavigation { get; set; }
    }
}
