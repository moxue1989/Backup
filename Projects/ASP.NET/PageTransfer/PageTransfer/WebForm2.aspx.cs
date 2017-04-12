using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageTransfer
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // can access page that control came from
            
            Page previous = Page.PreviousPage;
            if (previous != null)
            {
                TextBox prevPageName = (TextBox) PreviousPage.FindControl("tbName");
                if (prevPageName.Text == "")
                {
                    lblDesc.Text = "You didnt enter a name";
                }
                else
                {
                    lblName.Text = prevPageName.Text;
                }
            }
            else
            {
                Server.Transfer("~/WebForm1.aspx");
            }
        }

        protected void btnGoBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/WebForm1.aspx");
        }
    }
}