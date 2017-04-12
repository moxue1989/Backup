using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheritance
{
    public class DiscountProduct : Product
    {
        int discountPercent;
        public DiscountProduct(string n = "unknown", decimal p = 0m, int q = 0, int i = 10) : base(n, p, q)
        {
            discountPercent = i;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + discountPercent.ToString();
        }
    }
}
