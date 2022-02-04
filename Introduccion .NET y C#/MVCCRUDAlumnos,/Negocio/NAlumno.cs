using Datos;
using Entidades;
using Negocio.ServicioWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAlumno
    {
        private Negocio.ServicioWCF.AlumnoWCFClient serv = new Negocio.ServicioWCF.AlumnoWCFClient();
        private DAlumno dalumno = new DAlumno();
        public List<alumnos> Consultar()
        {
            return dalumno.Consultar();
        }
        public alumnos Consultar(int id)
        {
            return dalumno.Consultar(id);
        }
        public void Agregar(alumnos alm)
        {
            dalumno.Agregar(alm);
        }
        public void Actualizar(alumnos alm)
        {
            dalumno.Actualizar(alm);
        }
        public void Eliminar(int id)
        {
            dalumno.Eliminar(id);
        }
        public AportacionesIMSS CalcularIMMS(int id)
        {
           
            return serv.CalcularIMSS(id);
        }
        public TablaISR CalcularISR(int id)
        {
            return serv.CalcularISR(id);
        }
    }
}
