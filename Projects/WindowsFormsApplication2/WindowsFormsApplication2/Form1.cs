using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal toMetric(decimal feet, decimal inches)
        {
            return (feet * 12 + inches) * 2.54m;
        }
        private void toImperial(decimal centimeters, out decimal feet, out decimal inches)
        {
            decimal totalInches = centimeters / 2.54m;
            feet = (int)(totalInches / 12m);
            inches = (int)Math.Round(totalInches % 12m);
        }

        private void btnToMetric_Click(object sender, EventArgs e)
        {
            decimal feet = Convert.ToDecimal(txtFeet.Text);
            decimal inches = Convert.ToDecimal(txtInches.Text);
            decimal centimeters = toMetric(feet, inches);
            txtCentimeters.Text = centimeters.ToString("f");
        }

        private void btnToImperial_Click(object sender, EventArgs e)
        {
            decimal feet, inches;
            decimal centimeters = Convert.ToDecimal(txtCentimeters.Text);
            toImperial(centimeters, out feet, out inches);
            txtFeet.Text = feet.ToString();
            txtInches.Text = inches.ToString();
        }
    }
}
