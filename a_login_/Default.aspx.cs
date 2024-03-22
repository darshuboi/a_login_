using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace a_login_
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string pass = txtpass1.Text;

            Response.Redirect("dashboard.aspx?eml="+email+"&pass=" + pass);

        }
    }
}