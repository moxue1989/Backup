using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInheritance
{
    public class Customer
    {
        public string Type { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Customer()
        {

        }

        public Customer(string type, string firstname, string lastname, string email)
        {
            Type = type;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
        }

        public override string ToString()
        {
            return Type + " " + FirstName + " " + LastName + " " + Email;
        }
        public virtual string CSVString()
        {
            return Type + "," + FirstName + "," + LastName + "," + Email;
        }
    }
}
