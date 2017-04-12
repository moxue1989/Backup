using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInheritance
{
    public class RetailCustomer : Customer
    {
        //static string Type = "Retail";
        public string PhoneNumber { get; set; }

        public RetailCustomer(string type, string firstname, string lastname, string email, string phonenumber) : base(type, firstname, lastname, email)
        {
            PhoneNumber = phonenumber;
        }

        public override string ToString()
        {
            return base.ToString() + " " + PhoneNumber;
        }
        public override string CSVString()
        {
            return base.CSVString() + "," + PhoneNumber;
        }
    }
}
