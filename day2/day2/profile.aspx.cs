using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace day2
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["count"].ToString() != null)
            {
                lbl_online.Text = "num of visitors=" + Application["count"].ToString();
            }
            if (Session["name"] != null)
            {
                lbl_name.Text = Session["name"].ToString();
                lbl_age.Text = Session["age"].ToString();
                lbl_email.Text = Session["email"].ToString();
                lbl_gender.Text = Session["gender"].ToString();

            }
            
           else if (Request.Cookies["user"].Values["name"]!=null)
            {
                lbl_name.Text = Request.Cookies["user"].Values["name"];
                lbl_age.Text = Request.Cookies["user"].Values["age"];
                lbl_email.Text = Request.Cookies["user"].Values["email"];
                lbl_gender.Text = Request.Cookies["user"].Values["gender"];
            }
 
            else
            {
                Response.Redirect("~/login.aspx");
            }
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            //Session["name"] = null;
            HttpCookie co = new HttpCookie("user");
            co.Expires = DateTime.Now.AddDays(-15);
            Response.Cookies.Add(co);

            Response.Redirect("~/login.aspx");

        }
    }
}