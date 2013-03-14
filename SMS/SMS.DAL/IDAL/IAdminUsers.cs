using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SMS.Model;


namespace SMS.IDAL
{
    interface IAdminUsers
    {

        DataTable Admin_AuthenticateUser(Users objusers);
       
        
    }
}
