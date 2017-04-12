using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDataSources
{
    [DataObject(true)]
    public static class StateDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<State> GetStates()
        {
            List<State> states = new List<State>(); // make an empty list
            State st; // reference to new state object
            // create connection
            SqlConnection connection = MMABooksDB.GetConnection();

            // create select command
            string selectString = "select StateCode, StateName from States " +
                                  "order by StateName";
            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            try
            {
                // open connection
                connection.Open();
                // run the select command and process the results adding states to the list
                SqlDataReader reader = selectCommand.ExecuteReader();
                while(reader.Read())// process next row
                {
                    st = new State();
                    st.StateCode = reader["StateCode"].ToString();
                    st.StateName = reader["StateName"].ToString();
                    states.Add(st);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex; // throw it to the form to handle
            }
            finally
            {
                connection.Close();
            }
            return states;
        }
    }
}
