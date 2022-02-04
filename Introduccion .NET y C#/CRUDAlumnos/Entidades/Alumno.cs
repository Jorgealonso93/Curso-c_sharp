using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string primerApellido { get; set; }
        public string segunndoApellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string Curp { get; set; }
        public decimal sueldo { get; set; }
        public int idEstado { get; set; }
        public int idEstatus { get; set; }
    }
}
