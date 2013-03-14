using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SMS.IHelper
{
    interface ILists
    {
      DataTable District_GetAllById(int D_Id);
      DataTable Tehsil_GetAllById(int D_Id);
      DataTable Level_GetAll();
      DataTable Status_GetAll();
    }
}
