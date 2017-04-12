using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace OracleConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            using ( conn = new SqlConnection(@"Data Source=ORCL;User Id=scott;Password=tiger;
Integrated Security=no;"))
            {
                conn.Open();
                var dept = conn.Query<dept>("SELECT * FROM CUSTOMERS").ToList();
                Console.WriteLine(dept[0].dname);
                Console.ReadKey();
            }
        }
    }
}
