using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS.Model
{
   public class Transfers
    {
       public int Trf_Id { get; set; }

       public int NIC { get; set; }

       public string From_Transfer { get; set; }

       public string To_Transfer { get; set; }

       public int T_Id { get; set; }

       public int D_Id { get; set; }

       public DateTime Joining_Date { get; set; }

       public DateTime Releiving_Date_PrevJob { get; set; }

       public DateTime Transfer_Date { get; set; }

       public string Total_Period { get; set; }

       public string Transf_Order_No { get; set; }

       public DateTime Order_Date { get; set; }

       public int School_Id { get; set; }

       public DateTime LastUpdated { get; set; }
    }
}
