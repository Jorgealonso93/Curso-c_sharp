using Entidades;
using Negocio;
using Negocio.ServicioWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class AlumnosController : Controller
    {
        private NAlumno nalumno = new NAlumno();
        private NEstado nestado = new NEstado();
        private NEstatusAlumno nestatus = new NEstatusAlumno();
        // GET: Alumnos
        public ActionResult Index()
        {
            List<alumnos> alum = nalumno.Consultar();
            return View(alum);
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int id)
        {
            alumnos alm = nalumno.Consultar(id);
            return View(alm);
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            List<alumnos> alumno = nalumno.Consultar();
            List<estados> estados = nestado.Consultar();
            List<estatus_alumnos> estatus = nestatus.Consultar();
            ViewBag.id_estado = new SelectList(estados, "id_estado", "nombre_estado");
            ViewBag.id_estatus = new SelectList(estatus, "id_estatus", "nombre");
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(alumnos alum)
        {
            try
            {
                nalumno.Agregar(alum);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int id)
        {
            alumnos alumno = nalumno.Consultar(id);
            List<estados> estados = nestado.Consultar();
            List<estatus_alumnos> estatus = nestatus.Consultar();
            ViewBag.id_estado = new SelectList(estados, "id_estado", "nombre_estado", alumno.id_estado);
            ViewBag.id_estatus = new SelectList(estatus, "id_estatus", "nombre", alumno.id_estatus);
            return View(alumno);
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, alumnos alm)
        {
            try
            {
                // alm = nalumno.Consultar(id);
                //List<estados> estados = nestado.Consultar();
                //List<estatus_alumnos> estatus = nestatus.Consultar();
                //ViewBag.id_estado = new SelectList(estados, "id_estado", "nombre_estado", alm.id_estado);
                //ViewBag.id_estatus = new SelectList(estatus, "id_estatus", "nombre", alm.id_estatus);
                nalumno.Actualizar(alm);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int id)
        {
            alumnos alum = nalumno.Consultar(id);
            return View(alum);
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, alumnos alm)
        {
            try
            {
                alm = nalumno.Consultar(id);
                nalumno.Eliminar(alm.id_alumno);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult _AportacionesIMMS(int id)
        {
            NAlumno nAlumno = new NAlumno();
            var Cimms = nalumno.CalcularIMMS(id);
            return PartialView(Cimms);
        }
        public ActionResult _CalcularISR(int id)
        {
            NAlumno nalumno = new NAlumno();
            var isr = nalumno.CalcularISR(id);
            return PartialView(isr);
        }
    }
}
