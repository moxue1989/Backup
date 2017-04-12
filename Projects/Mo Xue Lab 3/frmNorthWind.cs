using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mo_Xue_Lab_3
{
    public partial class frmNorthWind : Form
    {
        public frmNorthWind()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            // catch database exceptions
            try
            {
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.nORTHWNDDataSet);
            }
            catch (DBConcurrencyException)
            {
                // Refresh data table on concurrency
                MessageBox.Show("Another user has changed the data you are trying to change");
                this.order_DetailsTableAdapter.Fill(this.nORTHWNDDataSet.Order_Details);
                this.categoriesTableAdapter.Fill(this.nORTHWNDDataSet.Categories);
                this.suppliersTableAdapter.Fill(this.nORTHWNDDataSet.Suppliers);
                this.productsTableAdapter.Fill(this.nORTHWNDDataSet.Products);
            }
            catch (SqlException ex)
            {
                // Show SQL exception error
                MessageBox.Show("Database Error: " + ex.Number.ToString() + ex.GetType() + "\n" + ex.Message);
            }
            catch (Exception ex)
            {
                // Show general Errors
                MessageBox.Show("Error: " + ex.Message, ex.GetType().ToString());
            }
        }

        private void frmNorthWind_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'nORTHWNDDataSet.Order_Details' table. You can move, or remove it, as needed.
                this.order_DetailsTableAdapter.Fill(this.nORTHWNDDataSet.Order_Details);
                // TODO: This line of code loads data into the 'nORTHWNDDataSet.Categories' table. You can move, or remove it, as needed.
                this.categoriesTableAdapter.Fill(this.nORTHWNDDataSet.Categories);
                // TODO: This line of code loads data into the 'nORTHWNDDataSet.Suppliers' table. You can move, or remove it, as needed.
                this.suppliersTableAdapter.Fill(this.nORTHWNDDataSet.Suppliers);
                // TODO: This line of code loads data into the 'nORTHWNDDataSet.Products' table. You can move, or remove it, as needed.
                this.productsTableAdapter.Fill(this.nORTHWNDDataSet.Products);

                // Disable checks for dataset to throw exception in SQL 
                nORTHWNDDataSet.Products.ProductNameColumn.AllowDBNull = true;
                nORTHWNDDataSet.Products.SupplierIDColumn.AllowDBNull = true;
                nORTHWNDDataSet.Products.CategoryIDColumn.AllowDBNull = true;
                nORTHWNDDataSet.Products.QuantityPerUnitColumn.AllowDBNull = true;
                nORTHWNDDataSet.Products.UnitPriceColumn.AllowDBNull = true;
                nORTHWNDDataSet.Products.UnitsInStockColumn.AllowDBNull = true;
                nORTHWNDDataSet.Products.UnitsOnOrderColumn.AllowDBNull = true;
                nORTHWNDDataSet.Products.ReorderLevelColumn.AllowDBNull = true;
                nORTHWNDDataSet.Products.DiscontinuedColumn.AllowDBNull = true;
            }
            catch (SqlException ex)
            {
                // Show SQL exception
                MessageBox.Show("Database Error: " + ex.Number.ToString() + ex.GetType() + "\n" + ex.Message);
            }
        }
    }
}
