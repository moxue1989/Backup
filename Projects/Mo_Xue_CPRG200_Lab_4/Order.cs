using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mo_Xue_CPRG200_Lab_4
{
    public class Order
    {
        // properties of order class
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }

        // get details for this order
        public List<Order_Detail> GetOrderDetails()
        {
            return Database.OrderDetails(OrderID);
        }

        // tostrign method for displaying to orders list box
        public override string ToString()
        {
            return OrderID + " \t\t " + CustomerID;
        }
    }
}
