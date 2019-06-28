using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace day2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application.Add("count", 0);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            int c = int.Parse(Application["count"].ToString());

            c++;

            Application["count"] = c;

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
            int c2 = int.Parse(Application["count"].ToString());

            c2--;

            Application["count"] = c2;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}