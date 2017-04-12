using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mo_Xue_CPRG200_Lab_4
{
    public class Order_Detail
    {
        // properties of order details class
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }

        // to string method to display error
        public override string ToString()
        {
            return OrderID.ToString();
        }

        // calculate subtotal for this order detail
        public decimal CalculateSubtotal()
        {
            return UnitPrice*Quantity*(1 - Discount);
        }
    }
}
