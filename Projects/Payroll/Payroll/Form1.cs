using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Form1 : Form
    {
        const decimal FULL_WEEK = 37.5m; // full week for straight pay
        const decimal OT_RATE = 1.5m; // time and a half for overtime
        const decimal MIN_HOURS = 0m; // minimum hours per week
        const decimal MAX_HOURS = 80m; // maximum hours per week
        const decimal MIN_RATE = 15m; // minimum pay per hour
        const decimal MAX_RATE = 1000m; // maximum pay per hour

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal hours, rate, pay;

            if (IsValidData())
            {
                hours = Convert.ToDecimal(txtHours.Text);
                rate = Convert.ToDecimal(txtRate.Text);
                pay = CalculatePay(hours, rate);
                txtPay.Text = pay.ToString("c"); // display to currency
                SoundPlayer player = new SoundPlayer("../../images/coins.wav");
                player.Play();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtHours) && Validator.IsDecimal(txtHours) && Validator.IsWithinRange(txtHours, MIN_HOURS, MAX_HOURS) && Validator.IsPresent(txtRate) && Validator.IsDecimal(txtRate) && Validator.IsWithinRange(txtRate, MIN_RATE, MAX_RATE);
        }

        private decimal CalculatePay(decimal hours, decimal rate)
        {
            decimal pay;
            if (hours < FULL_WEEK)
            {
                pay = hours * rate;
            }
            else
            {
                pay = ((hours - FULL_WEEK) * OT_RATE + FULL_WEEK) * rate;
            }

            return pay;
        }
    }
}
