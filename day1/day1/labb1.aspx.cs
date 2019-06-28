using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace day1
{
    public partial class labb1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //querystring
            lb1.Text = Request.QueryString["name"];
            lb2.Text = Request.QueryString["year"] + " years," + Request.QueryString["month"] + " months," + Request.QueryString["day"] + " days";
            //postbackurl
            //lb1.Text = ((TextBox)PreviousPage.FindControl("txt_name")).Text;
            //lb2.Text = (((DropDownList)PreviousPage.FindControl("ddl_year")).Text) +" years,"+ (((DropDownList)PreviousPage.FindControl("ddl_month")).Text) +" months,"+ (((DropDownList)PreviousPage.FindControl("ddl_day")).Text+" days");
            //session
            //lb1.Text = Session["name"].ToString();
            //lb2.Text = Session["year"].ToString() + " years," + Session["month"].ToString() + " months," + Session["day"].ToString() + " days";

        }
    }
}