using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMS.Admin.Staff
{
    public partial class ViewEmployeesInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Convert.ToString(Session["ApplicationU_Id"])) && string.IsNullOrEmpty(Convert.ToString(Session["ApplicationR_Id"])))
                {
                    Response.Redirect("~/AdminLogin.aspx");
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        protected void GVPersonalData_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            if (e.CommandName == Telerik.Web.UI.RadGrid.ExportToExcelCommandName ||
                           e.CommandName == Telerik.Web.UI.RadGrid.ExportToWordCommandName ||
                           e.CommandName == Telerik.Web.UI.RadGrid.ExportToCsvCommandName)
            {
                ConfigureExport();
            }
        }

        public void ConfigureExport()
        {
            GVPersonalData.ExportSettings.ExportOnlyData = true;
            GVPersonalData.ExportSettings.IgnorePaging = true;
            GVPersonalData.ExportSettings.OpenInNewWindow = true;
        }        
    }
}