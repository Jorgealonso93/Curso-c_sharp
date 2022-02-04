using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAlumno
    {
        DAlumno dalumno = new DAlumno();
        public List<Alumno> Consultar()
        {
            return dalumno.Consultar();
        }
        public Alumno Consultar(int id)
        {
            return dalumno.Consultar(id);
        }
        public void Agregar (Alumno alumno)
        {
            dalumno.Agregar(alumno);
        }
        public void Actualizar(Alumno alumno)
        {
            dalumno.actualizar(alumno);
        }
        public void Eliminar(int id)
        {
            dalumno.Eliminar(id);
        }
        public TablaISR CalcularISR(decimal sueldo)
        {
            decimal sueldoQ, LInf, LSup, cFija, subs, exced;
            List<TablaISR> listaISR = dalumno.ConsultarTablaISR();
            TablaISR objISR = new TablaISR();
            
            sueldoQ = sueldo / 2;
            var elemntISR= from tablaisr in listaISR
                           where sueldoQ > tablaisr.limInf && sueldoQ < tablaisr.LimSup
                           select new {limI=tablaisr.limInf, limS=tablaisr.LimSup, cF=tablaisr.cuotaFija, sub=tablaisr.subsidio, exc=tablaisr.excedente};
            foreach(var item in elemntISR)
            {
                    LInf = item.limI;
                    LSup = item.limS;
                    cFija = item.cF;
                    subs = item.sub;
                    exced = (item.exc)/100;
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
        public AportacionesIMSS CalcularIMMS(decimal sueldo)
        {
            AportacionesIMSS objIMMS = new AportacionesIMSS
            {
                enfermedadMaternidad = (sueldo - (3 * 2925.09m)) * 0.4m,
                invalidezVida = sueldo * 0.625m,
                retiro = sueldo * 0,
                cesantia = sueldo * 1.125m,
                infonavit = sueldo * 0
            };

            return objIMMS;
        }
    }
}
