using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupName { get; set; }

        public override string ToString()
        {
            return SupName;
        }
    }
}
