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
            SediDAO sedi = new SediDAO();
            return View(sedi.TutteLeSedi());
        }

    }
}