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
        public ActionResult Delete(int id)
        {
            SediDAO sedi = new SediDAO();
            sedi.Elimina(sedi.TrovaConID(id));
            return View("LoginSuccess", sedi.TutteLeSedi());
        }
        public ActionResult Edit(int id)
        {
            SediDAO sedi = new SediDAO();
            SediModel sede = sedi.TrovaConID(id);
            return View("EditForm", sede);
        }
        public ActionResult Create()
        {
            return View("CreateForm");
        }
        [HttpPost]
        public ActionResult ProcessCreate(SediModel sedeModel)
        {
            SediDAO sedi = new SediDAO();
            sedi.Crea(sedeModel);
            return View("LoginSuccess", sedi.TutteLeSedi());
        }

        [HttpPost]
        public ActionResult ProcessEdit(SediModel sedeModel)
        {
            SediDAO sedi = new SediDAO();
            sedi.Modifica(sedeModel);
            return View("LoginSuccess", sedi.TutteLeSedi());
        }
    }
}