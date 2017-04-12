using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public static class StateDB
    {
        public static List<State> GetStates()
        {
            List<State> states = new List<State>(); //make empty state list

            // Define connection
            SqlConnection conn = MMABooksDB.getConnection();
            // Define the select command
            string selectQuery = @"SELECT StateCode, StateName FROM States ORDER by StateName";
            SqlCommand selectCommand = new SqlCommand(selectQuery, conn);
            try
            {
                // Open connection
                conn.Open();

                // Execute query
                SqlDataReader reader = selectCommand.ExecuteReader();

                // Process the result if any
                while (reader.Read())
                {
                    State state = new State()
                    {
                        StateCode = reader["StateCode"].ToString(),
                        StateName = reader["StateName"].ToString()
                    };
                    states.Add(state);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex; // let form handle it
            }
            finally
            {
                conn.Close(); // close connection no matter what
            }
            return states;
        }
    }
}
