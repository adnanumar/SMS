using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS.Model;
using System.Data;

namespace SMS.DAL
{
   public class TeachersDetailInfoManager
    {
       public void TeachersPersonalInfo_Insert(PersonalData objPData) 
       {
           DBAccess objDb = new DBAccess();

           objDb.AddParameter("@NIC",objPData.NIC);
           objDb.AddParameter("@Employee_Name",objPData.Employee_Name);
           objDb.AddParameter("@Father_Name",objPData.Father_Name);
           objDb.AddParameter("@Perm_Address",objPData.Perm_Address);
           objDb.AddParameter("@Current_Address",objPData.Current_Address);
           objDb.AddParameter("@Designation",objPData.Designation);
           objDb.AddParameter("@Grade",objPData.Grade);
           objDb.AddParameter("@Email",objPData.Email);
           objDb.AddParameter("@Cell_No",objPData.Cell_No);
           objDb.AddParameter("@Office_No",objPData.Office_No);
           objDb.AddParameter("@Residence_No",objPData.Residence_No);
           objDb.AddParameter("@Personal_No",objPData.Personal_No);
           objDb.AddParameter("@Domicile",objPData.Domicile);
           objDb.AddParameter("@GBF_No",objPData.GBF_No);
           objDb.AddParameter("@Qualification",objPData.Qualification);
         //  objDb.AddParameter("@Picture",objPData.Picture);
           objDb.AddParameter("@DateOfBirth",objPData.DateOfBirth);
           objDb.AddParameter("@Gender",objPData.Gender);
           objDb.AddParameter("@Joining_Date",objPData.Joining_Date);
           objDb.AddParameter("@JoiningAsPerm_Date",objPData.JoiningAsPerm_Date);
           objDb.AddParameter("@JoiningPresSta_Date",objPData.JoiningPresSta_Date);
           objDb.AddParameter("@Contract_Permanent",objPData.Contract_Permanent);
           objDb.AddParameter("@School_Id",objPData.School_Id);
           objDb.AddParameter("@IsTeachingStaff", objPData.IsTeachingStaff);
           objDb.ExecuteNonQuery("PersonalData_Insert");


       }
       public void TeachersPersonalInfo_Update(PersonalData objPData)
       {
           DBAccess objDb = new DBAccess();

           objDb.AddParameter("@NIC", objPData.NIC);
           objDb.AddParameter("@Employee_Name", objPData.Employee_Name);
           objDb.AddParameter("@Father_Name", objPData.Father_Name);
           objDb.AddParameter("@Perm_Address", objPData.Perm_Address);
           objDb.AddParameter("@Current_Address", objPData.Current_Address);
           objDb.AddParameter("@Designation", objPData.Designation);
           objDb.AddParameter("@Grade", objPData.Grade);
           objDb.AddParameter("@Email", objPData.Email);
           objDb.AddParameter("@Cell_No", objPData.Cell_No);
           objDb.AddParameter("@Office_No", objPData.Office_No);
           objDb.AddParameter("@Residence_No", objPData.Residence_No);
           objDb.AddParameter("@Personal_No", objPData.Personal_No);
           objDb.AddParameter("@Domicile", objPData.Domicile);
           objDb.AddParameter("@GBF_No", objPData.GBF_No);
           objDb.AddParameter("@Qualification", objPData.Qualification);
         //  objDb.AddParameter("@Picture", objPData.Picture);
           objDb.AddParameter("@DateOfBirth", objPData.DateOfBirth);
           objDb.AddParameter("@Gender", objPData.Gender);
           objDb.AddParameter("@Joining_Date", objPData.Joining_Date);
           objDb.AddParameter("@JoiningAsPerm_Date", objPData.JoiningAsPerm_Date);
           objDb.AddParameter("@JoiningPresSta_Date", objPData.JoiningPresSta_Date);
           objDb.AddParameter("@Contract_Permanent", objPData.Contract_Permanent);
           objDb.AddParameter("@School_Id", objPData.School_Id);
           objDb.AddParameter("@IsTeachingStaff", objPData.IsTeachingStaff);
           objDb.ExecuteNonQuery("PersonalData_Update");


       }
       public DataTable PersonalData_GetByAllByS_Id(int schoolid) 
       {
           DBAccess objDb = new DBAccess();
           objDb.AddParameter("@SchoolId",schoolid);
           return objDb.ExecuteDataTable("PersonalData_GetBySchoolId");
       }
       public DataTable PersonalData_GetAllByD_Id(int D_Id) 
       {
           DBAccess objDb = new DBAccess();
           objDb.AddParameter("@D_Id", D_Id);
           return objDb.ExecuteDataTable("PersonalData_GetAllByD_Id");
       }
       
