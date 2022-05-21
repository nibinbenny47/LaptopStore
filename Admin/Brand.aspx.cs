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
        public static int id,status=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                fillGrid();
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

        protected void grdbrand_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            id = Convert.ToInt32(e.CommandArgument.ToString());
            con = new SqlConnection(connectionstring);
            con.Open();
            if (e.CommandName == "del")
            {
                string delQry = "delete from tbl_brand where brand_id='" + id + "'";
                SqlCommand cmd = new SqlCommand(delQry, con);
                cmd.ExecuteNonQuery();

            }
            //if (e.CommandName == "ed")
            //{
            //    string selQry = "select name from tbl_brand where brand_id='" + id + "'";
            //    SqlDataAdapter adp = new SqlDataAdapter(selQry,con);
            //    DataTable dt = new DataTable();
            //    adp.Fill(dt);
            //    if(dt.Rows.Count > 0)
            //    {
            //        txtname.Text = dt.Rows[0]["brand_name"].ToString();
            //        status = 1;
            //    }
            //}
            fillGrid();
        }

        public void fillGrid()
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            string selQry = "select brand_name from tbl_brand";
            SqlDataAdapter adp = new SqlDataAdapter(selQry,con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            grdbrand.DataSource = dt;
            grdbrand.DataBind();

            

        }
       
    }
}