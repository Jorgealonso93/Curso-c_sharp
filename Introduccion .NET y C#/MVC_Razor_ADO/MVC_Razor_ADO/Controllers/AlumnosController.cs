using Datos;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Razor_ADO.Controllers
{
    public class AlumnosController : Controller
    {
        private NAlumno nalumno = new NAlumno();
        private NEstado nestado = new NEstado();
        private NEstatus nEstatus = new NEstatus();
        // GET: Alumnos
        public ActionResult Index()
        {
            ViewBag.Estados = nestado.Consultar();
            return View(nalumno.Consultar());
        }

        //GET: Alumno/Edit/5
        public ActionResult Details(int id)
        {
            return View(nalumno.Consultar(id));
        }

        [HttpPost]
        public ActionResult Details(int id, Alumno obj)
        {
            try
            {
                nalumno.Actualizar(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //GET: Alumno/Agregar
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            ViewBag.Estados = nestado.Consultar();
            ViewBag.Estatus = nEstatus.Consultar();
            nalumno.Agregar(alumno);
            return View();
        }
        public ActionResult Edit(int id)
        {
            NAlumno nalumno = new NAlumno();
            Alumno alumno = nalumno.Consultar(id);
            nalumno.Actualizar(alumno);
            return View();
        }
        public ActionResult Delete(int id)
        {
            NAlumno nAlumno = new NAlumno();
            Alumno alumno = nAlumno.Consultar(id);
            nAlumno.Eliminar(id);
            return View();
        }
    }
}