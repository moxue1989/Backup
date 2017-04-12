using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_Calculator
{
    public partial class Form1 : Form
    {
        const decimal BASE1 = 0;
        const decimal BASE2 = 2250;
        const decimal BASE3 = 5400;
        const decimal BASE4 = 11000;
        const decimal BASE5 = 21600;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal salary = Convert.ToDecimal(txtSalary.Text);
            decimal tax, netIncome;
            
            if(salary < 15000)
            {
                tax = BASE1 + salary * 0.15m;               
            } else if (salary <30000)
            {
                tax = BASE2 + (salary - 15000) * 0.18m;             
            } else if (salary < 50000)
            {
                tax = BASE3 + (salary - 30000) * 0.22m;              
            } else if (salary < 80000)
            {
                tax = BASE4 + (salary - 50000) * 0.27m;
            } else
            {
                tax = BASE5 + (salary - 80000) * 0.33m;
            }

            netIncome = salary - tax;

            txtTax.Text = tax.ToString("c");
            txtIncome.Text = netIncome.ToString("c");
        }
    }
}
