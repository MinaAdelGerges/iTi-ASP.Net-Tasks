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
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                 if (Request.Cookies["user"] != null)
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["itiuser"].ConnectionString);
                    SqlCommand cmd = new SqlCommand("select d.Dept_Id as dept,d.Dept_Name,d.Dept_Desc,d.Dept_Location,d.Dept_Manager,d.Manager_hiredate, u.user_Name,u.user_Age,u.user_Email,u.user_Gender from Department d , users u where d.Dept_Id=u.dept_Id and u.dept_Id=@id", con);
                    cmd.Parameters.AddWithValue("id", Request.Cookies["user"].Values["Dept_Id"]);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    gv_profile.DataSource = dr;
                    gv_profile.DataBind();
                    con.Close();
                }
                else
                {
                    Response.Redirect("~/login.aspx");
                }


            }
            // if (application["count"].tostring() != null)
            // {
            //     lbl_online.text = "num of visitors=" + application["count"].tostring();
            // }
            // if (Session["name"] != null)
            // {
            //     lbl_name.Text = Session["name"].ToString();
            //     lbl_age.Text = Session["age"].ToString();
            //     lbl_email.Text = Session["email"].ToString();
            //     lbl_gender.Text = Session["gender"].ToString();

            // }



           
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            //Session["name"] = null;
            HttpCookie co = new HttpCookie("user");
            co.Expires = DateTime.Now.AddDays(-15);
            Response.Cookies.Add(co);

            Response.Redirect("~/login.aspx");

        }

        protected void btn_change_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/changePw.aspx");
            //if (Request.Cookies["Dept_Id"] != null)
            //{
            //    Session["Dept_Id"] = Request.Cookies["user"].Values["Dept_Id"];
            //    Response.Redirect("~/changePw.aspx");
            //}

            //else{
            //    Response.Redirect("~/login.aspx");
            //}

        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/editProfile.aspx");
        }
    }
}