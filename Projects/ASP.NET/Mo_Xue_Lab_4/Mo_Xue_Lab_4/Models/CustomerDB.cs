using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace Mo_Xue_Lab_4
{
    public static class CustomerDB
    {
        // incident database access class
        // uses Dapper extension to map data to incident class
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customerList = new List<Customer>();
            using (SqlConnection conn = TechSupportDB.GetConnection())
            {
                conn.Open();
                customerList.AddRange(conn.Query<Customer>(TechSupportDB.GetAllCustomersQuery));
            }
            return customerList;
        }
    }
}