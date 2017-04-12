using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Mo_Xue_LAB_3
{
    // general database access class
    public static class TechSupportDB
    {
        // connection string
        public static SqlConnection GetConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            return new SqlConnection(connString);
        }

        // get all connection query
        public static string GetAllTechniciansQuery =
            @"SELECT * FROM Technicians ORDER BY Name";

        // get open incidents for particular technician query
        public static string GetOpenTechIncidentsQuery =
            @"SELECT I.IncidentID, I.DateOpened,C.Name AS CustomerName,P.Name AS ProductName,I.Title,I.Description, I.TechID, I.DateClosed
            FROM Incidents I, customers C, Products P 
            WHERE I.CustomerID = C.CustomerID AND I.ProductCode = p.ProductCode
            AND DateClosed IS NULL
            AND TechID = @TechID
            ORDER BY DateOpened";
    }
}