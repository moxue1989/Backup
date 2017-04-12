using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mo_Xue_CPRG200_Lab_4
{
    public static class Settings
    {
        // connection string (SQL database file)
        public static string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30";

        // test connection string (SQL server)
        public static string connectionStringSQL =
            @"Data Source=ICTVM-FQQ06UJG2\SQLEXPRESS;Initial Catalog=northwind;Integrated Security=True";

        // query for selecting orders
        public static string ordersQuery = 
            @"SELECT [OrderID]
                ,[CustomerID]
                ,[OrderDate]
                ,[RequiredDate]
                ,[ShippedDate]
            FROM [Orders]";

        // query for seltecting order details base on orderId
        public static string orderDetailsQuery =
            @" SELECT [OrderID]
                ,[od].[ProductID]
                ,[ProductName]
                ,[od].[UnitPrice]
                ,[Quantity]
                ,[Discount]
            FROM [Order Details] [od], [Products] [p]
            WHERE [od].[ProductID] = [p].[ProductID]
            AND [OrderID] = @OrderID";

        // query to update shipped date by OrderID
        public static string updateShippingDateQuery =
            @"UPDATE orders set ShippedDate = @ShippedDate
			WHERE OrderID = @OrderID
            AND CustomerID = @CustomerID
            AND OrderDate = @OrderDate
            AND RequiredDate = @RequiredDate
            AND (ShippedDate = @OldShippedDate 
                OR @OldShippedDate IS NULL
                AND ShippedDate IS NULL)";
    }   
}
