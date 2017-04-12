using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInheritance
{
    public class WholesaleCustomer : Customer
    {
        public string Company { get; set; }

        public WholesaleCustomer(string type, string firstname, string lastname, string email, string company) : base(type, firstname, lastname, email)
        {
            Company = company;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Company;
        }

        public override string CSVString()
        {
            return base.CSVString() + "," + Company;
        }
    }
}
