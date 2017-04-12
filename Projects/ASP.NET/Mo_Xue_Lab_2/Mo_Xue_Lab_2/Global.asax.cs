using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Mo_Xue_Lab_2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // add application DateTime objects
            Application.Add("Choice1", new DateTime(2017, 1, 2));
            Application.Add("Choice2", new DateTime(2017, 1, 15));
            Application.Add("Choice3", new DateTime(2017, 1, 28));

            // add application result objects
            Application.Add("Result1", 0);
            Application.Add("Result2", 0);
            Application.Add("Result3", 0);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}