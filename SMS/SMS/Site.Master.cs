using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMS
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(Session["SchoolU_Id"])) && !string.IsNullOrEmpty(Convert.ToString(Session["SchoolR_Id"])))
            {
                btnLogin.Visible = false;
                btnSignOut.Visible = true;
                lblHeader.Text = Session["School_Name"].ToString();
            }
            else 
            {

                btnLogin.Visible = true;
                btnSignOut.Visible = false;
                lblHeader.Text = string.Empty;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
            lblHeader.Text = string.Empty;
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/Login.aspx");
            lblHeader.Text = string.Empty;
        }
    }
}
