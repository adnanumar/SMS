using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMS.Model;
using SMS.DAL;

namespace SMS.Teachers
{
    public partial class AddDetailInfo : System.Web.UI.Page
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

        protected void btnAddAcademics_Click(object sender, EventArgs e)
        {
            try
            {
                Academic_Data objAcademics = new Academic_Data();
                TeachersDetailInfoManager objAcademicsManager = new TeachersDetailInfoManager();

                //objAcademics.Board_University = txtbxBoardUniversity.Text;
                //objAcademics.Roll_Reg_No = txtbxRollNoRegNo.Text;
                //objAcademics.Passing_Year = Convert.ToDateTime(DatePickerPassingYear.SelectedDate);
                //objAcademics.Grade_Division = txtbxGradeDivision.Text;
                //objAcademics.Regular_Private = cmbxRegularPrivate.Text;
                //objAcademics.Degree_Title = txtbxDegreeTitle.Text;
                //objAcademics.Major_Subjects = txtbxMajorSubjects.Text;
                ////objAcademics.NIC = 

                //objAcademicsManager.AcademicsData_Insert(objAcademics);

            }
            catch (Exception ex)
            {
                
                //throw;
            }
        }

        protected void btnUpdateAcademics_Click(object sender, EventArgs e)
        {
            try
            {
                Academic_Data objAcademics = new Academic_Data();
                TeachersDetailInfoManager objAcademicsManager = new TeachersDetailInfoManager();
                ////objAcademics.Acd_Id = 
                //objAcademics.Board_University = txtbxBoardUniversity.Text;
                //objAcademics.Roll_Reg_No = txtbxRollNoRegNo.Text;
                //objAcademics.Passing_Year = Convert.ToDateTime(DatePickerPassingYear.SelectedDate);
                //objAcademics.Grade_Division = txtbxGradeDivision.Text;
                //objAcademics.Regular_Private = cmbxRegularPrivate.Text;
                //objAcademics.Degree_Title = txtbxDegreeTitle.Text;
                //objAcademics.Major_Subjects = txtbxMajorSubjects.Text;
                

                //objAcademicsManager.AcademicsData_Update(objAcademics);

            }
            catch (Exception ex)
            {

                //throw;
            }
        }

        protected void btnAddPromotion_Click(object sender, EventArgs e)
        {
            try
            {
                Promotions objPromotions = new Promotions();
                TeachersDetailInfoManager objPromoManager = new TeachersDetailInfoManager();

                ////objPromotions.NIC = 
                //objPromotions.Promo_TypeId = 0;
                //objPromotions.Promotion_Date = Convert.ToDateTime(DatePickerPromotionDate.SelectedDate);
                //objPromotions.FromScale = txtbxFromScale.Text;
                //objPromotions.ToScale = txtbxToScale.Text;
                //objPromotions.FromSchool = txtbxFromSchool.Text;
                //objPromotions.ToSchool = txtbxToSchool.Text;
                //string PromoType = cmbxPromotionType.Text;

                //objPromoManager.Promotions_Insert(objPromotions, PromoType);
            }
            catch (Exception ex)
            {
                
                //throw;
            }
            
        }

        protected void btnUpdatePromotions_Click(object sender, EventArgs e)
        {
            try
            {
                Promotions objPromotions = new Promotions();
                TeachersDetailInfoManager objPromoManager = new TeachersDetailInfoManager();

                ////objPromotions.Promotion_Id = 
                //objPromotions.Promo_TypeId = 0;
                //objPromotions.Promotion_Date = Convert.ToDateTime(DatePickerPromotionDate.SelectedDate);
                //objPromotions.FromScale = txtbxFromScale.Text;
                //objPromotions.ToScale = txtbxToScale.Text;
                //objPromotions.FromSchool = txtbxFromSchool.Text;
                //objPromotions.ToSchool = txtbxToSchool.Text;
                //string PromoType = cmbxPromotionType.Text;

                //objPromoManager.Promotions_Insert(objPromotions, PromoType);
            }
            catch (Exception ex)
            {

                //throw;
            }
        }

        protected void btnAddTransfers_Click(object sender, EventArgs e)
        {
            try
            {
                Transfers objTransfers = new Transfers();
                TeachersDetailInfoManager objTransManager = new TeachersDetailInfoManager();

                //objTransfers.School_Id = Convert.ToInt32(Session["SchoolSchool_Id"]);
                //objTransfers.Order_Date = Convert.ToDateTime(DatePickerOrderDate.SelectedDate);
                //objTransfers.Transf_Order_No = txtbxTransferOrderNo.Text;
                //objTransfers.Total_Period = txtbxTotalPeriod.Text;
                //objTransfers.Transfer_Date = Convert.ToDateTime(DatePickerTransferDate.SelectedDate);
                //objTransfers.Releiving_Date_PrevJob = Convert.ToDateTime(DatePickerReleivingPrevJob.SelectedDate);
                //objTransfers.Joining_Date = Convert.ToDateTime(DatePickerJoiningDate.SelectedDate);
                //objTransfers.T_Id = Convert.ToInt32(Session["SchoolT_Id"]);
                //objTransfers.D_Id = Convert.ToInt32(Session["SchoolD_Id"]);
                //objTransfers.To_Transfer = txtbxTransferTo.Text;
                //objTransfers.From_Transfer = txtbxTransferFrom.Text;
                ////objTransfers.NIC = 

                //objTransManager.Transfers_Insert(objTransfers);
            }
            catch (Exception ex)
            {
                
                //throw;
            }
        }

