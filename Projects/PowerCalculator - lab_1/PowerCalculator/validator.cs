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
        // calls all validate methods on input textbox
        public static bool IsValid(TextBox tb, decimal max_usage)
        {
            if (IsPresent(tb) && IsDecimal(tb) && IsWithinRange(tb, 0, max_usage))
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

    }
}
