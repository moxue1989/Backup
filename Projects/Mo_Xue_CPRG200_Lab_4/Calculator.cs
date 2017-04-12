using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mo_Xue_CPRG200_Lab_4
{
    public static class Calculator
    {
        // calculate total cost for each order
        public static decimal CalculateTotal(List<Order_Detail> details)
        {
            decimal GrandTotal = 0m;
            foreach (Order_Detail detail in details)
            {
                GrandTotal += detail.CalculateSubtotal();
            }
            return GrandTotal;
        }
    }
}
