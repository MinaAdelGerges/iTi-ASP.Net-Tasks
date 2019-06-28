using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace day1
{
    public partial class lab1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //year
                int year = DateTime.Now.Year;
                for (int i = year-5 ; i <= year+5 ; i++)
                {
                    ListItem li = new ListItem(i.ToString());
                    ddl_year.Items.Add(li);
                }
                
                //month
                //int month = DateTime.Now.Month;
                for (int i = 1 ; i <= 30; i++)
                {
                    ListItem li3 = new ListItem(i.ToString());
                    ddl_month.Items.Add(li3);
                }
         
                //day
                //int day = DateTime.Now.Day;
                for (int i = 1; i <= 30; i++)
                {
                    ListItem li2 = new ListItem(i.ToString());
                    ddl_day.Items.Add(li2);
                }
                

            }
        }

        protected void btn_send1_Click(object sender, EventArgs e)
        {
            //querystring
            Response.Redirect("~/labb1.aspx?name=" + txt_name.Text + "&year=" + ddl_year.Text + "&month=" + ddl_month.Text + "&day=" + ddl_day.Text);
        }

        protected void ddl_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btn_send2_Click(object sender, EventArgs e)
        {

        }

        protected void btn_send3_Click(object sender, EventArgs e)
        {
            Session["name"] = txt_name.Text;
            Session["year"] = ddl_year.Text;
            Session["month"] = ddl_month.Text;
            Session["day"] = ddl_day.Text;
            Response.Redirect("~/labb1.aspx");
        }
    }
}