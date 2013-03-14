using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMS.Helper;
using Telerik.Web.UI;
using SMS.DAL;
using SMS.Model;
using System.Data;

namespace SMS.Admin.Registration
{
    public partial class AddSchoolsInfo : System.Web.UI.Page
    {
        Lists objList = new Lists();
        SchoolInfo objInfo = new SchoolInfo();
        SchoolInfoManager objInfoManager = new SchoolInfoManager();
        string sid = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(Convert.ToString(Session["ApplicationU_Id"])) && string.IsNullOrEmpty(Convert.ToString(Session["ApplicationR_Id"])))
                {
                    Response.Redirect("~/AdminLogin.aspx");
                }
                else {

                    if(!IsPostBack){

                        objList.Fill_Dist(cmbxDistrict, Convert.ToInt32(Session["ApplicationD_Id"]));
                        objList.Fill_Tehsil(cmbxTehsil, Convert.ToInt32(Session["ApplicationD_Id"]));
                        objList.Fill_Level(cmbxLevel);
                        lblMessage.Text = string.Empty;

                        sid = Convert.ToString(Request.QueryString["sid"]);
                       
                        if (!string.IsNullOrEmpty(sid))
                        {

                            SchoolUsersInfoGetAllById(Convert.ToInt32(sid));

                        }
                        
                    
                    }

                    
                }

            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception...";
            }

        }
        private void SchoolUsersInfoGetAllById(int School_Id) {

            DataTable objDt = new DataTable();
            objDt = objInfoManager.SchoolUsersInfo_GetAllById(School_Id);
            foreach(DataRow dr in objDt.Rows){

                RadComboBoxItem item = new RadComboBoxItem();
                txtbxEmail.Text = dr["Email"].ToString();
                txtbxSchoolName.Text = dr["School_Name"].ToString();
                txtbxEMISCode.Text = dr["School_Code"].ToString();

                item = cmbxDistrict.FindItemByText(dr["D_Name"].ToString());
                item.Selected = true;

                item = cmbxTehsil.FindItemByText(dr["T_Name"].ToString());
                item.Selected = true;

                item = cmbxLevel.FindItemByText(dr["Level_Name"].ToString());
                item.Selected = true;

            }
        
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try {

                sid = Convert.ToString(Request.QueryString["sid"]);
                if (!string.IsNullOrEmpty(sid))
                {
                    objInfo.School_Id = Convert.ToInt32(Request.QueryString["sid"]);
                    objInfo.School_Name = txtbxSchoolName.Text.Trim();
                    objInfo.Email = txtbxEmail.Text.Trim();
                    objInfo.School_Code = Convert.ToString(txtbxEMISCode.Text.Trim());
                    string D_Name = cmbxDistrict.Text;
                    string T_Name = cmbxTehsil.Text;
                    string Level_Name = cmbxLevel.Text;
                    objInfoManager.SchoolUsersInfo_Update(objInfo, D_Name, T_Name, Level_Name);
                    lblMessage.Text = "School Info Updated Successfully!";
                    
                }
                else {

                    objInfo.School_Name = txtbxSchoolName.Text.Trim();
                    objInfo.Email = txtbxEmail.Text.Trim();
                    objInfo.School_Code = Convert.ToString(txtbxEMISCode.Text.Trim());
                    string D_Name = cmbxDistrict.Text;
                    string T_Name = cmbxTehsil.Text;
                    string Level_Name = cmbxLevel.Text;
                    objInfoManager.SchoolInfo_Add(objInfo, D_Name, T_Name, Level_Name);
                    lblMessage.Text = "School Info Added Successfully!";
                
                }
                
            }

            catch(Exception ex){

                lblMessage.Text = "Exception...";
            
            }
        }
    }
}