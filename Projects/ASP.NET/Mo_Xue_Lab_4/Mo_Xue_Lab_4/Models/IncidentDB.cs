using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace Mo_Xue_Lab_4
{
    [DataObject(true)]
    public static class IncidentDB
    {
        // incident database access class
        // uses Dapper extension to map data to incident class

        // gets open incidents by techID
        public static List<Incident> GetOpenTechIncidents(int techID)
        {
            List<Incident> incidentList = new List<Incident>();
            using (SqlConnection conn = TechSupportDB.GetConnection())
            {
                conn.Open();
                incidentList.AddRange(conn.Query<Incident>(TechSupportDB.GetOpenTechIncidentsQuery, new { techID }));
            }
            return incidentList;
        }

        // gets open incidents by customerID
        public static List<Incident> GetIncidentsByCustomer(int customerID)
        {
            List<Incident> incidentList = new List<Incident>();
            using (SqlConnection conn = TechSupportDB.GetConnection())
            {
                conn.Open();
                incidentList.AddRange(conn.Query<Incident>(TechSupportDB.GetIncidentsByCustomerQuery, new { customerID }));
            }
            return incidentList;
        }
    }
}