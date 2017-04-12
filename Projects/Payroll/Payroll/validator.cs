using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // for TextBox

namespace Payroll
{
    public static class Validator
    {
        // checks if text box is empty
        public static bool IsPresent(TextBox tb)
        {
            if(tb.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " is required", "input Error");
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
                MessageBox.Show(tb.Tag + " must be within range: " + min + ".." + max, "input Error");
                tb.Focus();
                return false;
            }
        }

    }
}
