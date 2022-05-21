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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {

        }
    }
}