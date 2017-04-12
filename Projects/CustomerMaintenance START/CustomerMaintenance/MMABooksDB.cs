using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public static class MMABooksDB
    {
        public static SqlConnection getConnection()
        {
            string databaseString =
                @"Data Source=ICTVM-FQQ06UJG2\SQLEXPRESS;Initial Catalog=MMABooks;Integrated Security=True";
            string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MMABooks.mdf;Integrated Security=True;Connect Timeout=30";
                
            SqlConnection conn = new SqlConnection(databaseString);
            return conn;
        }
    }
}
