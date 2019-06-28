using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace day2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

          
            if (Request.Cookies["user"] != null)
            {
                Session["name"] = Request.Cookies["user"].Values["name"];
                Response.Redirect("~/profile.aspx");
            }

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
           
                if (txt_name.Text == Session["name"].ToString() && txt_password.Text == Session["password"].ToString())
                {

                    if (chb_remeberme.Checked)
                    {

                        HttpCookie co = new HttpCookie("user");
                        co.Values.Add("name", txt_name.Text);
                        co.Values.Add("age", Session["age"].ToString());
                        co.Values.Add("email", Session["email"].ToString());
                        co.Values.Add("gender", Session["gender"].ToString());

                        co.Expires = DateTime.Now.AddDays(15);

                        Response.Cookies.Add(co);
                    }

                    Response.Redirect("~/profile.aspx");
                } 
            else
            {
                lbl_failed.Text = "Wrong username or password";
            };
        }
    }
}