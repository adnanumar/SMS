using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS.Model;
using System.Data;

namespace SMS.IDAL
{
    interface IAdminMenues
    {
        DataTable AdminMenuesGetAllByRoleId(int RoleId);
    }
}
