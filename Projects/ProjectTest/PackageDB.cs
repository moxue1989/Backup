using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ProjectTest
{
    public static class PackageDB
    {
        const string connectionString =
            @"Data Source=ICTVM-FQQ06UJG2\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
        public static List<Package> GetPackages()
        {
            var results = new List<Package>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM packages";
                conn.Open();
                results.AddRange(conn.Query<Package>(sqlQuery));
            }
            return results;
        }

        public static List<Product> GetProductsByPackageId(int packageId)
        {
            var results = new List<Product>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlQuery = @"SELECT pd.ProductId, pd.ProdName 
                    FROM Products pd, Packages pg, Packages_Products_Suppliers pp, Products_Suppliers ps
                    WHERE pd.ProductId = ps.ProductId
                    and pp.ProductSupplierId = ps.ProductSupplierId
                    and pp.PackageId = pg.PackageId
                    and pg.PackageId = @packageId";

                conn.Open();
                results.AddRange(conn.Query<Product>(sqlQuery, new {packageId}));
            }
            return results;
        }
    }
}
