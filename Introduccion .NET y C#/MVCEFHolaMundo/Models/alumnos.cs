//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCEFHolaMundo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class alumnos
    {
        public int id_alumno { get; set; }
        public string nombre_alumno { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        public string curp { get; set; }
        public decimal sueldo { get; set; }
        public int id_estado { get; set; }
        public short id_estatus { get; set; }
    
        public virtual estados estados { get; set; }
        public virtual estatus_alumnos estatus_alumnos { get; set; }
    }
}
