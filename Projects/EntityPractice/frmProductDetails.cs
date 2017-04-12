using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityPractice
{
    public partial class frmProductDetails : Form
    {
        private TravelExpertsEntities db;
        public frmProductDetails(Product obj)
        {
            InitializeComponent();
            db= new TravelExpertsEntities();
            if (obj == null)
            {
                productBindingSource.DataSource = new Product();
                db.Products.Add(productBindingSource.Current as Product);
            }
            else
            {
                productBindingSource.DataSource = obj;
                db.Products.Attach(productBindingSource.Current as Product);
            }
        }

        private void frmProductDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtProductName.Text))
                {
                    MessageBox.Show("Please enter a Product Name", "Input Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtProductName.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
