using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SMS.Model;

namespace SMS.DAL
{
    public class SchoolMenuesManager : IDAL.ISchoolMenues
    {
        public DataTable SchoolMenuesGetAllRoleId(int RoleId)
        {
            DBAccess objDb = new DBAccess();
            objDb.AddParameter("@RoleId", RoleId);
            return objDb.ExecuteDataTable("SchoolMenues_GetAllByRoleId");
        }
    }
}
