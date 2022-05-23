using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Web.Configuration;
using System.Data.SqlClient;
namespace LaptopStore.Guest
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string connectionstring = WebConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            string selQry = "select * from tbl_user where user_username='" + txtusername.Text + "' and user_password='" + txtpassword.Text + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry,con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["uid"] = dt.Rows[0]["user_id"].ToString();
                Session["uname"] = dt.Rows[0]["user_name"].ToString();
                Response.Redirect("../User/Homepage.aspx");
            }
            else
            {
                Response.Write("<script>alert('invalid')</script>");
            }
            }
    }
}