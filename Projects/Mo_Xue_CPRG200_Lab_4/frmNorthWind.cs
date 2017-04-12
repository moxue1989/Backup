using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mo_Xue_CPRG200_Lab_4
{
    /// <summary>
    /// Author: Mo Xue
    /// CPRG 200 C# Lab 4
    /// Northwind Database Orders/Order_Details
    /// Jan 9th 2017
    /// </summary>
    public partial class frmNorthWind : Form
    {
        // Initialize initial variables
        private List<Order> orders = null;
        private Order currentOrder = null;
        private int index = 0;
        public frmNorthWind()
        {
            InitializeComponent();
        }

        // Method to refresh orders list
        private void RefreshOrders()
        {
            try
            {
                // Load orders into orders list from database 
                orders = Database.GetOrders();
                // populate listbox from orders list
                lbOrders.Items.Clear();
                foreach (Order order in orders)
                {
                    lbOrders.Items.Add(order);
                }
                // Select first order or updated order
                lbOrders.SelectedIndex = index;
            }
            catch (Exception ex) // catch exception when loading data
            {
                MessageBox.Show("Error on loading Orders: " + ex.Message, ex.GetType().ToString());
            }
        }

        private void frmNorthWind_Load(object sender, EventArgs e)
        {
            RefreshOrders();
        }

        private void lbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Current selection and Order object
            index = lbOrders.SelectedIndex;
            currentOrder = orders[index];

            // update OrderDate and RequiredDate textboxes
            tbOrderDate.Text = currentOrder.OrderDate.ToString("d");
            tbRequiredDate.Text = currentOrder.RequiredDate.ToString("d");

            // initialize datetimepicker as ShippedDate if not null, otherwise initialize as RequiredDate so its easy to pick from
            dtpShippedDate.Value = currentOrder.ShippedDate ?? currentOrder.RequiredDate;

            // initialize ShippedDate textbox
            DisplayShippedDate();

            // load order details for selected Order from database into list
            try
            {
                List<Order_Detail> orderDetails = currentOrder.GetOrderDetails();

                // display list in datagridview
                dgvOrderDetails.DataSource = orderDetails;

                // calculate total order amount and display to textbox
                tbOrderTotal.Text = Calculator.CalculateTotal(orderDetails).ToString("c");
            }
            catch (Exception ex) // catch exception when loading data
            {
                MessageBox.Show("Error on loading Order Details: " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                btnUpdate.Enabled = false;
                // enable clear button only if shipped date is null
                if (currentOrder.ShippedDate != null)
                {
                    btnClearShippedDate.Enabled = true;
                }
                else
                {
                    btnClearShippedDate.Enabled = false;
                }
            }
        }

        // checks if shipped date is null and display its value
        private void DisplayShippedDate()
        {
            if (currentOrder.ShippedDate == null)
            {
                tbShippedDate.Text = "Not Assigned";
            }
            else
            {
                tbShippedDate.Text = currentOrder.ShippedDate?.ToString("d");
            }
        }

        // update shipped date to textbox upon selection
        private void dtpShippedDate_ValueChanged(object sender, EventArgs e)
        {   
            tbShippedDate.Text = dtpShippedDate.Value.ToString("d");
            btnUpdate.Enabled = true;
        }

        // Update Shipped Date for current order
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check to see if selected date is valid
            DateTime selectedDate = dtpShippedDate.Value;
            if (selectedDate < currentOrder.OrderDate)
            {
                MessageBox.Show("Shipped Date must be later than Order Date", "Input Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                DisplayShippedDate();
            }
            else if (selectedDate > currentOrder.RequiredDate)
            {
                MessageBox.Show("Shipped Date must be earlier than Required Date", "Input Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                DisplayShippedDate();
            }
            else
            {
                // update if new date is valid
                UpdateShippedDate();
            }
            // disable update button once operation is complete
            btnUpdate.Enabled = false;
        }

        private void UpdateShippedDate()
        {
            int updateResult = -1;
            try // try to update order shipped date
            {
                DateTime? oldShippedDate = currentOrder.ShippedDate;
                if (tbShippedDate.Text == "Not Assigned")
                {
                    currentOrder.ShippedDate = null;
                }
                else
                {
                    currentOrder.ShippedDate = dtpShippedDate.Value;
                }
                // call update method from database
                updateResult = Database.UpdateShippedDate(currentOrder, oldShippedDate);
            }
            catch (Exception ex) // catch exception when updating data
            {
                MessageBox.Show("Error on updating order: " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                switch (updateResult)
                {
                    case 1:
                        MessageBox.Show("Updated!", "Update Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 0:
                        MessageBox.Show("Concurrency Error! Order has been modified by another user", "Update Result",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -1:
                        MessageBox.Show("Update Failed", "Update Result",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("Something has gone terribly wrong! Check your database!", "Update Result",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
                // refresh order list after updating
                RefreshOrders();
            }
        }

        // button to clear shipped date
        private void btnClearShippedDate_Click(object sender, EventArgs e)
        {
            tbShippedDate.Text = "Not Assigned";
            btnUpdate.Enabled = true;
            btnClearShippedDate.Enabled = false;
        }
    }
}
