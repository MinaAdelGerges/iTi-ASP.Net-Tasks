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
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["itiuser"].ConnectionString);
                SqlCommand cmd = new SqlCommand("select * from Department");
                cmd.Connection = con;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ddl_dept.DataSource = dr;
                ddl_dept.DataTextField = "dept_name";
                ddl_dept.DataValueField = "dept_id";
                ddl_dept.DataBind();
                con.Close();

            }
        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
          if (IsValid)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["itiuser"].ConnectionString);
                SqlCommand cmd = new SqlCommand("insert into users(user_Name ,user_Pass ,user_Age ,user_Gender ,user_Email,dept_id)values (@name ,@pass,@age,@gender,@email,@did)", con);
                cmd.Parameters.AddWithValue("name", txt_name.Text);
                cmd.Parameters.AddWithValue("pass", txt_pass.Text);
                cmd.Parameters.AddWithValue("age", txt_age.Text);
                cmd.Parameters.AddWithValue("email", txt_email.Text);
                cmd.Parameters.AddWithValue("gender", rbl_gender.Text);
                cmd.Parameters.AddWithValue("did", ddl_dept.SelectedValue);
                con.Open();
                int roweffect = cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("~/login.aspx");


            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }
    }
}