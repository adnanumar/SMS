using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS.Model
{
   public class PersonalData
    {

       public long NIC { get; set; }

       public string Employee_Name { get; set; }

       public string Father_Name { get; set; }

       public string Perm_Address { get; set; }

       public string Current_Address { get; set; }

       public string Designation { get; set; }

       public string Grade { get; set; }
       public string Email { get; set; }

       public long Cell_No { get; set; }

       public long Office_No { get; set; }

       public long Residence_No { get; set; }

       public long Personal_No { get; set; }

       public string Domicile { get; set; }

       public long GBF_No { get; set; }

       public string Qualification { get; set; }

       public byte[] Picture { get; set; }

       public DateTime DateOfBirth { get; set; }

       public string Gender { get; set; }

       public DateTime Joining_Date { get; set; }

       public DateTime JoiningAsPerm_Date { get; set; }

       public DateTime JoiningPresSta_Date { get; set; }

       public string Contract_Permanent { get; set; }
       
       public int School_Id { get; set; }
       public DateTime LastUpdated { get; set; }
       public bool IsTeachingStaff { get; set; }

       

    }
}
