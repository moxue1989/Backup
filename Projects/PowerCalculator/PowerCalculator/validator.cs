using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // for TextBox

namespace PowerCalculator
{
    public static class Validator
    {
        // declare constants for validation
        const decimal MIN_USAGE = 0; // min power usage limit
        const decimal MAX_USAGE = 1000000; // max power usage limit
        const int MIN_ACT = 100000; // min account number
        const int MAX_ACT = 999999; // max account number
        const int MIN_LENGTH = 6; // min number of characters in customer name
        const int MAX_LENGTH = 20; // max number of characters in customer name

        // validate method for account number   
        public static bool ActIsValid (TextBox tb)
        {
            if(IsPresent(tb) && IsInt(tb) && IsWithinRange(tb, MIN_ACT, MAX_ACT))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // validate method for customer name
        public static bool NameIsValid(TextBox tb)
        {
            if (IsPresent(tb) && IsWithinLength(tb, MIN_LENGTH, MAX_LENGTH))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // calls all validate methods on input textbox for usage
        public static bool IsValid(TextBox tb)
        {
            if (IsPresent(tb) && IsDecimal(tb) && IsWithinRange(tb, MIN_USAGE, MAX_USAGE))
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
        // checks if text box is empty
        public static bool IsPresent(TextBox tb)
        {
            if(tb.Text != "")
            {
                return true;
            }
            else
            {
                // display empty error message
                MessageBox.Show(tb.Tag + " is required!", "input Error");
                tb.Focus();
                return false;
            }
        }

        // checks if text box contains decimal number
        public static bool IsDecimal(TextBox tb)
        {
            decimal num; // auxillary for trying parse
            if(Decimal.TryParse(tb.Text, out num))
            {
                return true;
            }
            else
            {
                // display decimal error message
                MessageBox.Show(tb.Tag + " has to be decimal value!", "input Error");
                tb.Focus();
                return false;
            }
        }

        // checks if decimal in text box is within range from min to max
        public static bool IsWithinRange(TextBox tb, decimal min, decimal max)
        {
            decimal value = Convert.ToDecimal(tb.Text);
            if (value >= min && value <= max)
            {
                return true;
            }
            else
            {
                // display range error message
                MessageBox.Show(tb.Tag + " must be within range: " + min + ".." + max, "input Error");
                tb.Focus();
                return false;
            }
        }

        // checks if text box contains integer number
        public static bool IsInt(TextBox tb)
        {
            int num; // auxillary for trying parse
            if (Int32.TryParse(tb.Text, out num))
            {
                return true;
            }
            else
            {
                // display decimal error message
                MessageBox.Show(tb.Tag + " has to be Integer value!", "input Error");
                tb.Focus();
                return false;
            }
        }

        // checks if text box is between minimum and maximum amount of allowed characters
        public static bool IsWithinLength(TextBox tb, int min, int max)
        {
            if(tb.Text.Length >= min && tb.Text.Length <= max)
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " must be within range: " + min + ".." + max + " number of characters", "input Error");
                return false;
            }
        }
    }
}
