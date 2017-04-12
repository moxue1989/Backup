using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDataSources
{
    [DataObject(true)]
    public static class CustomerDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        // retrieves customer with given ID
        public static Customer GetCustomer(int customerID)
        {
            Customer cust = null; // found customer
            // define connection
            SqlConnection connection = MMABooksDB.GetConnection();

            // define the select query command
            string selectQuery = "select CustomerID, Name, Address, City, State, ZipCode " +
                                 "from Customers " +
                                 "where CustomerID = @CustomerID";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            selectCommand.Parameters.AddWithValue("@CustomerID", customerID);
            try
            {
                // open the connection
                connection.Open();

                // execute the query
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                // process the result if any
                if (reader.Read()) // if there is customer
                {
                    cust = new Customer();
                    cust.CustomerID = (int) reader["CustomerID"];
                    cust.Name = reader["Name"].ToString();
                    cust.Address = reader["Address"].ToString();
                    cust.City = reader["City"].ToString();
                    cust.State = reader["State"].ToString();
                    cust.ZipCode = reader["ZipCode"].ToString();
                }
            }
            catch(Exception ex)
            {
                throw ex; // let the form handle it
            }
            finally
            {
                connection.Close(); // close connecto no matter what
            }

            return cust;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        // retrieves customers from a given state
        public static List<Customer> GetCustomerByState(string stateCode)
        {
            List<Customer> customers = new List<Customer>(); // new list
            // define connection
            SqlConnection connection = MMABooksDB.GetConnection();

            // define the select query command
            string selectQuery = "select CustomerID, Name, Address, City, State, ZipCode " +
                                 "from Customers " +
                                 "where State = @State ORDER by Name";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            selectCommand.Parameters.AddWithValue("@State", stateCode);
            try
            {
                // open the connection
                connection.Open();

                // execute the query
                SqlDataReader reader = selectCommand.ExecuteReader();

                // process the result if any
                while (reader.Read()) // while there are still customers
                {
                    Customer cust = new Customer();
                    cust.CustomerID = (int)reader["CustomerID"];
                    cust.Name = reader["Name"].ToString();
                    cust.Address = reader["Address"].ToString();
                    cust.City = reader["City"].ToString();
                    cust.State = reader["State"].ToString();
                    cust.ZipCode = reader["ZipCode"].ToString();
                    customers.Add(cust);
                }
            }
            catch (Exception ex)
            {
                throw ex; // let the form handle it
            }
            finally
            {
                connection.Close(); // close connecto no matter what
            }

            return customers;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        // inserts new customer record
        public static int AddCustomer(Customer cust) // returns generated customer id
        {
            int custID = 0;
            // prepare connection
            SqlConnection connection = MMABooksDB.GetConnection();

            // prepare the statement
            string insertString = "insert into Customers " +
                                  "(Name, Address, City, State, ZipCode) " +
                                  "values(@Name, @Address, @City, @State, @ZipCode)";
            SqlCommand insertCommand = new SqlCommand(insertString, connection);
            insertCommand.Parameters.AddWithValue("@Name", cust.Name);
            insertCommand.Parameters.AddWithValue("@Address", cust.Address);
            insertCommand.Parameters.AddWithValue("@City", cust.City);
            insertCommand.Parameters.AddWithValue("@State", cust.State);
            insertCommand.Parameters.AddWithValue("@ZipCode", cust.ZipCode);

            try
            {
                // open connection
                connection.Open();

                // execute the statement
                int i = insertCommand.ExecuteNonQuery();
                if (i == 1) // one record inserted
                {
                    // retrieve customer id from the added record
                    string selectString = "select ident_current('Customers') " +
                                          "from Customers";
                    SqlCommand selectCommand = new SqlCommand(selectString, connection);
                    custID = Convert.ToInt32(selectCommand.ExecuteScalar()); // (int) does not work!!!
                }
            }
            catch (Exception ex)
            {
                throw ex; // pass the buck
            }
            finally
            {
                connection.Close();
            }
            return custID;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        // updates existing customer record and returns bool success flag
        public static bool UpdateCustomer(Customer oldCustomer, Customer newCustomer)
        {
            bool successful = false;
            SqlConnection connection = MMABooksDB.GetConnection();
            string updateString = "update Customers set " +
                                  "Name = @NewName, " +
                                  "Address = @NewAddress, " +
                                  "City = @NewCity, " +
                                  "State = @NewState," +
                                  "ZipCode = @NewZipCode " +
                                  "where " + // update succeeds only if record not changed by other users
                                  "Name  = @OldName and " +
                                  "Address = @OldAddress and " +
                                  "City = @OldCity and " +
                                  "State = @OldState and " +
                                  "ZipCode = @OldZipCode";
            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            updateCommand.Parameters.AddWithValue("@OldName", oldCustomer.Name);
            updateCommand.Parameters.AddWithValue("@OldAddress", oldCustomer.Address);
            updateCommand.Parameters.AddWithValue("@OldCity", oldCustomer.City);
            updateCommand.Parameters.AddWithValue("@OldState", oldCustomer.State);
            updateCommand.Parameters.AddWithValue("@OldZipCode", oldCustomer.ZipCode);
            updateCommand.Parameters.AddWithValue("@NewName", newCustomer.Name);
            updateCommand.Parameters.AddWithValue("@NewAddress", newCustomer.Address);
            updateCommand.Parameters.AddWithValue("@NewCity", newCustomer.City);
            updateCommand.Parameters.AddWithValue("@NewState", newCustomer.State);
            updateCommand.Parameters.AddWithValue("@NewZipCode", newCustomer.ZipCode);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count == 1)
                    successful = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return successful;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        // Delete operation returns bool success flag
        static public bool DeleteCustomer(Customer customer)
        {
            bool successful = false;

            SqlConnection connection = MMABooksDB.GetConnection();
            string deleteString = "delete from Customers " +
                                  "where " + // checking for optimistic concurrency
                                  "Name = @Name and " +
                                  "Address = @Address and " +
                                  "City = @City and " +
                                  "State = @State and " +
                                  "ZipCode = @Zipcode";
            SqlCommand deleteCommand = new SqlCommand(deleteString, connection);
            deleteCommand.Parameters.AddWithValue("@Name", customer.Name);
            deleteCommand.Parameters.AddWithValue("@Address", customer.Address);
            deleteCommand.Parameters.AddWithValue("@City", customer.City);
            deleteCommand.Parameters.AddWithValue("@State", customer.State);
            deleteCommand.Parameters.AddWithValue("@ZipCode", customer.ZipCode);

            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count == 1)
                {
                    successful = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return successful;
        }

    } // end class
} // end namespace
