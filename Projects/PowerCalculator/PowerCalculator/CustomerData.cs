using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerCalculator
{
    class CustomerData
    {
        // declare file to read and write to
        const string path = "customers.txt";

        // reads customer data from local file named "customers.txt"
        public static List<Customer> Read()
        {
            // initialize filestream and streamreader
            FileStream fs = null;
            StreamReader sr = null;

            // declare aux variables for creating customer objects and customer list
            string line = "";
            string[] row = new string[4];
            string[] seperators = new string[] { ", " }; // csv seperator
            Customer customer = null;
            List<Customer> customers = new List<Customer>();

            // try to read customer data from file and create a list of customer objects
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    // split line data into row array
                    row = line.Split(seperators, StringSplitOptions.None);

                    // create a customer objects from each line and add to customers list
                    customer = new Customer(Convert.ToInt32(row[0]), row[1], row[2], Convert.ToDecimal(row[3]));
                    customers.Add(customer);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Could not find file " + path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + ": " + ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close(); // close if file is not null
                }
            }
            // return customer list
            return customers;
        }

        // saves customer data to local file named "customers.txt"
        public static void Save(List<Customer> custlist)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                foreach (Customer cust in custlist)
                {
                    sw.WriteLine(cust.CsvString());
                }
                MessageBox.Show("Customer data saved!");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Could not find file " + path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + ": " + ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close(); // close if file is not null
                }
            }
        }
    }
}
