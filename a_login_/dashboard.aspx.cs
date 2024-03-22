using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace a_login_
{
    public partial class dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        
        {
            string email1 = Request.QueryString["eml"];
            string pass1 = Request.QueryString["pass"];


            if(email1 == null || pass1 == null)
            {

                Response.Redirect("Default.aspx");

            }
            else
            {
                email.Text = email1;
                pass.Text = pass1;
            }
        }
    }
}