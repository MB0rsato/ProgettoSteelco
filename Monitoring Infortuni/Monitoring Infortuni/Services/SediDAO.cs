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
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MonitoringInfortuni;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public int Crea(SediModel sede)
        {
            int nuovoId = -1;
            string sqlStatement = "INSERT INTO dbo.Sedi (Sede,Data) VALUES (@sede,@data)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@sede", sede.Sede);
                command.Parameters.AddWithValue("@data", sede.Data);
                try
                {
                    connection.Open();
                    nuovoId = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return nuovoId;
        }

        public int Elimina(SediModel sede)
        {
            int nuovoId = -1;
            string sqlStatement = "DELETE FROM dbo.Sedi WHERE Id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("id", sede.Id);
                try
                {
                    connection.Open();
                    nuovoId = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return nuovoId;

        }

        public int Modifica(SediModel sede)
        {
            int nuovoId = -1;
            string sqlStatement = "UPDATE dbo.Sedi SET Sede = @sede, Data = @data WHERE Id = @id";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@sede", sede.Sede);
                command.Parameters.AddWithValue("@data", sede.Data);
                command.Parameters.AddWithValue("id", sede.Id);
                try
                {
                    connection.Open();
                    nuovoId = Convert.ToInt32(command.ExecuteScalar());
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return nuovoId;
        }

        public SediModel TrovaConID(int id)
        {
            SediModel sede = null;
            string sqlStatement = "SELECT * FROM dbo.Sedi WHERE Id = @Id";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@Id", id);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        sede = new SediModel { Id = (int)reader[0], Sede = (string)reader[1], Data = (string)reader[2] };
                    }
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return sede;
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
                        sedi.Add(new SediModel { Id = (int)reader[0], Sede = (string)reader[1], Data = (string)reader[2] });
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