using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerCalculator
{
    public class Customer
    {
        // public properties with hidden/private data automatically created
        private int act;
        public string Name { get; set; }
        public string Type { get; set; }
        private decimal bill;

        // private data for account number
        public int Act
        {
            get
            {
                return act;
            }
            set
            {
                if (value < 0)
                    act = 0; // assumes 0 when provided value negative
                else
                    act = value;
            }
        }
 
        // private data for bill amount        
        public decimal Bill
        {
            get
            {
                return bill;
            }
            set
            {
                if (value < 0)
                    bill = 0; // assumes 0 when provided value negative
                else
                    bill = value;
            }
        }


        // default constructor (no parameters) just creates an object of this class and does not set anything
        // is automiatically created by compiler
        public Customer() { }
        // constructors accept initial values
        public Customer(int act ,string name, string type, decimal bill)
        {
            Name = name;
            Act = act;
            Type = type;
            Bill = bill;
        }

        // public methods

        public string CsvString() // use to store in data file
        {
            return Act + ", " + Name + ", " + Type + ", " + Bill;
        }
        public override string ToString() // overrides inherited method ToString from object class
        {
            string custType = "";
            switch (Type)
            {
                case "R":
                    custType = "Resendential";
                    break;
                case "C":
                    custType = "Commercial";
                    break;
                case "I":
                    custType = "Industrial";
                    break;
                default:
                    break;
            }

            return Act.ToString().PadRight(15) + "\t" + Name.PadRight(15) + "\t" + custType.PadRight(15)  + "\t" + bill.ToString("c").PadRight(15);
        }
    }
}