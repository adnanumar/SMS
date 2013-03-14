using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Globalization;


namespace SMS.Model
{
    
  public class Users
  {
      public int U_Id { get; set; }
      public string UserName { get; set; }
      public string Password { get; set; }
      public DateTime LastLoginDate { get; set; }
      public DateTime LastUpdated { get; set; }
      public bool IsActive { get; set; }


  }

}
