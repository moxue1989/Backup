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
    public partial class frmPowerBill : Form
    {
        // initialize default customer selection
        string custType = "R";

        // reads existing customer data from file or create one if does not exist
        List<Customer> customers = CustomerData.Read();

        public frmPowerBill()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // select usage text box and highlight residential customer upon start
            displayInput(custType);

            // display current list of customers on start
            DisplayCustomers();

            // display statistics on start
            DisplayStatistics();
        }

        // display statistics for all customers
        private void DisplayStatistics()
        {
            // initialize stat values for output
            int totalCust = 0;
            decimal residential = 0m, commercial = 0m, industrial = 0m;
            decimal total = 0m;

            // calculate total charge for each customer type
            foreach(Customer cust in customers)
            {
                switch (cust.Type)
                {
                    case "R":
                        residential += cust.Bill; 
                        break;
                    case "C":
                        commercial += cust.Bill;
                        break;
                    case "I":
                        industrial += cust.Bill;
                        break;
                    default:
                        break;
                }

                // calculate total number of customers and total charge
                totalCust++;                
            }

            total = residential + commercial + industrial;
            // output stats into textboxes
            txtResidential.Text = residential.ToString("c");
            txtCommercial.Text = commercial.ToString("c");
            txtIndustrial.Text = industrial.ToString("c");
            txtTotalCust.Text = totalCust.ToString();
            txtTotalCharge.Text = total.ToString("c");
        }

        // exit form and save customer data to file
        private void btnExit_Click(object sender, EventArgs e)
        {
            CustomerData.Save(customers);
            Close();
        }

        // clears text from all text boxes for next entry
        private void clear()
        {
            txtAct.Clear();
            txtName.Clear();
            txtBill.Clear();
            txtUsage.Clear();
            txtOffPeak.Clear();
            txtPeak.Clear();
        }

        // function to display correct input boxes based on customer type
        private void displayInput(string custType)
        {
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

                    // reset text boxes
                    clear();

                    // highlight relevant customer button
                    if (custType == "R")
                    {
                        btnResidential.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    else
                    {
                        btnCommercial.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    // focus on account number input text box
                    txtAct.Select();
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

                    // reset text boxes
                    clear();

                    // focus on account number input textbox
                    txtAct.Select();

                    // highlight industrial customer button
                    btnIndustrial.BackColor = System.Drawing.SystemColors.Highlight;
                    break;
            }
        }

        // calculate bill amount for each customer types on button click, save to customers list and display in listbox
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal amount = -1m; // initialize amount to display in bill output
            if (custType == "I")
            {
                // calculate and display bill for industrial customers
                amount = Calculator.calculateBill(txtAct, txtName, txtOffPeak, txtPeak, custType);
            }
            else
            {
                // calculate bill for residential and commercial customers
                amount = Calculator.calculateBill(txtAct, txtName, txtUsage, custType);
            }

            // add to customer list and output to screen if validation and calculation is successful
            if (amount >= 0)
            {
                // create new object in customer class
                int act = Convert.ToInt32(txtAct.Text);
                string name = txtName.Text;
                decimal bill = amount;
                Customer cust = new Customer(act, name, custType, bill);

                // displays bill to relevant text box
                txtBill.Text = amount.ToString("c2");

                // add new customer to customer list
                customers.Add(cust);

                // add current customer to list
                DisplayCustomers();

                // display statistics after addition
                DisplayStatistics();
            }
        }

        private void DisplayCustomers()
        {
            string listHeader = "Account Number:\tCustomer Name:\tCustomer Type:\tBill Amount:";
            lstCustomers.Items.Clear();
            lstCustomers.Items.Add(listHeader);
            foreach (Customer c in customers)
            {
                lstCustomers.Items.Add(c.ToString());
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
