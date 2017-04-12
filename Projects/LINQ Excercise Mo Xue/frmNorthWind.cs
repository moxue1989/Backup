using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using LINQ_Practice.NORTHWNDDataSetTableAdapters;

namespace LINQ_Practice
{
    public partial class frmNorthWind : Form
    {
        CustomersTableAdapter customersTableAdapter = new CustomersTableAdapter();
        OrdersTableAdapter ordersTableAdapter = new OrdersTableAdapter();
        NORTHWNDDataSet dataset = new NORTHWNDDataSet();
        public frmNorthWind()
        {
            InitializeComponent();
        }

        private void frmNorthWind_Load(object sender, EventArgs e)
        {
            customersTableAdapter.Fill(dataset.Customers);
            ordersTableAdapter.Fill(dataset.Orders);

            cbCustomer.DataSource = dataset.Customers;
            cbCustomer.DisplayMember = dataset.Customers.CustomerIDColumn.ToString();
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbCustomer.SelectedIndex;

            string custId = dataset.Customers[index].CustomerID;

            var CustomerDetails = from customer in dataset.Customers
                                  where customer.CustomerID == custId
                                  select new
                                  { customer.CustomerID, customer.CompanyName, customer.ContactName, customer.Address, customer.ContactTitle,customer.City,
                       Region = customer.IsRegionNull() ? "Null" : customer.Region,
                       customer.PostalCode, customer.Country, customer.Phone,
                       Fax = customer.IsFaxNull() ? "Null" : customer.Fax };


            var Orders = from customer in dataset.Customers
                join order in dataset.Orders
                on customer.CustomerID equals order.CustomerID
                where customer.CustomerID == custId
                orderby customer.CustomerID
                select new
                {
                    order.OrderID,
                    order.EmployeeID,
                    order.OrderDate,
                    order.RequiredDate,
                    ShippedDate = order.IsShippedDateNull() ? "Null" : order.ShippedDate.ToString("d"),
                    order.ShipVia,
                    order.Freight,
                    order.ShipName,
                    order.ShipAddress,
                    order.ShipCity,
                    ShipRegion = order.IsShipRegionNull() ? "Null" : order.ShipRegion,
                    ShipPostalCode = order.IsShipPostalCodeNull()? "Null" : order.ShipPostalCode,
                    order.ShipCountry
                };

            dgvOrders.DataSource = Orders.ToList();

            foreach (var detail in CustomerDetails)
            {
                tbCompanyName.Text = detail.CompanyName;
                tbContactName.Text = detail.ContactName;
                tbContactTitle.Text = detail.ContactTitle;
                tbAddress.Text = detail.Address;
                tbCity.Text = detail.City;
         
                tbRegion.Text = detail.Region;
           
                tbPostalCode.Text = detail.PostalCode;
                tbCountry.Text = detail.Country;
                tbPhone.Text = detail.Phone;
                tbFax.Text = detail.Fax;
            }

        }
    }
}
