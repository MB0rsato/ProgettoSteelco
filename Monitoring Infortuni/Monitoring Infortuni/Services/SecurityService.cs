using Monitoring_Infortuni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monitoring_Infortuni.Services
{
    public class SecurityService
    {
        AdminsDAO adminsDAO = new AdminsDAO();
        public SecurityService()
        {
               
        }

        public bool IsValid(AdminModel admin)
        {
            return adminsDAO.TrovaAdmin(admin);
        }
    }
}