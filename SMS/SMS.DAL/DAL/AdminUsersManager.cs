using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SMS.Model;

namespace SMS.DAL
{
    public class AdminUsersManager :IDAL.IAdminUsers
    {
        public DataTable Admin_AuthenticateUser(Users objusers) 
        {
            DBAccess objDb = new DBAccess();
            objDb.AddParameter("@AdminUserEmail", objusers.UserName);
            objDb.AddParameter("@AdminUserPassword", objusers.Password);
            return objDb.ExecuteDataTable("AuthenticateAdmin_User");
        }
        
    }
}
