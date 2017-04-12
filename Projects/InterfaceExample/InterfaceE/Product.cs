using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceE
{
    class Product: IComparable
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
            return Code + Name + Price.ToString("c");
        }

        int IComparable.CompareTo(object obj)
        {
            Product P = (Product) obj;
            if (this.Price < P.Price)
            {
                return -1;
            }
            else if (this.Price == P.Price)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
