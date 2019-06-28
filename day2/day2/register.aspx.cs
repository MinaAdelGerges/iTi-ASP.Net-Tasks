using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace day2
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Session.Add("name", txt_name.Text);
                Session.Add("age", txt_age.Text);
                Session.Add("password", txt_pass.Text);
                Session.Add("email", txt_email.Text);
                Session.Add("gender", rbl_gender.Text);
                Response.Redirect("~/login.aspx");
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }
    }
}