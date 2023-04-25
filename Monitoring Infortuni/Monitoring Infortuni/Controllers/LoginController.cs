using Monitoring_Infortuni.Models;
using Monitoring_Infortuni.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Monitoring_Infortuni.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessLogin(AdminModel adminModel)
        {
            SecurityService securityService = new SecurityService();

            if(securityService.IsValid(adminModel))
            {
                SediDAO sedi = new SediDAO();
                return View("LoginSuccess",sedi.TutteLeSedi());
            }
            else
            {
                return View("LoginFailed", adminModel);
            }
        }
        public ActionResult Edit(int id)
        {
            SediDAO sedi = new SediDAO();
            SediModel sede = sedi.TrovaConID(id);
            return View("EditForm", sede);
        }

        [HttpPost]
        public ActionResult ProcessEdit(SediModel sede)
        {
            SediDAO sedi = new SediDAO();
            sedi.Modifica(sede);
            return View("LoginSuccess", sedi.TutteLeSedi());
        }
    }
}