using Datos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Text;

namespace WCFAlumno
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AlumnoWCF" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AlumnoWCF.svc o AlumnoWCF.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AlumnoWCF : IAlumnoWCF
    {
        private DAlumno dalumno = new DAlumno();
        private TablaISR isr = new TablaISR();
        public AportacionesIMSS CalcularIMSS(int id)
        {
            ///////////Tratar de serializar con el objeto Entidades.AportacionesIMMS/////
            Alumno alm = dalumno.Consultar(id);
            AportacionesIMSS objIMMS = new AportacionesIMSS
            {
                enfermedadMaternidad = (alm.sueldo - (3 * 2925.09m)) * 0.4m,
                invalidezVida = alm.sueldo * 0.625m,
                retiro = alm.sueldo * 0,
                cesantia = alm.sueldo * 1.125m,
                infonavit = alm.sueldo * 0
            };

            return objIMMS;
        }


        public TablaISR CalcularISR(int id)
        {
            decimal sueldoQ, LInf, LSup, cFija, subs, exced;
            
            //////////////////////Serializar un Objeto///////////////////////
            ////NAlumno nAlumno = new NAlumno();
            ////Entidades.TablaISR aisr = nAlumno.CalcularISR(id);
            List<Entidades.TablaISR> listaISR = dalumno.ConsultarTablaISR();

            var jsonISR = JsonConvert.SerializeObject(listaISR);
            System.IO.File.WriteAllText(@"C:\Users\Tichs\Documents\Desarrollo .NET\Introduccion .NET y C#\ISR2.json", jsonISR);
            var openISR = JsonConvert.DeserializeObject<List<TablaISR>>(jsonISR);
            //return openISR;
            /////////////////////Deserializar Objeto////////////////////////////

            Alumno alm = dalumno.Consultar(id);
            TablaISR objISR = new TablaISR();

            sueldoQ = alm.sueldo / 2;

            var elemntISR = from tablaisr in openISR
                            where sueldoQ > tablaisr.limInf && sueldoQ < tablaisr.LimSup
                            select new { limI = tablaisr.limInf, limS = tablaisr.LimSup, cF = tablaisr.cuotaFija, sub = tablaisr.subsidio, exc = tablaisr.excedente };
            foreach (var item in elemntISR)
            {
                LInf = item.limI;
                LSup = item.limS;
                cFija = item.cF;
                subs = item.sub;
                exced = (item.exc) / 100;
                var result = (sueldoQ - LInf) * exced;
                objISR = new TablaISR
                {
                    limInf = LInf,
                    LimSup = LSup,
                    cuotaFija = cFija,
                    subsidio = subs,
                    excedente = exced,
                    impuesto = (result + cFija) - exced
                };
            }

            return objISR;
        }

    }
}
