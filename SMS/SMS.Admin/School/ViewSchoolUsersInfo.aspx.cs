using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using SMS.DAL;
using SMS.Model;

namespace SMS.Admin.School
{
    public partial class ViewSchoolUsersInfo : System.Web.UI.Page
    {
        private string gridMessage = null;

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

        protected void RGSchoolInfo_UpdateCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            try
            {
                GridEditableItem item = e.Item as GridEditableItem;
                Users objUsers = new Users();
                SchoolInfoManager objSchoolInfo = new SchoolInfoManager();

                objUsers.U_Id = Convert.ToInt32(((TextBox)item["U_Id"].Controls[0]).Text);
                objUsers.Password = ((TextBox)item["User_Password"].Controls[0]).Text;
                RadComboBox combo = (RadComboBox)item.FindControl("cmbxStatus");

                if (combo.Text == "Active")
                {

                    objUsers.IsActive = true;

                }
                else
                {

                    objUsers.IsActive = false;

                }
                objSchoolInfo.SchoolUserStatus_Update(objUsers);
                SetMessage("User Info Updated Successfully!");
            }
            catch(Exception ex){
            
                SetMessage("User Status Update : Exception!");

            }
        }
        private void DisplayMessage(string text)
        {
            RGSchoolInfo.Controls.Add(new LiteralControl(string.Format("<span style='color:red'>{0}</span>", text)));
        }

        private void SetMessage(string message)
        {
            gridMessage = message;
        }

        protected void RGSchoolInfo_DataBound(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gridMessage))
            {
                DisplayMessage(gridMessage);
            }
        }

        protected void RGSchoolInfo_ItemCommand(object sender, GridCommandEventArgs e)
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
            RGSchoolInfo.ExportSettings.ExportOnlyData = true;
            RGSchoolInfo.ExportSettings.IgnorePaging = true;
            RGSchoolInfo.ExportSettings.OpenInNewWindow = true;
        }    

      
    }
}