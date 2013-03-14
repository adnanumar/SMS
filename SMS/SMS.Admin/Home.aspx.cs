using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using SMS.DAL;

namespace SMS.Admin
{
    public partial class Home : System.Web.UI.Page
    {       

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Convert.ToString(Session["ApplicationU_Id"])) && string.IsNullOrEmpty( Convert.ToString(Session["ApplicationR_Id"])))
                {
                    Response.Redirect("~/AdminLogin.aspx");
                }
                
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
       
    }
}