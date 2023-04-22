using Monitoring_Infortuni.Models;
using Monitoring_Infortuni.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Monitoring_Infortuni 
{
    public class SediDAO : ISediDataService
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Monitoring;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public int Elimina(SediModel sede)
        {
            throw new NotImplementedException();
        }

        public int Inserisci(SediModel sede)
        {
            throw new NotImplementedException();
        }

        public int Modifica(SediModel sede)
        {
            throw new NotImplementedException();
        }

        public List<SediModel> TutteLeSedi()
        {
            List<SediModel> sedi = new List<SediModel>();
            string sqlStatement = "SELECT * FROM dbo.Sedi";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        sedi.Add(new SediModel { Id = (int)reader[0], Sede = (string)reader[1], Data = (DateTime)reader[2] });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            return sedi;
        }
    }
}