using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Mo_Xue_Lab_4
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
            @"SELECT IncidentID, DateOpened, DateClosed, C.Name AS CustomerName,P.Name AS ProductName,I.Title,Description, TechID
            FROM Incidents I, customers C, Products P 
            WHERE I.CustomerID = C.CustomerID AND I.ProductCode = p.ProductCode
            AND DateClosed IS NULL
            AND TechID = @TechID
            ORDER BY DateOpened";

        // get all customers
        public static string GetAllCustomersQuery =
            @"SELECT CustomerID, Name FROM Customers";

        // get incidents by customerID
        public static string GetIncidentsByCustomerQuery =
            @"SELECT I.IncidentID, DateOpened, DateClosed, C.Name AS CustomerName,P.Name AS ProductName,I.Title,Description, TechID
            FROM Incidents I, customers C, Products P 
            WHERE I.CustomerID = C.CustomerID AND I.ProductCode = p.ProductCode
            AND I.CustomerID = @CustomerID
            ORDER BY DateOpened";
    }
}