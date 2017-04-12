using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mo_Xue_ASP_Lab_1
{
    /// <summary>
    /// Mo Xue
    /// ASP.NET lab 1 
    /// January 12, 2017
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            // calculate output
            decimal input = Convert.ToDecimal(tbInput.Text);
            decimal output = 0m;

            // calculation for Celsius
            if (ddlFrom.Text == "Celsius")
            {
                switch (ddlTo.Text)
                {
                    case "Farenheit":
                        output = (input*9/5) + 32;
                        break;
                    case "Kelvin":
                        output = input + 273.15m;
                        break;
                    default:
                        output = input;
                        break;
                }
            }
            // calculation for Farenheit
            else if (ddlFrom.Text == "Farenheit")
            {
                switch (ddlTo.Text)
                {
                    case "Celsius":
                        output = (input - 32)*5/9;
                        break;
                    case "Kelvin":
                        output = (input - 32)*5/9 + 273.15m;
                        break;
                    default:
                        output = input;
                        break;
                }
            }
            // calculation for Kelvin
            else if (ddlFrom.Text == "Kelvin")
            {
                switch (ddlTo.Text)
                {
                    case "Celsius":
                        output = input - 273.15m;
                        break;
                    case "Farenheit":
                        output = (input - 273.15m)*9/5 + 32m;
                        break;
                    default:
                        output = input;
                        break;
                }
            }

            // output in label
            lblOutput.Text = output.ToString("F");
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            // clear textbox and label and reset drop down lists
            ddlFrom.SelectedIndex = 0;
            ddlTo.SelectedIndex = 0;
            tbInput.Text = "";
            lblOutput.Text = "";
        }

        protected void ddlFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // alter range validator properties based on selection
            double min = 10;
            switch (ddlFrom.Text)
            {
                case "Celsius":
                    min = -273.15;
                    break;
                case "Farenheit":
                    min = -459.67;
                    break;
                case "Kelvin":
                    min = 0;
                    break;
            }

            // change minimum value and display text
            RangeValidator.MinimumValue = min.ToString();
            RangeValidator.Text = "Must be within Range " + min + " and 1000";
            RangeValidator.Validate();
        }
    }
}