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
        public ActionResult ProcessLogin(AdminModel adminModel)
        {
            if(adminModel.Password == "ciao" && adminModel.UserName == "admin")
            {
                return View("LoginSuccess");
            }
            else
            {
                return View("LoginFailed");
            }
            
        }
    }
}