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
    public partial class disconnected : System.Web.UI.Page
    {
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["itiuser"].ConnectionString);
            //    SqlCommand cmdselect = new SqlCommand("select top_id as id ,top_name as name from topic", con);
            //    SqlDataAdapter adpt = new SqlDataAdapter();
            //    dt = new DataTable();

            //    adpt.SelectCommand = cmdselect;
            //    adpt.Fill(dt);

            //    ViewState.Add("data", dt);

            //    gv_topic.DataSource = dt;
            //    gv_topic.DataBind();

            //}
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            //dt = (DataTable)ViewState["data"];
            //DataRow dr = dt.NewRow();
            //dr["id"] = int.Parse(txt_id.Text);
            //dr["name"] = txt_name.Text;
            //dt.Rows.Add(dr);
            //ViewState["data"] = dt;

            //gv_topic.DataSource = dt;
            //gv_topic.DataBind();
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
            //SqlCommand cmd = new SqlCommand("insert into topic values(@id ,@name)", con);
            //cmd.Parameters.Add("id", SqlDbType.Int, 4, "id");
            //cmd.Parameters.Add("name", SqlDbType.NVarChar, 50, "name");


            ////SqlCommand cmddelete = new SqlCommand();

            //SqlDataAdapter adpt = new SqlDataAdapter();
            //adpt.InsertCommand = cmd;
            ////adpt.DeleteCommand = cmddelete;


            //dt = (DataTable)ViewState["data"];


            //adpt.Update(dt);
        }
    }
}