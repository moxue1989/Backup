using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mo_Xue_Lab_2
{
    /// <summary>
    /// Mo Xue
    /// ASP.NET Lab 2
    /// Party Voting
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {
        private DateTime Choice1, Choice2, Choice3;
        protected void Page_Load(object sender, EventArgs e)
        {
            // get the choices from Application on load
            Choice1 = (DateTime)Application["Choice1"];
            Choice2 = (DateTime)Application["Choice2"];
            Choice3 = (DateTime)Application["Choice3"];
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            // disable all dates except than the three chosen
            DateTime day = e.Day.Date;
            if (day != Choice1 && day != Choice2 && day != Choice3)
            {
                // Disable date selection
                e.Day.IsSelectable = false;
                // Change color of disabled date
                e.Cell.ForeColor = Color.DarkGray;
                e.Cell.BackColor = Color.Gray;
            }
        }

        protected void Calender_SelectionChanged(object sender, EventArgs e)
        {
            // display selected date
            lblDate.Text = "You picked: " + Calender.SelectedDate.ToString("D");
        }

        protected void btnVote_Click(object sender, EventArgs e)
        {   
            // get date picked from calender
            var selection = Calender.SelectedDate.Date;

            // update relevant application variable
            if (selection == Choice1)
            {
                Application["Result1"] = (int) Application["Result1"] + 1;
            }
            else if (selection == Choice2)
            {
                Application["Result2"] = (int) Application["Result2"] + 1;
            }
            else if (selection == Choice3)
            {
                Application["Result3"] = (int) Application["Result3"] + 1;
            }
            else
            {
                // show error message if no selection and return
                lblDate.Text = "Please select a valid date!";
                return;
            }
            // redirect to results page if voting successful
            Response.Redirect("Results.aspx");
        }
    }
}