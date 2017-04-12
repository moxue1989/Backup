using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesData
{
    public static class InvoiceDB
    {
        public static List<Invoice> GetAllInvoices()
        {
            var invoices = new List<Invoice>();
            using (SqlConnection conn = MMABooksDB.GetConnection())
            {
                string selectQuery = @"SELECT * FROM Invoices";
                SqlCommand selectCommand = new SqlCommand(selectQuery,conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Invoice invoice = new Invoice();
                        invoice.InvoiceID = Convert.ToInt32(reader[0]);
                        invoice.CustomerID = Convert.ToInt32(reader[1]);
                        invoice.InvoiceDate = (DateTime)reader[2];
                        invoice.SalesTax = Convert.ToDecimal(reader[4]);
                        invoice.Shipping = Convert.ToDecimal(reader[5]);
                        invoice.InvoiceTotal = Convert.ToDecimal(reader[6]);
                        invoices.Add(invoice);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return invoices;
        }
    }
}