       public DataTable PersonalData_GetAllByNIC(long NIC)
       {
           DBAccess objDb = new DBAccess();
           objDb.AddParameter("@NIC", NIC);
           return objDb.ExecuteDataTable("PersoanlData_GetAllByNIC");
       }
       public void AcademicsData_Insert(Academic_Data objAcademics) 
       {
           DBAccess objDb = new DBAccess();
           objDb.AddParameter("@NIC",objAcademics.NIC);
           objDb.AddParameter("@Board_University",objAcademics.Board_University);
           objDb.AddParameter("@Roll_Reg_No",objAcademics.Roll_Reg_No);
           objDb.AddParameter("@Passing_Year",objAcademics.Passing_Year);
           objDb.AddParameter("@Grade_Division",objAcademics.Grade_Division);
           objDb.AddParameter("@Regular_Private",objAcademics.Regular_Private);
           objDb.AddParameter("@Degree_Title",objAcademics.Degree_Title);
           objDb.AddParameter("@Major_Subjects",objAcademics.Major_Subjects);
           objDb.AddParameter("@School_Id", objAcademics.School_Id);

           objDb.ExecuteNonQuery("AcademicsInfo_Insert");

       }
       public void AcademicsData_Update(Academic_Data objAcademics)
       {
           DBAccess objDb = new DBAccess();
           objDb.AddParameter("@Acd_Id", objAcademics.Acd_Id);           
           objDb.AddParameter("@Board_University", objAcademics.Board_University);
           objDb.AddParameter("@Roll_Reg_No", objAcademics.Roll_Reg_No);
           objDb.AddParameter("@Passing_Year", objAcademics.Passing_Year);
           objDb.AddParameter("@Grade_Division", objAcademics.Grade_Division);
           objDb.AddParameter("@Regular_Private", objAcademics.Regular_Private);
           objDb.AddParameter("@Degree_Title", objAcademics.Degree_Title);
           objDb.AddParameter("@Major_Subjects", objAcademics.Major_Subjects);
           objDb.AddParameter("@School_Id", objAcademics.School_Id);

           objDb.ExecuteNonQuery("AcademicsInfo_Insert");

       }
       public void Promotions_Insert(Promotions objPromo, string Promotype) 
       {
           DBAccess objDb = new DBAccess();

           objDb.AddParameter("@FromScale",objPromo.FromScale);
           objDb.AddParameter("@ToScale",objPromo.ToScale);
           objDb.AddParameter("@Promo_TypeId",0);
           objDb.AddParameter("@Promo_Type",Promotype);
           objDb.AddParameter("@NIC",objPromo.NIC);
           objDb.AddParameter("@FromSchool",objPromo.FromSchool);
           objDb.AddParameter("@ToSchool",objPromo.ToSchool);
           objDb.AddParameter("@Promotion_Date", objPromo.Promotion_Date);

           objDb.ExecuteNonQuery("Promotions_Insert");
       }
       public void Promotions_Update(Promotions objPromo, string Promotype)
       {
           DBAccess objDb = new DBAccess();

           objDb.AddParameter("@Promotion_Id", objPromo.Promotion_Id);
           objDb.AddParameter("@FromScale", objPromo.FromScale);
           objDb.AddParameter("@ToScale", objPromo.ToScale);
           objDb.AddParameter("@Promo_TypeId", 0);
           objDb.AddParameter("@Promo_Type", Promotype);           
           objDb.AddParameter("@FromSchool", objPromo.FromSchool);
           objDb.AddParameter("@ToSchool", objPromo.ToSchool);
           objDb.AddParameter("@Promotion_Date", objPromo.Promotion_Date);

           objDb.ExecuteNonQuery("Promotions_Update");
       }
       public void Transfers_Insert(Transfers objTrans) 
       {
           DBAccess objDb = new DBAccess();

           objDb.AddParameter("@School_Id",objTrans.School_Id);
           objDb.AddParameter("@Order_Date",objTrans.Order_Date);
           objDb.AddParameter("@Transf_Order_No",objTrans.Transf_Order_No);
           objDb.AddParameter("@Total_Period",objTrans.Total_Period);
           objDb.AddParameter("@Transfer_Date",objTrans.Transfer_Date);
           objDb.AddParameter("@Releiving_Date_PrevJob",objTrans.Releiving_Date_PrevJob);
           objDb.AddParameter("@Joining_Date",objTrans.Joining_Date);
           objDb.AddParameter("@D_Id",objTrans.D_Id);
           objDb.AddParameter("@T_Id",objTrans.T_Id);
           objDb.AddParameter("@To_Transfer",objTrans.To_Transfer);
           objDb.AddParameter("@From_Transfer",objTrans.From_Transfer);
           objDb.AddParameter("@NIC", objTrans.NIC);

           objDb.ExecuteNonQuery("Transfers_Insert");

       }

