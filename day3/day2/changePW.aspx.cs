using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace day2
{
    public partial class changePW : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if(Request.Cookies["user"] == null)
            {
                Response.Redirect("~/login.aspx");
            }
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (IsValid) { 
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["itiuser"].ConnectionString);
            SqlCommand cmd = new SqlCommand("UPDATE users SET user_Pass = @Pass where user_Pass=@oldPass",con);
           
                cmd.Parameters.AddWithValue("Pass", txt_confirm.Text);
                cmd.Parameters.AddWithValue("oldPass", txt_old.Text);

                con.Open();
                int roweffect = cmd.ExecuteNonQuery();
                con.Close();
                lbl_save.Text = "New Password Saved Correctly!";
            }
           
        }
    }
}