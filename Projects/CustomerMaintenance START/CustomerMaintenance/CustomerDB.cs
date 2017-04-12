using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public static class CustomerDB
    {

        public static Customer GetCustomer(int customerID)
        {
            Customer cust = null; //Initialize found customer

            // Define connection
            SqlConnection conn = MMABooksDB.getConnection();
            // Define the selected Query
            string selectQuery = @"SELECT CustomerID,Name,Address,City,State,ZipCode FROM Customers
                WHERE CustomerID = @CustomerID";
            SqlCommand selectCommand = new SqlCommand(selectQuery, conn);
            selectCommand.Parameters.AddWithValue("@CustomerID", customerID);
            try
            {
                // Open connection
                conn.Open();

                // Execute query
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                // Process the result if any
                if (reader.Read()) //only executes if there is a customer
                {
                    cust = new Customer
                    {
                        CustomerID = Convert.ToInt32(reader["CustomerID"]),
                        Name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        ZipCode = reader["ZipCode"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex; // let form handle it
            }
            finally
            {
                conn.Close(); // close connection no matter what
            }
            return cust;
        }

        public static int AddCustomer(Customer cust) // returns generated customer ID
        {
            int custID = 0;
            // Define connection
            SqlConnection conn = MMABooksDB.getConnection();
            // Define the insert command
            string insertQuery = @"INSERT INTO Customers
                                (Name,Address,City,State,ZipCode)
                                values(@Name,@Address,@City,@State,@ZipCode)";

            SqlCommand insertCommand = new SqlCommand(insertQuery, conn);
            insertCommand.Parameters.AddWithValue("@Name", cust.Name);
            insertCommand.Parameters.AddWithValue("@Address", cust.Address);
            insertCommand.Parameters.AddWithValue("@City", cust.City);
            insertCommand.Parameters.AddWithValue("@State", cust.State);
            insertCommand.Parameters.AddWithValue("@ZipCode", cust.ZipCode);

            try
            {
                // Open connection
                conn.Open();

                // Execute query
                if (insertCommand.ExecuteNonQuery() == 1)
                {
                    // Retrive added customer
                    string selectString = "SELECT ident_Current('Customers') from Customers";
                    SqlCommand selectCommand= new SqlCommand(selectString, conn);

                    // int typecasting does not work!!!
                    custID = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex; // let form handle it
            }
            finally
            {
                conn.Close(); // close connection no matter what
            }
            return custID;
        }

        public static bool UpdateCustomer(Customer oldCust, Customer newCust)
        {
            SqlConnection conn = MMABooksDB.getConnection();
            // Define the update command
            string updateQuery = @"UPDATE Customers SET
                Name = @newName,
                Address = @newAddress,
                City = @newCity,
                State = @newState,
                ZipCode = @newZipCode
                WHERE Name = @oldName 
                AND Address = @oldAddress 
                AND City = @oldCity 
                AND State = @oldState 
                AND ZipCode = @oldZipCode";

            SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
            updateCommand.Parameters.AddWithValue("@newName", newCust.Name);
            updateCommand.Parameters.AddWithValue("@newAddress", newCust.Address);
            updateCommand.Parameters.AddWithValue("@newCity", newCust.City);
            updateCommand.Parameters.AddWithValue("@newState", newCust.State);
            updateCommand.Parameters.AddWithValue("@newZipCode", newCust.ZipCode);

            updateCommand.Parameters.AddWithValue("@oldName", oldCust.Name);
            updateCommand.Parameters.AddWithValue("@oldAddress", oldCust.Address);
            updateCommand.Parameters.AddWithValue("@oldCity", oldCust.City);
            updateCommand.Parameters.AddWithValue("@oldState", oldCust.State);
            updateCommand.Parameters.AddWithValue("@oldZipCode", oldCust.ZipCode);

            try
            {
                // Open connection
                conn.Open();

                // Execute query
                if (updateCommand.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex; // let form handle it
            }
            finally
            {
                conn.Close(); // close connection no matter what
            }
        }

        public static bool DeleteCustomer(Customer cust)
        {
            SqlConnection conn = MMABooksDB.getConnection();
            // Define the delete command
            string deleteQuery = @"DELETE FROM Customers
                WHERE Name = @Name 
                AND Address = @Address 
                AND City = @City 
                AND State = @State 
                AND ZipCode = @ZipCode";

            SqlCommand updateCommand = new SqlCommand(deleteQuery, conn);
            updateCommand.Parameters.AddWithValue("@Name", cust.Name);
            updateCommand.Parameters.AddWithValue("@Address", cust.Address);
            updateCommand.Parameters.AddWithValue("@City", cust.City);
            updateCommand.Parameters.AddWithValue("@State", cust.State);
            updateCommand.Parameters.AddWithValue("@ZipCode", cust.ZipCode);

            try
            {
                // Open connection
                conn.Open();

                // Execute query
                if (updateCommand.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex; // let form handle it
            }
            finally
            {
                conn.Close(); // close connection no matter what
            }
        }
    }
}
