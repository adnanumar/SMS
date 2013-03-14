using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMS.Model;
using SMS.DAL;
using SMS.Helper;
using System.Data;
using Telerik.Web.UI;

namespace SMS
{
    public partial class AddSchoolInfo : System.Web.UI.Page
    {
        SchoolInfo objSchoolInfo = new SchoolInfo();
        SchoolInfoManager objSchoolManager = new SchoolInfoManager();
        Lists objlist = new Lists();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Convert.ToString(Session["SchoolU_Id"])) && string.IsNullOrEmpty(Convert.ToString(Session["SchoolR_Id"])))
                {
                    Response.Redirect("Login.aspx");
                }
                else {

                    if (!IsPostBack) {

                        
                        objlist.Fill_Status(cmbxIsBoundaryWall);
                        objlist.Fill_Status(cmbxIsElectricity);
                        objlist.Fill_Status(cmbxIsMosque);
                        objlist.Fill_Status(cmbxIsPlayGround);
                        objlist.Fill_Status(cmbxIsSuiGas);
                        objlist.Fill_Status(cmbxIsTelephoneLine);
                        SchoolInfoById(Convert.ToInt32(Session["School_Id"]));
                    
                    }
                
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void SchoolInfoById(int school_Id) {

            DataTable objDt = new DataTable();
            objDt = objSchoolManager.SchoolInfo_GetAllByS_Id(school_Id);
            foreach(DataRow dr in objDt.Rows){

                txtbxHeadName.Text = dr["Head_Name"].ToString();
                txtbxHeadGrade.Text = dr["Head_Grade"].ToString(); 
                txtbxPhoneNo.Text = dr["Phone_No"].ToString();
                txtbxHeadCellNo.Text = dr["Head_CellNo"].ToString();
                txtbxUCNo.Text = dr["UC_No"].ToString();
                txtbxNANo.Text = dr["NA_No"].ToString();
                txtbxPPNo.Text = dr["PP_No"].ToString();
                txtbxClassRooms.Text = dr["No_ClassRoom"].ToString();
                txtbxRooms.Text = dr["No_Room"].ToString();
                txtbxDamagedRooms.Text = dr["Damage_Room"].ToString();
                txtbxScienceRooms.Text = dr["No_ScienceRoom"].ToString();
                txtbxComputerLabs.Text = dr["No_ComputerLab"].ToString();
                txtbxDesks.Text = dr["No_Desk"].ToString();
                txtbxBenchs.Text = dr["No_Bench"].ToString();
                txtbxChairs.Text = dr["No_Chair"].ToString();
                txtbxTables.Text = dr["No_Tables"].ToString();
                txtbxToilets.Text = dr["No_Toilet"].ToString();
                txtbxTeachingStaff.Text = dr["No_TStaff"].ToString();
                txtbxNonTeachingStaff.Text = dr["No_NonTStaff"].ToString();
                txtbxTotalArea.Text = dr["Total_Area"].ToString();
                txtbxCoveredArea.Text = dr["Covered_Area"].ToString();
                txtbxUnconstructedArea.Text = dr["UnconstructedBArea"].ToString();
                txtbxBoundaryArea.Text = dr["Boundry_Area"].ToString();
                txtbxGroundArea.Text = dr["Ground_Area"].ToString();

                if (dr["IsMosque"].ToString() == "False")
                {
                    RadComboBoxItem item = cmbxIsMosque.FindItemByText("No");
                    item.Selected = true;
                }
                else
                {
                    RadComboBoxItem item = cmbxIsMosque.FindItemByText("Yes");
                    item.Selected = true;
                }

                if (dr["IsPlayGround"].ToString() == "False")
                {
                    RadComboBoxItem item = cmbxIsPlayGround.FindItemByText("No");
                    item.Selected = true;
                }
                else
                {
                    RadComboBoxItem item = cmbxIsPlayGround.FindItemByText("Yes");
                    item.Selected = true;
                }

                if (dr["IsBoundaryWall"].ToString() == "False")
                {
                    RadComboBoxItem item = cmbxIsBoundaryWall.FindItemByText("No");
                    item.Selected = true;
                }
                else
                {
                    RadComboBoxItem item = cmbxIsBoundaryWall.FindItemByText("Yes");
                    item.Selected = true;
                }

                if (dr["IsElectricity"].ToString() == "False")
                {
                    RadComboBoxItem item = cmbxIsElectricity.FindItemByText("No");
                    item.Selected = true;

                }
                else
                {
                    RadComboBoxItem item = cmbxIsElectricity.FindItemByText("Yes");
                    item.Selected = true;
                }

                if (dr["IsTelephoneLine"].ToString() == "False")
                {
                    RadComboBoxItem item = cmbxIsTelephoneLine.FindItemByText("No");
                    item.Selected = true;
                }
                else
                {
                    RadComboBoxItem item = cmbxIsTelephoneLine.FindItemByText("Yes");
                    item.Selected = true;
                }

                if (Convert.ToBoolean(dr["IsSuiGas"]) == false)
                {
                    RadComboBoxItem item = cmbxIsSuiGas.FindItemByText("No");
                    item.Selected = true;
                }
                else
                {
                    RadComboBoxItem item = cmbxIsSuiGas.FindItemByText("Yes");
                    item.Selected = true;
                }
            
            }
        
        
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                objSchoolInfo.Head_Name = txtbxHeadName.Text;
                objSchoolInfo.Head_Grade =Convert.ToInt32(txtbxHeadGrade.Text);
                objSchoolInfo.Phone_No = txtbxPhoneNo.Text;
                objSchoolInfo.Head_CellNo = txtbxHeadCellNo.Text;
                objSchoolInfo.UC_No =Convert.ToInt32(txtbxUCNo.Text);
                objSchoolInfo.NA_No = Convert.ToInt32(txtbxNANo.Text);
                objSchoolInfo.PP_No = Convert.ToInt32(txtbxPPNo.Text);

                if (string.IsNullOrEmpty(txtbxClassRooms.Text))
                {

                    objSchoolInfo.No_ClassRoom = 0;
                
                }else{

                    objSchoolInfo.No_ClassRoom = Convert.ToInt32(txtbxClassRooms.Text);
                
                }

                if (string.IsNullOrEmpty(txtbxRooms.Text))
                {

                    objSchoolInfo.No_Room = 0;

                }
                else
                {

                    objSchoolInfo.No_Room = Convert.ToInt32(txtbxRooms.Text);

                }

                if (string.IsNullOrEmpty(txtbxDamagedRooms.Text))
                {

                    objSchoolInfo.Damage_Room = 0;

                }
                else
                {

                    objSchoolInfo.Damage_Room = Convert.ToInt32(txtbxDamagedRooms.Text);

                }
                if (string.IsNullOrEmpty(txtbxScienceRooms.Text))
                {

                    objSchoolInfo.No_ScienceRoom = 0;

                }
                else
                {

                    objSchoolInfo.No_ScienceRoom = Convert.ToInt32(txtbxScienceRooms.Text);

                }
                if (string.IsNullOrEmpty(txtbxComputerLabs.Text))
                {

                    objSchoolInfo.No_ComputerLab = 0;

                }
                else
                {

                    objSchoolInfo.No_ComputerLab = Convert.ToInt32(txtbxComputerLabs.Text);

                }

                if (string.IsNullOrEmpty(txtbxDesks.Text))
                {

                    objSchoolInfo.No_Desk = 0;

                }
                else
                {

                    objSchoolInfo.No_Desk = Convert.ToInt32(txtbxDesks.Text);

                }
                if (string.IsNullOrEmpty(txtbxBenchs.Text))
                {

                    objSchoolInfo.No_Bench = 0;

                }
                else
                {

                    objSchoolInfo.No_Bench = Convert.ToInt32(txtbxBenchs.Text);

                }
                if (string.IsNullOrEmpty(txtbxChairs.Text))
                {

                    objSchoolInfo.No_Chair = 0;

                }
                else
                {

                    objSchoolInfo.No_Chair = Convert.ToInt32(txtbxChairs.Text);

                }
                if (string.IsNullOrEmpty(txtbxTables.Text))
                {

                    objSchoolInfo.No_Tables = 0;

                }
                else
                {

                    objSchoolInfo.No_Tables = Convert.ToInt32(txtbxTables.Text);

                }
                if (string.IsNullOrEmpty(txtbxToilets.Text))
                {

                    objSchoolInfo.No_Toilet = 0;

                }
                else
                {

                    objSchoolInfo.No_Toilet = Convert.ToInt32(txtbxToilets.Text);

                }
                if (string.IsNullOrEmpty(txtbxTeachingStaff.Text))
                {

                    objSchoolInfo.No_TStaff = 0;

                }
                else
                {

                    objSchoolInfo.No_TStaff = Convert.ToInt32(txtbxTeachingStaff.Text);

                }
                if (string.IsNullOrEmpty(txtbxNonTeachingStaff.Text))
                {

                    objSchoolInfo.No_NonTStaff = 0;

                }
                else
                {

                    objSchoolInfo.No_NonTStaff = Convert.ToInt32(txtbxNonTeachingStaff.Text);

                }
                if (string.IsNullOrEmpty(txtbxBoundaryArea.Text))
                {

                    objSchoolInfo.Boundary_Area = "";

                }
                else
                {

                    objSchoolInfo.Boundary_Area = txtbxBoundaryArea.Text;

                }
                if (string.IsNullOrEmpty(txtbxTotalArea.Text))
                {

                    objSchoolInfo.Total_Area = "";

                }
                else
                {

                    objSchoolInfo.Total_Area = txtbxTotalArea.Text;

                }
                if (string.IsNullOrEmpty(txtbxCoveredArea.Text))
                {

                    objSchoolInfo.Covered_Area = "";

                }
                else
                {

                    objSchoolInfo.Covered_Area = txtbxCoveredArea.Text;

                }
                if (string.IsNullOrEmpty(txtbxUnconstructedArea.Text))
                {

                    objSchoolInfo.Underconstruction_Area = "";

                }
                else
                {

                    objSchoolInfo.Underconstruction_Area = txtbxUnconstructedArea.Text;

                }
                if (string.IsNullOrEmpty(txtbxBoundaryArea.Text))
                {

                    objSchoolInfo.Open_Area = "";

                }
                else
                {

                    objSchoolInfo.Open_Area = txtbxBoundaryArea.Text;

                }
                if (string.IsNullOrEmpty(txtbxGroundArea.Text))
                {

                    objSchoolInfo.Ground_Area = "";

                }
                else
                {

                    objSchoolInfo.Ground_Area = txtbxGroundArea.Text;

                }

                if (cmbxIsMosque.Text == "Yes")
                {
                    objSchoolInfo.Is_Mosque = true;
                
                }
                else{

                    objSchoolInfo.Is_Mosque = false;    
                
                }

                if (cmbxIsPlayGround.Text == "Yes")
                {
                    objSchoolInfo.IsPlayground = true;

                }
                else
                {

                    objSchoolInfo.IsPlayground = false;

                }

                if (cmbxIsBoundaryWall.Text == "Yes")
                {
                    objSchoolInfo.IsBoundaryWall = true;

                }
                else
                {

                    objSchoolInfo.IsBoundaryWall = false;

                }

                if (cmbxIsElectricity.Text == "Yes")
                {
                    objSchoolInfo.IsElectricity = true;

                }
                else
                {

                    objSchoolInfo.IsElectricity = false;

                }

                if (cmbxIsTelephoneLine.Text == "Yes")
                {
                    objSchoolInfo.IsTelephone = true;

                }
                else
                {

                    objSchoolInfo.IsTelephone = false;

                }

                if (cmbxIsSuiGas.Text == "Yes")
                {
                    objSchoolInfo.IsSuiGas = true;

                }
                else
                {

                    objSchoolInfo.IsSuiGas = false;

                }
                objSchoolInfo.School_Id = Convert.ToInt32(Session["School_Id"]);
                objSchoolManager.SchoolInfo_Update(objSchoolInfo);
                RadWindowManager1.RadAlert("School Information Updated Successfully! ", 330, 180, "Update School INFO", "alertCallBackFn");
               
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception"; 
            }
        }
    }
}