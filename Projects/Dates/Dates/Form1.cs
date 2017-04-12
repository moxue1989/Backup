using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dates
{
    public partial class Form1 : Form
    {
        private object lblMessage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // display current date
            DateTime today = DateTime.Now;
            lblToday.Text = today.ToLongDateString();
            lblTime.Text = today.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // update date and time
            DateTime today = DateTime.Now;
            lblToday.Text = today.ToLongDateString();
            lblTime.Text = today.ToLongTimeString();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DateTime birthday = dtPicker.Value.Date;
            //lblBirthday.Text = "Your birthday is: " + birthday.ToLongDateString();
            DateTime today = DateTime.Today;
            TimeSpan ts = birthday.Subtract(today);
            lblBirthday.Text = ts.Days.ToString();
        }
    }
}
