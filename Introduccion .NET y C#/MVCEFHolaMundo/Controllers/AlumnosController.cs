using MVCEFHolaMundo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEFHolaMundo.Controllers
{
    public class AlumnosController : Controller
    {
        private instituto_tichEntities dbContext = new instituto_tichEntities();
        // GET: Alumnos
        public ActionResult Index()
        {
            var alumno = dbContext.alumnos.ToList();
            var estados = dbContext.estados.ToList();
            var estatus = dbContext.estatus_alumnos.ToList();
            alumno = dbContext.alumnos.Include(x => x.estados).ToList();
            alumno= dbContext.alumnos.Include(x => x.estatus_alumnos).ToList();
            return View(alumno);
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int id)
        {
            var alum = dbContext.alumnos.Where(x => x.id_alumno == id).SingleOrDefault();
            return View(alum);
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            List<alumnos> alumno = dbContext.alumnos.ToList();
            List<estados> estados = dbContext.estados.ToList();
            List<estatus_alumnos> estatus = dbContext.estatus_alumnos.ToList();
            ViewBag.id_estado = new SelectList(estados, "id_estado", "nombre_estado");
            ViewBag.id_estatus = new SelectList(estatus, "id_estatus", "nombre");
            return View(new alumnos());
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(alumnos alum)
        {
            try
            {
                dbContext.alumnos.Add(alum);
                dbContext.SaveChanges();

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
            alumnos alumno = dbContext.alumnos.Find(id);
            List<estados> estados = dbContext.estados.ToList();
            List<estatus_alumnos> estatus = dbContext.estatus_alumnos.ToList();
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
                alumnos al = dbContext.alumnos.Find(id);
                dbContext.Entry(al).CurrentValues.SetValues(alm);
                dbContext.SaveChanges();

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
            alumnos alum = dbContext.alumnos.Find(id);
            return View(alum);
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, alumnos alum)
        {
            try
            {
                alum = dbContext.alumnos.Where(x => x.id_alumno == id).SingleOrDefault();
                dbContext.alumnos.Remove(alum);
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
