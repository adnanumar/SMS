using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMS.Admin
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Convert.ToString(Session["ApplicationU_Id"])) && !string.IsNullOrEmpty(Convert.ToString(Session["ApplicationR_Id"])))
                {
                    btnLogin.Visible = false;
                    btnSignOut.Visible = true;
                }
                else {

                    btnLogin.Visible = true;
                    btnSignOut.Visible = false;
                
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
    }
}
