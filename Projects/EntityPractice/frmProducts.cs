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
    public partial class frmProducts : Form
    {
        private TravelExpertsEntities db;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            db=new TravelExpertsEntities();
            productBindingSource.DataSource = db.Products.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmProductDetails frm = new frmProductDetails(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    productBindingSource.DataSource = db.Products.ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (productBindingSource.Current == null)
                return;
            using (frmProductDetails frm = new frmProductDetails(productBindingSource.Current as Product))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    productBindingSource.DataSource = db.Products.ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (productBindingSource.Current != null)
            {
                if (MessageBox.Show("are you sure?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    db.Products.Remove(productBindingSource.Current as Product);
                    //productBindingSource.RemoveCurrent();
                    
                    db.SaveChanges();
                    productBindingSource.DataSource = db.Products.ToList();
                }
            }
        }
    }
}
