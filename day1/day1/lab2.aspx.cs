using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace day1
{
    public partial class lab2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddl_currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_currency.SelectedIndex==1)
            {
                Label1.Text = txt_value.Text + " Egyptian Pounds = "+ (float.Parse(txt_value.Text)/21.5)+" Euro";
                Label2.Text = txt_value.Text + " Euro = " + (float.Parse(txt_value.Text) * 21.5) + " Egyptian Pounds";
            }
            else if (ddl_currency.SelectedIndex == 2)
            {
                Label1.Text = txt_value.Text + " Egyptian Pounds = " + (float.Parse(txt_value.Text) / 17.5) + " Dollar";
                Label2.Text = txt_value.Text + " Dollar = " + (float.Parse(txt_value.Text) * 17.5) + " Egyptain Pounds";


            }
        }
    }
}