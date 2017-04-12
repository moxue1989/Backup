using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // for TextBox

namespace Mo_Xue_CPRG200_LAB3
{
    /// <summary>
    /// Validator class for checking products fields before saving
    /// </summary>
    public static class Validator
    {
        // checks if number text box is valid
        public static bool IsValid(TextBox tb)
        {
            return (IsPresent(tb) && IsDecimal(tb));
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

        // checks if checkbox is valid
        public static bool IsPresent(CheckBox cb)
        {
            if (cb.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show(cb.Tag + " is required!", "input Error");
                cb.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        // check if combo box is empty
        public static bool IsPresent(ComboBox cb)
        {
            if (cb.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(cb.Tag + " is required!", "input Error");
                cb.Focus();
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
