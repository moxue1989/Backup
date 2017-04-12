using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerInheritance
{
    public partial class frmCustomers : Form
    {
        List<Customer> CustomerList = CustomerDB.LoadCustomers();
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            foreach(Customer customer in CustomerList)
            {
                lbCustomers.Items.Add(customer.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerDB.SaveCustomers(CustomerList);
        }
    }
}
