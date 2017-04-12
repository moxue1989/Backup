using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseToXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);

        }

        private void btnWriteXML_Click(object sender, EventArgs e)
        {
            // products data is in the dataset mMABooksDataSet
            // in the products table
            try
            {
                mMABooksDataSet.WriteXml("Products.xml", XmlWriteMode.IgnoreSchema);
                MessageBox.Show("Written Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            mMABooksDataSet.ReadXml("Products.xml");
            dgvProducts.DataSource = productsBindingSource;
        }
    }
}
