//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(alumnosDataAnnotations))]
    
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
    public class alumnosDataAnnotations
    {

        public int id_alumno { get; set; }
/// <summary>
/// //////////////////////////////////////////////////////////////////
/// </summary>
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El {0} debe tener mínimo {2} y máximo {1} caracteres")]
        [DisplayName("Nombre del Alumno")]
        public string nombre_alumno { get; set; }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////
        /// </summary>
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(50, ErrorMessage ="La longitud máxima del {0} es de {1}")]
        [MinLength(3, ErrorMessage = "La longitud mínima del {0} es de {1}")]
        [DisplayName("Apellido Paterno")]
        public string primerApellido { get; set; }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////
        /// </summary>
        [DisplayName("Apellido Materno")]
        public string segundoApellido { get; set; }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Formato incorrecto")]
        public string correo { get; set; }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string telefono { get; set; }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Range(01-01-1990, 31-12-2000, ErrorMessage ="La fecha de nacimiento debe estar entre el {1} y el {2}")]
        public System.DateTime fechaNacimiento { get; set; }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [Required(ErrorMessage = "El {0} es obligatorio")]
        //[RegularExpression("", ErrorMessage = "El {0] no cumple con el formato")]
        public string curp { get; set; }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public decimal sueldo { get; set; }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        public int id_estado { get; set; }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        public short id_estatus { get; set; }
    }
}
