using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS.Model
{
   public class ProfessionalCareer
    {
       public int Prf_Id { get; set; }
       public int NIC { get; set; }

       public DateTime DateOfPromotion { get; set; }


       public string Promotion_Grade { get; set; }


       public DateTime DateOfJoining { get; set; }

       public string FromOrg_Name { get; set; }


       public string ToOrg_Name { get; set; }


       public string Regular_CM { get; set; }


       public int T_Id { get; set; }

       public int D_Id { get; set; }

       public int School_Id { get; set; }

       public DateTime LastUpdated { get; set; }
    }
}
