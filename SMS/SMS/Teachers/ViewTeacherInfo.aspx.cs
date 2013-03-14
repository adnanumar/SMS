using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace SMS.Teachers
{
    public partial class ViewTeacherInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Convert.ToString(Session["SchoolU_Id"])) && string.IsNullOrEmpty(Convert.ToString(Session["SchoolR_Id"])))
                {
                    Response.Redirect("~/Login.aspx");
                }

            }
            catch (Exception ex)
            {

                //throw;
            }
        }

        protected void GVPersonalData_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            if (e.CommandName == "EditInfo")
            {

                GridDataItem dataItem = e.Item as GridDataItem;
                long cnic = Convert.ToInt64(dataItem["NIC"].Text);
                Response.Redirect("AddTeacherInfo.aspx?cnic=" + cnic);

            }
            else if (e.CommandName == "AddDetail")
            { 
            
                GridDataItem dataItem = e.Item as GridDataItem;
                long cnic = Convert.ToInt32(dataItem["NIC"].Text);
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
            GVPersonalData.ExportSettings.ExportOnlyData = true;
            GVPersonalData.ExportSettings.IgnorePaging = true;
            GVPersonalData.ExportSettings.OpenInNewWindow = true;
        }        
    }
}