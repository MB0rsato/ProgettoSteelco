using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Monitoring_Infortuni.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AggiungiSede()
        {
            return View();
        }
        public ActionResult AggiungiInfortunio()
        {
            return View();
        }
        public ActionResult ModificaInfortunio()
        {
            return View();
        }
        public ActionResult Sedi()
        {
            return View();
        }
        public ActionResult ModificaSede()
        {
            return View();
        }
    }
}