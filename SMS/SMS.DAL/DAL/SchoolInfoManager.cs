using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS.Model;
using System.Data;

namespace SMS.DAL
{
   public class SchoolInfoManager : IDAL.ISchoolInfo
    {

       public void SchoolInfo_Add(SchoolInfo objSchInfo, string D_Name, string T_Name, string Level_Name) {

           DBAccess objDb = new DBAccess();
           objDb.AddParameter("@School_Name", objSchInfo.School_Name);
           objDb.AddParameter("@School_Code", objSchInfo.School_Code);
           objDb.AddParameter("@Email", objSchInfo.Email);
           objDb.AddParameter("@D_Name", D_Name);
           objDb.AddParameter("@T_Name", T_Name);
           objDb.AddParameter("@Level", Level_Name);
           objDb.ExecuteNonQuery("SchoolUserInfo_Insert");
       
       }
       public void SchoolUsersInfo_Update(SchoolInfo objSchInfo, string D_Name, string T_Name, string Level_Name) {

           DBAccess objDb = new DBAccess();
           objDb.AddParameter("@School_Id", objSchInfo.School_Id);
           objDb.AddParameter("@School_Name", objSchInfo.School_Name);
           objDb.AddParameter("@School_Code", objSchInfo.School_Code);
           objDb.AddParameter("@Email", objSchInfo.Email);
           objDb.AddParameter("@D_Name", D_Name);
           objDb.AddParameter("@T_Name", T_Name);
           objDb.AddParameter("@Level", Level_Name);
           objDb.ExecuteNonQuery("SchoolUserInfo_Update");

       }
       public DataTable SchoolUsersInfo_GetAllById(int School_Id){


           DBAccess objDb = new DBAccess();
           objDb.AddParameter("@School_Id",School_Id);
           return objDb.ExecuteDataTable("SchoolUsersInfo_GetAllById");
       
       }
      public  DataTable SchoolUsersInfo_GetAllByD_Id(int D_Id) {

          DBAccess objDb = new DBAccess();
          objDb.AddParameter("@D_Id", D_Id);
          return objDb.ExecuteDataTable("SchoolUsersInfo_GetAllByD_Id");

       }
       public DataTable SchoolInfo_GetAllByD_Id(int D_Id){
       
           DBAccess objDb = new DBAccess();
           objDb.AddParameter("@D_Id",D_Id);
           return objDb.ExecuteDataTable("SchoolInfo_GetAllByD_Id");
       
       }
       public DataTable SchoolInfo_GetAllByS_Id(int School_Id){
       
            DBAccess objDb = new DBAccess();
            objDb.AddParameter("@School_Id", School_Id);
            return objDb.ExecuteDataTable("SchoolInfo_GetAllByS_Id");      
       }
       
       public void SchoolUserStatus_Update(Users objUsersInfo) {

           DBAccess objDb = new DBAccess();
           objDb.AddParameter("@U_Id", objUsersInfo.U_Id);
           objDb.AddParameter("@UserPassword", objUsersInfo.Password);
           objDb.AddParameter("@IsActive", objUsersInfo.IsActive);
           objDb.ExecuteNonQuery("SchoolUsersStatus_Update");
       
       }
       public void SchoolInfo_Update(SchoolInfo objSchInfo)
       {
           DBAccess objDb = new DBAccess();

           objDb.AddParameter("@School_Id", objSchInfo.School_Id);
           objDb.AddParameter("@Head_Name", objSchInfo.Head_Name);
           objDb.AddParameter("@Head_CellNo", objSchInfo.Head_CellNo);
           objDb.AddParameter("@Head_Grade", objSchInfo.Head_Grade);
           objDb.AddParameter("@Phone_No", objSchInfo.Phone_No);
           objDb.AddParameter("@UC_No", objSchInfo.UC_No);
           objDb.AddParameter("@NA_No", objSchInfo.NA_No);
           objDb.AddParameter("@PP_No", objSchInfo.PP_No);
           objDb.AddParameter("@Total_Area", objSchInfo.Total_Area);
           objDb.AddParameter("@Covered_Area", objSchInfo.Covered_Area);
           objDb.AddParameter("@Open_Area", objSchInfo.Open_Area);
           objDb.AddParameter("@No_ClassRoom", objSchInfo.No_ClassRoom);
           objDb.AddParameter("@No_Room", objSchInfo.No_Room);
           objDb.AddParameter("@Damage_Room", objSchInfo.Damage_Room);
           objDb.AddParameter("@No_ScienceRoom", objSchInfo.No_ScienceRoom);
           objDb.AddParameter("@No_ComputerLab", objSchInfo.No_ComputerLab);
           objDb.AddParameter("@IsMosque", objSchInfo.Is_Mosque);
           objDb.AddParameter("@No_Desk", objSchInfo.No_Desk);
           objDb.AddParameter("@No_Bench", objSchInfo.No_Bench);
           objDb.AddParameter("@No_Chair", objSchInfo.No_Chair);
           objDb.AddParameter("@No_Tables", objSchInfo.No_Tables);
           objDb.AddParameter("@No_TStaff", objSchInfo.No_TStaff);
           objDb.AddParameter("@No_NonTStaff", objSchInfo.No_NonTStaff);
           objDb.AddParameter("@IsPlayGround", objSchInfo.IsPlayground);
           objDb.AddParameter("@Ground_Area", objSchInfo.Ground_Area);
           objDb.AddParameter("@No_Toilet", objSchInfo.No_Toilet);
           objDb.AddParameter("@Boundry_Area", objSchInfo.Boundary_Area);
           objDb.AddParameter("@IsBoundaryWall", objSchInfo.IsBoundaryWall);
           objDb.AddParameter("@UnconstructedBArea", objSchInfo.Underconstruction_Area);
           objDb.AddParameter("@IsElectricity", objSchInfo.IsElectricity);
           objDb.AddParameter("@IsTelephoneLine", objSchInfo.IsTelephone);
           objDb.AddParameter("@IsSuiGas", objSchInfo.IsSuiGas);

           objDb.ExecuteNonQuery("SchoolInfo_Update");

       }
    }
}
