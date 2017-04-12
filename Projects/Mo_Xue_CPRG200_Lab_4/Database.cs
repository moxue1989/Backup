using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Mo_Xue_CPRG200_Lab_4
{
    // Database access class
    public static class Database
    {
        // selects all orders from database and return them in a list
        public static List<Order> GetOrders()
        {
            // initialize list
            var results = new List<Order>();

            // create connection
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();

                // Dapper extension to map data to Order class using ordersQuery
                IEnumerable<Order> orders = conn.Query<Order>(Settings.ordersQuery);

                // Add orders to results
                results.AddRange(orders);
            }
            return results;
        }

        // selects all details of a OrderID from database and returns them in a list of Order_Detail objects
        public static List<Order_Detail> OrderDetails(int id)
        {
            // initialize list
            var results = new List<Order_Detail>();

            // create connection
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();

                // Dapper extension to map data to Order_Details class using orderDetailsQuery for given OrderID
                IEnumerable<Order_Detail> orderDetails = conn.Query<Order_Detail>(Settings.orderDetailsQuery,new {OrderID = id});

                // Add Order_Details to results
                results.AddRange(orderDetails);
            }
            return results;
        }

        // Update shipped date of provided order
        public static int UpdateShippedDate(Order order, DateTime? oldShippedDate)
        {
            // create connection
            using (SqlConnection conn = new SqlConnection(Settings.connectionString))
            {
                conn.Open();

                // set up sqlcommand
                SqlCommand updateCommand = new SqlCommand(Settings.updateShippingDateQuery, conn);

                // add parameters
                updateCommand.Parameters.AddWithValue("@OrderID", order.OrderID);
                updateCommand.Parameters.AddWithValue("@ShippedDate", (object)order.ShippedDate ?? DBNull.Value);
                updateCommand.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                updateCommand.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                updateCommand.Parameters.AddWithValue("@RequiredDate", order.RequiredDate);
                updateCommand.Parameters.AddWithValue("@OldShippedDate", (object)oldShippedDate ?? DBNull.Value);

                // return rows affected by command
                return updateCommand.ExecuteNonQuery();
            }
        }
    }
}
