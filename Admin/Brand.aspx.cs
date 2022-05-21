using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace LaptopStore.Admin
{
    public partial class Brand : System.Web.UI.Page
    {
        string connectionstring = WebConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }
        public void connection()
        {
            con = new SqlConnection(connectionstring);
            con.Open();
        }


        protected void btnsave_Click1(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            string insQry = "insert into tbl_brand(brand_name) values('" + txtname.Text + "')";

            cmd = new SqlCommand(insQry,con);
            cmd.ExecuteNonQuery();
        }
    }
}