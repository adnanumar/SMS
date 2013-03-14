using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SMS.Model;

namespace SMS.DAL
{
    public class SchoolUsersManager : IDAL.ISchoolUsers
    {
        public DataTable School_AuthenticateUser(Users objusers)
        {
            DBAccess objDb = new DBAccess();
            objDb.AddParameter("@UserEmail", objusers.UserName);
            objDb.AddParameter("@UserPassword", objusers.Password);
            return objDb.ExecuteDataTable("AuthenticateSchool_User");
        }
        
    }
}
