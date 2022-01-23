using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LINQ
{
    internal class OperacionesLINQ
    {
        public void Consultas()
        {
            StreamReader archivoAlum = new StreamReader("C:\\Users\\Tichs\\Documents\\Desarrollo .NET\\Introduccion .NET y C#\\Alumnos.json");
            string jsonAlum = archivoAlum.ReadToEnd();
            archivoAlum.Close();
            List<Alumnos> _listAlumno = JsonConvert.DeserializeObject<List<Alumnos>>(jsonAlum);

            StreamReader archivoEstado = new StreamReader("C:\\Users\\Tichs\\Documents\\Desarrollo .NET\\Introduccion .NET y C#\\Estados.json");
            string jsonEstado = archivoEstado.ReadToEnd();
            archivoEstado.Close();
            List<Estado> _listEstado = JsonConvert.DeserializeObject<List<Estado>>(jsonEstado);

            StreamReader archivoEstatus = new StreamReader("C:\\Users\\Tichs\\Documents\\Desarrollo .NET\\Introduccion .NET y C#\\Estatus.json");
            string jsonEstatus = archivoEstatus.ReadToEnd();
            archivoEstatus.Close();
            List<Estatus> _listEstatus = JsonConvert.DeserializeObject<List<Estatus>>(jsonEstatus);

            StreamReader archivoISR = new StreamReader("C:\\Users\\Tichs\\Documents\\Desarrollo .NET\\Introduccion .NET y C#\\Estatus.json");
            List<ItemISR> _listISR = new List<ItemISR>();
            var csv = new CsvReader(archivoISR, CultureInfo.InvariantCulture);
            _listISR = csv.GetRecords<ItemISR>().ToList();

            var Estado5 = _listEstado.First(estado => estado.idEstado==5);
            Console.WriteLine($"El estado con id {Estado5.idEstado} es= {Estado5.nomEstado}");

            var Alum1 = from alumno in _listAlumno
                        where alumno.idEstado == 29 || alumno.idEstado == 13
                        orderby alumno.Nombre descending
                        select alumno;
            Console.WriteLine("Alumnos con idEstado 29 y 13");
            foreach (var item in Alum1)
            {
                Console.WriteLine(item);
            }

            var Alum2 = from alumno in _listAlumno
                        where alumno.idEstado == 19 || alumno.idEstado == 20 && alumno.idEstatus== 4 || alumno.idEstatus==5
                        select alumno;
            Console.WriteLine("Alumnos con idEstado 19 y 20 y idEstatus 4 o 5");
            foreach (var item2 in Alum2)
            {
                Console.WriteLine(item2);
            }

            var alumCal = from alumno in _listAlumno
                          where alumno.Calificacion >= 6
                          orderby alumno.Calificacion descending
                          select alumno;
            Console.WriteLine("Alumnos con calificacion aprobatoria:");
            foreach(var alumcal in alumCal)
            {
                Console.WriteLine(alumcal);
            }

            Console.WriteLine($"Califacion promedio de Alumnos: {_listAlumno.Average(a => a.Calificacion)}");

            foreach (var itemCal in alumCal)
            {
                if (itemCal.Calificacion >= 6 && itemCal.Calificacion <= 7)
                {
                    //checar si se puede alterar la clase alumnos.
                    Console.WriteLine($"Alumnos entre 6 y 7: {itemCal.Nombre}, calificacion: {itemCal.Calificacion+2}");
                }else if (itemCal.Calificacion >8 && itemCal.Calificacion < 10)
                {
                    Console.WriteLine($"Alumnos entre que no tienen 10: {itemCal.Nombre}, calificacion: {itemCal.Calificacion + 1}");
                }
            }

            var alumEstatus3 = from alumno in _listAlumno
                               where alumno.idEstatus == 3
                               join estado in _listEstado on alumno.idEstatus equals estado.idEstado
                               select new { idAlum = alumno.id, nomAlumno = alumno.Nombre, estado = estado.nomEstado };
            Console.WriteLine("Estado de origen de los Alumnos con estatus 3...");
            foreach (var itemEstatusA3 in alumEstatus3)
            {
                Console.WriteLine($"ID: {itemEstatusA3.idAlum}, NOMBRE: {itemEstatusA3.nomAlumno}, Estatus: {itemEstatusA3.estado}");
            }

            var alumEstatus2 = from alumno in _listAlumno
                               where alumno.idEstatus == 2
                               join estatus in _listEstatus on alumno.idEstatus equals estatus.idEstatus
                               orderby alumno.Nombre descending
                               select new { idAlumno = alumno.id, nombre = alumno.Nombre, estatus.nombreEstatus};
            Console.WriteLine("Alumnos con estatus 2...");
            foreach (var alumnoEstatus in alumEstatus2)
            {
                Console.WriteLine($"ID: {alumnoEstatus.idAlumno}, Nombre: {alumnoEstatus.nombre}, Estatus: {alumnoEstatus.nombreEstatus}");
            }

            var AstatusMayor2 = from alumno in _listAlumno
                                where alumno.idEstatus > 2
                                join Estatus in _listEstatus on alumno.idEstatus equals Estatus.idEstatus
                                join estado in _listEstado on alumno.idEstado equals estado.idEstado
                                orderby Estatus.nombreEstatus descending
                                select new { idalum = alumno.id, nombreA = alumno.Nombre, nomEstado = estado.nomEstado, nomEstatus = Estatus.nombreEstatus};
            Console.WriteLine("Estado de origen de los alumnos con estatus 2...");
            foreach (var astatusmayor2 in AstatusMayor2)
            {
                Console.WriteLine($"ID: {astatusmayor2.idalum}, NOMBRE {astatusmayor2.nombreA}, ESTADO: {astatusmayor2.nomEstado}, ESTATUS: {astatusmayor2.nomEstatus}");
            }

            var calculoISR = from itemisr in _listISR
                             where itemisr.LimInf == 11951.86m && itemisr.LimSup == 18837.75m
                             select new { sueldoQ = 22000.00m / 2, cuotaf = itemisr.Cuotafija, porExce = itemisr.PorExced, subsidio = itemisr.Subsidio, Impuesto = (((22000.00m / 2)-itemisr.LimInf)*(itemisr.PorExced/100))-itemisr.Subsidio };
            Console.WriteLine("Calculo de impuesto por un sueldo de 22,000.00 Mensual...");
            foreach(var itemisr in calculoISR)
            {
                Console.WriteLine($"Sueldo Quincenal= {itemisr.sueldoQ}, Cuota Fija= {itemisr.cuotaf}, % Excedente= {itemisr.porExce}, Subsidio= {itemisr.subsidio}, Impuesto a pagar= {itemisr.Impuesto}");
            }
        }
    }
}
