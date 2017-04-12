using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInheritance
{
    public static class CustomerDB
    {
        const string path = "Customers.txt";

        public static void SaveCustomers(List<Customer> customers)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            foreach(Customer customer in customers)
            {
                sw.WriteLine(customer.CSVString());
            }

            sw.Close();
        }
        public static List<Customer> LoadCustomers()
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<Customer> customers = new List<Customer>();
            Customer customer = new Customer();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] data = line.Split(',');
                
                switch (data[0])
                {
                    case "Retail":
                        customer = new RetailCustomer(data[0], data[1], data[2], data[3], data[4]);
                        break;
                    case "Wholesale":
                        customer = new WholesaleCustomer(data[0], data[1], data[2], data[3], data[4]);
                        break;
                    case "Generic":
                        customer = new Customer(data[0], data[1], data[2], data[3]);
                        break;
                    default:
                        break;                       
                }
                customers.Add(customer);
            }
            sr.Close();
            return customers;
        }


    }
}
