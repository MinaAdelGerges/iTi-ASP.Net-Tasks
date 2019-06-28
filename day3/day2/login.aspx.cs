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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            //if (Request.Cookies["user"] != null)
            //{
            //    Session["Dept_Id"] = Request.Cookies["user"].Values["Dept_Id"];
            //    Response.Redirect("~/profile.aspx");
            //}

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["itiuser"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select dept_Id from users where user_Name=@name and user_Pass=@pass", con);
            cmd.Parameters.AddWithValue("name", txt_name.Text);
            cmd.Parameters.AddWithValue("pass", txt_password.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                Session.Add("Dept_Id", dr["dept_Id"]);

                if (chb_remeberme.Checked)
                {
                    //define obj
                    HttpCookie co = new HttpCookie("user");
                    //add values
                    co.Values.Add("dept_Id", dr["dept_Id"].ToString());

                    co.Expires = DateTime.Now.AddDays(15);
                    
                    Response.Cookies.Add(co);

                }

                Response.Redirect("~/profile.aspx");

            }
            else
            {
                lbl_failed.Text = "invalid username or password";

            }

            con.Close();
        }
    }
}