        protected void btnUpdateTransfers_Click(object sender, EventArgs e)
        {
            try
            {
                Transfers objTransfers = new Transfers();
                TeachersDetailInfoManager objTransManager = new TeachersDetailInfoManager();

                ////objTransfers.Trf_Id = 
                //objTransfers.School_Id = Convert.ToInt32(Session["SchoolSchool_Id"]);
                //objTransfers.Order_Date = Convert.ToDateTime(DatePickerOrderDate.SelectedDate);
                //objTransfers.Transf_Order_No = txtbxTransferOrderNo.Text;
                //objTransfers.Total_Period = txtbxTotalPeriod.Text;
                //objTransfers.Transfer_Date = Convert.ToDateTime(DatePickerTransferDate.SelectedDate);
                //objTransfers.Releiving_Date_PrevJob = Convert.ToDateTime(DatePickerReleivingPrevJob.SelectedDate);
                //objTransfers.Joining_Date = Convert.ToDateTime(DatePickerJoiningDate.SelectedDate);
                //objTransfers.T_Id = Convert.ToInt32(Session["SchoolT_Id"]);
                //objTransfers.D_Id = Convert.ToInt32(Session["SchoolD_Id"]);
                //objTransfers.To_Transfer = txtbxTransferTo.Text;
                //objTransfers.From_Transfer = txtbxTransferFrom.Text;

                //objTransManager.Transfers_Update(objTransfers);

            }
            catch (Exception ex)
            {

                //throw;
            }
        }

        protected void btnAddAccountInfo_Click(object sender, EventArgs e)
        {
            try
            {
                AccountInfos objAccountInfos = new AccountInfos();
                TeachersDetailInfoManager objAcctManager = new TeachersDetailInfoManager();

                //objAccountInfos.Account_Type = txtbxAccountType.Text;
                //objAccountInfos.Account_No = txtbxAccountNo.Text;
                //objAccountInfos.Gross_Salary = Convert.ToDouble(txtbxGrossSalary.Text);
                //objAccountInfos.Net_Salary = Convert.ToDouble(txtbxNetSalary.Text);
                //objAccountInfos.School_Id = Convert.ToInt32(Session["SchoolSchool_Id"]);
                //objAccountInfos.Bank_Name = txtbxBankName.Text;
                ////objAccountInfos.NIC = 
                
                //objAcctManager.AccountInfo_Insert(objAccountInfos);
            }
            catch (Exception ex)
            {
                
                //throw;
            }
        }

        protected void btnUpdateAccountInfo_Click(object sender, EventArgs e)
        {
            try
            {
                AccountInfos objAccountInfos = new AccountInfos();
                TeachersDetailInfoManager objAcctManager = new TeachersDetailInfoManager();

                //objAccountInfos.Act_Id =
                //objAccountInfos.Account_Type = txtbxAccountType.Text;
                //objAccountInfos.Account_No = txtbxAccountNo.Text;
                //objAccountInfos.Gross_Salary = Convert.ToDouble(txtbxGrossSalary.Text);
                //objAccountInfos.Net_Salary = Convert.ToDouble(txtbxNetSalary.Text);
                //objAccountInfos.School_Id = Convert.ToInt32(Session["SchoolSchool_Id"]);
                //objAccountInfos.Bank_Name = txtbxBankName.Text;
                                
                //objAcctManager.AccountInfo_Update(objAccountInfos);
            }
            catch (Exception ex)
            {
                
                //throw;
            }
        }

        protected void btnAddExperiences_Click(object sender, EventArgs e)
        {
            try 
	        {
                Experiences objExperiences = new Experiences();
                TeachersDetailInfoManager objExpManager = new TeachersDetailInfoManager();

                //objExperiences.School_Id = Convert.ToInt32(Session["SchoolSchool_Id"]);
                //objExperiences.To_Date = Convert.ToDateTime(DatePickerToDateExperience.SelectedDate);
                //objExperiences.From_Date = Convert.ToDateTime(DatePickerFromDateExperience.SelectedDate);
                //objExperiences.Department = txtbxDepartment.Text;
                //objExperiences.Resposibilities = txtbxResponsibilities.Text;
                //objExperiences.Designation = txtbxDesignation.Text;
                //objExperiences.Organization_Name = txtbxOrganizationName.Text;
                ////objExperiences.NIC = 

                //objExpManager.Experiences_Insert(objExperiences);
		
	        }
	        catch (Exception ex)
	        {
		
		        //throw;
	        }
            
        }

        protected void btnUpdateExperiences_Click(object sender, EventArgs e)
        {
            try 
	        {
                Experiences objExperiences = new Experiences();
                TeachersDetailInfoManager objExpManager = new TeachersDetailInfoManager();

                //objExperiences.Exp_Id = 
                //objExperiences.School_Id = Convert.ToInt32(Session["SchoolSchool_Id"]);
                //objExperiences.To_Date = Convert.ToDateTime(DatePickerToDateExperience.SelectedDate);
                //objExperiences.From_Date = Convert.ToDateTime(DatePickerFromDateExperience.SelectedDate);
                //objExperiences.Department = txtbxDepartment.Text;
                //objExperiences.Resposibilities = txtbxResponsibilities.Text;
                //objExperiences.Designation = txtbxDesignation.Text;
                //objExperiences.Organization_Name = txtbxOrganizationName.Text;
                

                //objExpManager.Experiences_Update(objExperiences);
		
	        }
	        catch (Exception ex)
	        {
		
		        //throw;
	        }
        }

       
        
    }
}