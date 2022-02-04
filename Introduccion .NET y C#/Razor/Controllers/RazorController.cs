using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult HolaMundo()
        {
            return View();
        }
        public ActionResult Ciclos()
        {
            return View();
        }
    }
}