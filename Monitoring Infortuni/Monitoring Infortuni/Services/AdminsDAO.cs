using Monitoring_Infortuni.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Monitoring_Infortuni.Services
{
    public class AdminsDAO
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MonitoringInfortuni;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public bool TrovaAdmin(AdminModel admin)
        {
            bool trovato = false;
            string sqlStatement = "SELECT * FROM dbo.Admins WHERE UserName = @username AND Password = @password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 50).Value = admin.UserName;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 50).Value = admin.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        trovato = true;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return trovato;
        }
    }
}