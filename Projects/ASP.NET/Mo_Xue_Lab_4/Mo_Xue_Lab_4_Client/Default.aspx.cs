using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mo_Xue_Lab_4_Client
{
    public partial class Default : System.Web.UI.Page
    {
        // service proxy
        TechSupportServiceReference.TechSupportServiceClient proxy = new TechSupportServiceReference.TechSupportServiceClient();

        // service objects
        private List<TechSupportServiceReference.Customer> customers;
        private List<TechSupportServiceReference.Technician> technicians;
        private List<TechSupportServiceReference.Incident> incidents;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        void LoadData()
        {
            // load customer and technician names into drop down lists
            customers = proxy.GetAllCustomers().ToList();
            ddlCustomer.DataSource = customers;
            ddlCustomer.DataTextField = "Name";
            ddlCustomer.DataValueField = "CustomerID";
            ddlCustomer.DataBind();

            technicians = proxy.GetAllTechnicians().ToList();
            ddlTech.DataSource = technicians;
            ddlTech.DataTextField = "Name";
            ddlTech.DataValueField = "TechID";
            ddlTech.DataBind();
        }

        protected void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // on index change, display relevant incident data for customer selection
            int CustomerID = Convert.ToInt32(ddlCustomer.SelectedValue);
            incidents = proxy.GetIncidentsByCustomer(CustomerID).ToList();
            DisplayIncidents();
        }

        private void DisplayIncidents()
        {
            // display incidents for selection
            if (incidents.Count == 0)
            {
                lblIncidents.Text = "You have no Incidents";
            }
            else
            {
                lblIncidents.Text = "";
            }

            gvIncidents.DataSource = incidents;
            gvIncidents.DataBind();

        }

        protected void ddlTech_SelectedIndexChanged(object sender, EventArgs e)
        {
            // on index change, display relevant incident data for technician selection
            int TechID = Convert.ToInt32(ddlTech.SelectedValue);
            incidents = proxy.GetOpenTechIncidents(TechID).ToList();
            DisplayIncidents();
        }
    }
}