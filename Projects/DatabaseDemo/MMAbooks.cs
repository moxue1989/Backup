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

namespace DatabaseDemo
{
    public partial class MMABooks : Form
    {
        public MMABooks()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Another user has changed the data you are trying to change");
                this.productsTableAdapter1.Fill(this.mMABooksDataSet1.Products);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Number.ToString() + ex.GetType() + "\n" + ex.Message);
            }
        }

        private void MMABooks_Load(object sender, EventArgs e)
        {
            try
            {
                // loads from database table Products in the dataset
                // TODO: This line of code loads data into the 'mMABooksDataSet1.Products' table. You can move, or remove it, as needed.
                this.productsTableAdapter1.Fill(this.mMABooksDataSet1.Products);
                // TODO: This line of code loads data into the 'mMABooksDataSet.Products' table. You can move, or remove it, as needed.
                this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Number.ToString() + ex.GetType() + "\n" + ex.Message);
            }
        }

        // data error handler within grid view
        private void productsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int row = e.RowIndex + 1; // row number in human count
            int column = e.ColumnIndex; // column number
            string colName = mMABooksDataSet1.Products.Columns[column].ColumnName;
            MessageBox.Show("Error in data grid:" + "\n" +
                            "Row: " + row + "\n" +
                            "Column: " + colName);
        }
    }
}
