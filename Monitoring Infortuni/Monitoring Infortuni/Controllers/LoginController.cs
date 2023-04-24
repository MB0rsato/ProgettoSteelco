using Monitoring_Infortuni.Models;
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
            if(adminModel.Password == "ciao" && adminModel.UserName == "admin")
            {
                SediDAO sedi = new SediDAO();
                return View("LoginSuccess",sedi.TutteLeSedi());
            }
            else
            {
                return View("LoginFailed", adminModel);
            }
            
        }
    }
}