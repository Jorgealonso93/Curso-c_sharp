using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webServiceASMX
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public AportacionesIMSS CalcularIMMS(int id)
        {
            NAlumno alumno = new NAlumno();
            Alumno alumn = alumno.Consultar(id);
            decimal sueldo = Convert.ToDecimal(alumn.sueldo);
            AportacionesIMSS imms = alumno.CalcularIMMS(sueldo);
            return imms;
        }
        [WebMethod]
        public TablaISR CalcularISR(int id)
        {
            NAlumno alumno = new NAlumno();
            var alumn = alumno.Consultar(id);
            decimal sueldo = Convert.ToDecimal(alumn.sueldo);
            TablaISR isr = alumno.CalcularISR(sueldo);
            return isr;
        }
    }
}
