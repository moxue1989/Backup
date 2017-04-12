using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mo_Xue_Lab_2
{
    public partial class Results : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // get date choices from application result
            lblChoice1.Text = ((DateTime)Application["Choice1"]).ToString("D");
            lblChoice2.Text = ((DateTime)Application["Choice2"]).ToString("D");
            lblChoice3.Text = ((DateTime)Application["Choice3"]).ToString("D");

            // update results in textboxes
            tbResult1.Text = Application["Result1"].ToString();
            tbResult2.Text = Application["Result2"].ToString();
            tbResult3.Text = Application["Result3"].ToString();
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            // return to default page
            Response.Redirect("Default.aspx");
        }
    }
}