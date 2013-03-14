using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SMS.Model;

namespace SMS.IDAL
{
   public interface ISchoolMenues
    {
        DataTable SchoolMenuesGetAllRoleId(int RoleId);
        
    }
}
