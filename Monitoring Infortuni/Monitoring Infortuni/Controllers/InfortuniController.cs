using Monitoring_Infortuni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Monitoring_Infortuni.Controllers
{
    public class InfortuniController : Controller
    {
        // GET: Infortuni
        public ActionResult Index()
        {
            List<SediModel> listaDiSedi = new List<SediModel>();
            listaDiSedi.Add(new SediModel { Id = 1, Sede = "Sede 1", Data = new DateTime(2023, 2, 20), Attenzione = false });
            listaDiSedi.Add(new SediModel { Id = 2, Sede = "Sede 2", Data = new DateTime(2023, 3, 10), Attenzione = false });
            listaDiSedi.Add(new SediModel { Id = 3, Sede = "Sede 3", Data = new DateTime(2023, 4, 1), Attenzione = true });
            return View(listaDiSedi);
        }

        public ActionResult Accedi()
        {
            return View();
        }
    }
}