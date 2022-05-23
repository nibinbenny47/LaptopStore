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
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionstring = WebConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            string pic = Path.GetFileName(fileimage.PostedFile.FileName.ToString());
            fileimage.SaveAs(Server.MapPath("../images/" + pic));
            string insQry = "insert into tbl_user (user_name,user_email,user_gender,user_photo,user_username,user_password)values('" + txtname.Text + "','" + txtemail.Text + "','" + rdbgender.SelectedValue + "','" + pic + "','" + txtusername.Text + "','" + txtpassword.Text + "')";
            cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
        }
    }
}