using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace SMS.Admin.School
{
    public partial class ViewSchoolInfo : System.Web.UI.Page
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

        protected void RGSchoolInfo_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            if (e.CommandName == "EditInfo")
            {

                GridDataItem dataItem = e.Item as GridDataItem;
                int schoolid = Convert.ToInt32(dataItem["School_Id"].Text);
                Response.Redirect("~/Registration/AddSchoolsInfo.aspx?sid=" + schoolid);

            }
            else if (e.CommandName == "ViewDetailInfo")
            {

                GridDataItem dataItem = e.Item as GridDataItem;
                int cnic = Convert.ToInt32(dataItem["NIC"].Text);
                Response.Redirect("AddDetailInfo.aspx?cnic=" + cnic);
            }
            if (e.CommandName == Telerik.Web.UI.RadGrid.ExportToExcelCommandName ||
                   e.CommandName == Telerik.Web.UI.RadGrid.ExportToWordCommandName ||
                   e.CommandName == Telerik.Web.UI.RadGrid.ExportToCsvCommandName)
            {
                ConfigureExport();
            }
        }

        public void ConfigureExport()
        {
            RGSchoolInfo.ExportSettings.ExportOnlyData = true;
            RGSchoolInfo.ExportSettings.IgnorePaging = true;
            RGSchoolInfo.ExportSettings.OpenInNewWindow = true;
        }        
    }
}