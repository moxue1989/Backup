using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private int count;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["count"] == null)
            {
                ViewState["count"] = count;
            }
            count = (int)ViewState["count"];
            txtClicks.Text = count.ToString();
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            count++;
            txtClicks.Text = count.ToString();
            ViewState["count"] = count;
        }
    }
}