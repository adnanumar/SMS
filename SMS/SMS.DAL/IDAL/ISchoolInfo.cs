using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS.Model;
using System.Data;

namespace SMS.IDAL
{
   public interface ISchoolInfo
    {
       void SchoolInfo_Update(SchoolInfo objSchInfo);
       void SchoolUserStatus_Update(Users objUsersInfo);
       DataTable SchoolInfo_GetAllByD_Id(int D_Id);
       DataTable SchoolInfo_GetAllByS_Id(int School_Id);
       DataTable SchoolUsersInfo_GetAllByD_Id(int D_Id);
       DataTable SchoolUsersInfo_GetAllById(int School_Id);
       void SchoolInfo_Add(SchoolInfo objSchInfo,string D_Name,string T_Name,string Level_Name);
       void SchoolUsersInfo_Update(SchoolInfo objSchInfo, string D_Name, string T_Name, string Level_Name);
    }
}
