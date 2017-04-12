    /*  
    *   Application: Power calculator
    *   Explaination: Calculates power bill based on type of customer and electricity usage
    *   additional options for industrial customers
    *   Author: Mo Xue
    *   Date: Nov 22, 2016  
    */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerCalculator
{   
    public partial class Form1 : Form
    {
        // declare constant and flat rates for calculation
        string custType = "R";
        const decimal RES_RATE = 0.052m; // residential usage rate
        const decimal RES_FLAT = 6m; // residential flat rate
        const decimal COM_RATE = 0.045m; // commercial usage rate
        const decimal COM_FLAT = 60m; // commercial flat rate
        const decimal IND_PEAK_RATE = 0.065m; // industrial peak usage rate
        const decimal IND_PEAK_FLAT = 76m; // industrial peak flat rate
        const decimal IND_OFFPEAK_RATE = 0.028m; // industrial off-peak usage rate
        const decimal IND_OFFPEAK_FLAT = 40m; // industrial off-peak falt rate
        const decimal FLAT_LIMIT = 1000m; // flat rate limit
        const decimal MAX_USAGE = 1000000; // max power usage limit
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // select usage text box and highlight residential customer upon start
            txtUsage.Text = "";
            txtUsage.Select();
            btnResidential.BackColor = System.Drawing.SystemColors.Highlight;
        }

        // exit form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // function to display correct input boxes based on customer type
        private void displayInput(string custType) 
        {
            //btnCommercial.BackColor = System.Drawing.SystemColors.Control;
            //btnResidential.BackColor = System.Drawing.SystemColors.Control;
            //btnIndustrial.BackColor = System.Drawing.SystemColors.Control;

            // Reset color styles for buttons
            btnResidential.UseVisualStyleBackColor = true;
            btnCommercial.UseVisualStyleBackColor = true;
            btnIndustrial.UseVisualStyleBackColor = true;

            switch (custType)
            {
                case "R":
                case "C":
                    // show normal usage label and text box
                    lblUsage.Visible = true;
                    txtUsage.Visible = true;

                    // hide industrial usage label and text box
                    lblOffPeak.Visible = false;
                    txtOffPeak.Visible = false;
                    lblPeak.Visible = false;
                    txtPeak.Visible = false;

                    // reset usage and bill text box
                    txtBill.Text = "";
                    txtUsage.Text = "";

                    // highlight relevant customer button
                    if(custType == "R")
                    {
                        btnResidential.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    else
                    {
                        btnCommercial.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    // focus on usage input text box
                    txtUsage.Select();
                    break;

                case "I":
                    // hide normal usage label and text box
                    lblUsage.Visible = false;
                    txtUsage.Visible = false;

                    // show industrial usage label and text box
                    lblOffPeak.Visible = true;
                    txtOffPeak.Visible = true;
                    lblPeak.Visible = true;
                    txtPeak.Visible = true;

                    // reset peak, offpeak and bill text box
                    txtBill.Text = "";
                    txtOffPeak.Text = "";
                    txtPeak.Text = "";
                    // focus on industrial input textbox
                    txtOffPeak.Select();

                    // highlight industrial customer button
                    btnIndustrial.BackColor = System.Drawing.SystemColors.Highlight;
                    break;
            }
        }

        // overloaded function, this version takes two parameters for residential and commercial customers 
        private decimal calculateBill(string custType, decimal usage)
        {
            // initialize return value
            decimal bill = 0m; 
            if(custType == "R") 
            {
                // residential customer bill calculation
                bill = Math.Max(0, usage) * RES_RATE + RES_FLAT;
            }
            else if(custType == "C")
            {
                // commercial customer bill calculation
                bill = Math.Max(0, (usage - FLAT_LIMIT)) * COM_RATE + COM_FLAT; 
            }
            return bill;
        }

        // overloaded function, this version takes three parameters for industrial customers
        private decimal calculateBill(string custType, decimal offpeak, decimal peak)
        {
            // initialize local variables for calculation
            decimal totalBill = 0m;
            decimal peakBill = 0m;
            decimal offPeakBill = 0m;

            if(custType == "I")
            {
                // industrial customer bill calculation
                offPeakBill = Math.Max(0, (offpeak - FLAT_LIMIT)) * IND_OFFPEAK_RATE + IND_OFFPEAK_FLAT;
                peakBill = Math.Max(0, (peak - FLAT_LIMIT)) * IND_PEAK_RATE + IND_PEAK_FLAT;
                totalBill = offPeakBill + peakBill;
            }
            return totalBill;
        }

        // calculate bill amount for all customer types on button click
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal amount = 0m; // initialize amount to display in bill output
            if(custType == "I")
            {
                // validate indutrial input fields
                if (Validator.IsValid(txtOffPeak, MAX_USAGE) && Validator.IsValid(txtPeak, MAX_USAGE))
                {
                    decimal offpeak = Convert.ToDecimal(txtOffPeak.Text);
                    decimal peak = Convert.ToDecimal(txtPeak.Text);
                    // calculate and display bill for industrial customers
                    amount = calculateBill(custType, offpeak, peak);
                    txtBill.Text = amount.ToString("c2");
                }
            }
            else 
            {
                // validate residential and commercial input fields
                if (Validator.IsValid(txtUsage, MAX_USAGE))
                {
                    decimal usage = Convert.ToDecimal(txtUsage.Text);
                    // calculate bill for residential and commercial customers
                    amount = calculateBill(custType, usage);
                    txtBill.Text = amount.ToString("c2");
                }
            }            
        }

        // Switch to residential calculation
        private void btnResidential_Click(object sender, EventArgs e)
        {            
            custType = "R";
            displayInput(custType);
        }

        // switch to commercial calculation
        private void btnCommercial_Click(object sender, EventArgs e)
        {            
            custType = "C";
            displayInput(custType);
        }

        // switch to industrial calculation
        private void btnIndustrial_Click(object sender, EventArgs e)
        {            
            custType = "I";
            displayInput(custType);
        }

        // reset form back to residential calculation mode
        private void btnReset_Click(object sender, EventArgs e)
        {            
            custType = "R";
            displayInput(custType);
        }
    }
}
