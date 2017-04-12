using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDataSources
{
    public static class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            //string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;"+
            //    "AttachDbFilename=|DataDirectory|\\MMABooks.mdf;"+
            //    "Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
