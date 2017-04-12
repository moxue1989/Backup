using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class frmProducts : Form
    {
        // storage of products
        List<Product> products = new List<Product>(); // creates an empty list object
        public frmProducts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // builds a product object with data from textboxes and adds to list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            //Product p = new Product(txtName.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtQty.Text));
            p.Name = txtName.Text;
            p.Price = Convert.ToDecimal(txtPrice.Text);
            p.Qty = Convert.ToInt32(txtQty.Text);
            products.Add(p);

            // call display function to list products
            DisplayProducts();

            // prepare for next entry
            txtName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtName.Focus();
        }

        // displays products from the list onto list box on form
        private void DisplayProducts()
        {
            lstProducts.Items.Clear();
            foreach(Product p in products)
            {
                lstProducts.Items.Add(p);
            }
        }

        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProductDB.Save(products);
        }
    }
}
