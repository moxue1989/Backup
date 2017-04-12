using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Product
    {
        // public properties with hidden/private data automatically created
        public string Name { get; set; }

        // private data with controlled access
        private decimal price;
        private int qty;
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                    price = 0; // assumes 0 when provided value negative
                else
                    price = value;
            }
         }
        public int Qty
        {
            get
            {
                return qty;
            }
            set
            {
                if (value < 0)
                    qty = 0; // assumes 0 when provided value negative
                else
                    qty = value;
            }
        }

        // default constructor (no parameters) just creates an object of this class and does not set anything
        // is automiatically created by compiler
        public Product() { }
        // constructors accept initial values
        public Product(string n, decimal p, int q)
        {
            Name = n;
            Price = p;
            Qty = q;
        }

        // public methods

        public string CsvString()
        {
            return Name + ", " + Price + ", " + Qty;
        }
        public override string ToString() // overrides inherited method ToString from object class
        {
            return Name + "\t" + Price.ToString("c") + "\t\t" + Qty.ToString();
        }
    }
}
