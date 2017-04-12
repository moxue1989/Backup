using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Product
    {
        private string Code { get; set; }
        private string Name { get; set; }
        private decimal Price { get; set; }

        public Product(string c, string n, decimal p)
        {
            Code = c;
            Name = n;
            Price = p;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
