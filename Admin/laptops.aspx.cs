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
namespace LaptopStore.Admin
{
    public partial class laptops : System.Web.UI.Page
    {
        string connectionstring = WebConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                fillbrand();
            }
        }
        public void fillbrand()
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            string sel = "select * from tbl_brand";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sel, con);
            adp.Fill(dt);
            ddlbrand.DataSource = dt;
            ddlbrand.DataTextField = "brand_name";
            ddlbrand.DataValueField = "brand_id";
            ddlbrand.DataBind();
            ddlbrand.Items.Insert(0, "--select brand-");
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            string insQry = "insert into tbl_laptop (lap_name,brand_id) values('"+txtname.Text+"','"+ddlbrand.SelectedValue+"')";
            cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
        }
    }
}