       public void Transfers_Update(Transfers objTrans)
       {
           DBAccess objDb = new DBAccess();

           objDb.AddParameter("@Trf_Id", objTrans.Trf_Id);
           objDb.AddParameter("@School_Id", objTrans.School_Id);
           objDb.AddParameter("@Order_Date", objTrans.Order_Date);
           objDb.AddParameter("@Transf_Order_No", objTrans.Transf_Order_No);
           objDb.AddParameter("@Total_Period", objTrans.Total_Period);
           objDb.AddParameter("@Transfer_Date", objTrans.Transfer_Date);
           objDb.AddParameter("@Releiving_Date_PrevJob", objTrans.Releiving_Date_PrevJob);
           objDb.AddParameter("@Joining_Date", objTrans.Joining_Date);
           objDb.AddParameter("@D_Id", objTrans.D_Id);
           objDb.AddParameter("@T_Id", objTrans.T_Id);
           objDb.AddParameter("@To_Transfer", objTrans.To_Transfer);
           objDb.AddParameter("@From_Transfer", objTrans.From_Transfer);

           objDb.ExecuteNonQuery("Transfers_Update");

       }
      public void AccountInfo_Insert(AccountInfos objAcctInfo) 
       {
           DBAccess objDb = new DBAccess();

           objDb.AddParameter("@Account_Type",objAcctInfo.Account_Type);
           objDb.AddParameter("@Gross_Salary",objAcctInfo.Gross_Salary);
           objDb.AddParameter("@Net_Salary",objAcctInfo.Net_Salary);
           objDb.AddParameter("@School_Id",objAcctInfo.School_Id);
           objDb.AddParameter("@Account_No",objAcctInfo.Account_No);
           objDb.AddParameter("@Bank_Name",objAcctInfo.Bank_Name);
           objDb.AddParameter("@NIC", objAcctInfo.NIC);

           objDb.ExecuteNonQuery("AccountsInfo_Insert");
       }
      public void AccountInfo_Update(AccountInfos objAcctInfo)
       {
           DBAccess objDb = new DBAccess();

           objDb.AddParameter("@Act_Id", objAcctInfo.Act_Id);
           objDb.AddParameter("@Account_Type", objAcctInfo.Account_Type);
           objDb.AddParameter("@Gross_Salary", objAcctInfo.Gross_Salary);
           objDb.AddParameter("@Net_Salary", objAcctInfo.Net_Salary);
           objDb.AddParameter("@School_Id", objAcctInfo.School_Id);
           objDb.AddParameter("@Account_No", objAcctInfo.Account_No);
           objDb.AddParameter("@Bank_Name", objAcctInfo.Bank_Name);

           objDb.ExecuteNonQuery("AccountsInfo_Update");
       }

      public void Experiences_Insert(Experiences objExper) 
      {
          DBAccess objDb = new DBAccess();

          objDb.AddParameter("@School_Id",objExper.School_Id);
          objDb.AddParameter("@To_Date",objExper.To_Date);
          objDb.AddParameter("@From_Date",objExper.From_Date);
          objDb.AddParameter("@Department",objExper.Department);
          objDb.AddParameter("@Resposibilities",objExper.Resposibilities);
          objDb.AddParameter("@Designation",objExper.Designation);
          objDb.AddParameter("@Organization_Name",objExper.Organization_Name);
          objDb.AddParameter("@NIC", objExper.NIC);

          objDb.ExecuteNonQuery("Experiences_Insert");

      }
      public void Experiences_Update(Experiences objExper)
      {
          DBAccess objDb = new DBAccess();

          objDb.AddParameter("@Exp_Id", objExper.Exp_Id);
          objDb.AddParameter("@School_Id", objExper.School_Id);
          objDb.AddParameter("@To_Date", objExper.To_Date);
          objDb.AddParameter("@From_Date", objExper.From_Date);
          objDb.AddParameter("@Department", objExper.Department);
          objDb.AddParameter("@Resposibilities", objExper.Resposibilities);
          objDb.AddParameter("@Designation", objExper.Designation);
          objDb.AddParameter("@Organization_Name", objExper.Organization_Name);

          objDb.ExecuteNonQuery("Experiences_Update");

      }
      
    }
}
