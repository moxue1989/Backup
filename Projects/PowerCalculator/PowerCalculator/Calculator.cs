using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerCalculator
{
    public static class Calculator
    {
        // declare constants for calculation
        const decimal RES_RATE = 0.052m; // residential usage rate
        const decimal RES_FLAT = 6m; // residential flat rate
        const decimal COM_RATE = 0.045m; // commercial usage rate
        const decimal COM_FLAT = 60m; // commercial flat rate
        const decimal IND_PEAK_RATE = 0.065m; // industrial peak usage rate
        const decimal IND_PEAK_FLAT = 76m; // industrial peak flat rate
        const decimal IND_OFFPEAK_RATE = 0.028m; // industrial off-peak usage rate
        const decimal IND_OFFPEAK_FLAT = 40m; // industrial off-peak falt rate
        const decimal FLAT_LIMIT = 1000m; // flat rate limit


        // overloaded function, this version takes two parameters for residential and commercial customers 
        public static decimal calculateBill(TextBox tbAct, TextBox tbName, TextBox tbUsage, string custType)
        {
            // initialize return value
            decimal bill = -1m;

            // validate residential and commercial input fields
            if (Validator.ActIsValid(tbAct) && Validator.NameIsValid(tbName) && Validator.IsValid(tbUsage))
            {
                decimal usage = Convert.ToDecimal(tbUsage.Text);
                if (custType == "R")
                {
                    // residential customer bill calculation
                    bill = Math.Max(0, usage) * RES_RATE + RES_FLAT;
                }
                else if (custType == "C")
                {
                    // commercial customer bill calculation
                    bill = Math.Max(0, (usage - FLAT_LIMIT)) * COM_RATE + COM_FLAT;
                }
            }
            return bill;
        }

        // overloaded function, this version takes three parameters for industrial customers
        public static decimal calculateBill(TextBox tbAct, TextBox tbName, TextBox tbOffPeak, TextBox tbPeak, string custType)
        {
            // initialize local variables for calculation
            decimal totalBill = -1m;
            decimal peakBill = 0m;
            decimal offPeakBill = 0m;

            if (Validator.ActIsValid(tbAct) && Validator.NameIsValid(tbName) && Validator.IsValid(tbOffPeak) && Validator.IsValid(tbPeak))
            {
                decimal offpeak = Convert.ToDecimal(tbOffPeak.Text);
                decimal peak = Convert.ToDecimal(tbPeak.Text);
                // industrial customer bill calculation
                offPeakBill = Math.Max(0, (offpeak - FLAT_LIMIT)) * IND_OFFPEAK_RATE + IND_OFFPEAK_FLAT;
                peakBill = Math.Max(0, (peak - FLAT_LIMIT)) * IND_PEAK_RATE + IND_PEAK_FLAT;
                totalBill = offPeakBill + peakBill;
            }
            return totalBill;
        }
    }
}
