using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SMS.Model;

namespace SMS.DAL
{
    public class AdminMenuesManager
    {
        public DataTable AdminMenues_GetAllByRoleId(int RoleId)
        {
            DBAccess objDBAccess = new DBAccess();
            objDBAccess.AddParameter("@RoleId", RoleId);
            return objDBAccess.ExecuteDataTable("AdminMenues_GetAllByRoleId");
        }

    }
}