using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace Mo_Xue_LAB_3
{
    // technician database access class
    // uses Dapper extension to map data to technician class
    [DataObject(true)]
    public static class TechnicianDB
    {
        // select method
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Technician> GetAllTechnicians()
        {            
            List<Technician> techList = new List<Technician>();
            using (SqlConnection conn = TechSupportDB.GetConnection())
            {
                conn.Open();
                techList.AddRange(conn.Query<Technician>(TechSupportDB.GetAllTechniciansQuery));
            }
            return techList;
        }
    }
}