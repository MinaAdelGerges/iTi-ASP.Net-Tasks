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
    public partial class editProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["user"] != null)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["itiuser"].ConnectionString);
                SqlCommand cmd = new SqlCommand("select d.Dept_Id,d.Dept_Name,d.Dept_Desc,d.Dept_Location,d.Dept_Manager,d.Manager_hiredate, u.user_Name,u.user_Age,u.user_Email,u.user_Gender from Department d , users u where d.Dept_Id=u.dept_Id and u.dept_Id=@id", con);
                cmd.Parameters.AddWithValue("id", Request.Cookies["user"].Values["Dept_Id"]);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                gv_edit.DataSource = dr;
                gv_edit.DataBind();
                con.Close();
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gv_edit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gv_edit_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}