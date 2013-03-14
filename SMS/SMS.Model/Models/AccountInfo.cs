using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SMS.Model
{
    public class AccountInfos
    {
        public int Act_Id { get; set; }
        public int NIC { get; set; }

        public string Bank_Name { get; set; }

        public string Account_No { get; set; }

        public DateTime LastUpdated { get; set; }

        public int School_Id { get; set; }

        public double Net_Salary { get; set; }

        public double Gross_Salary { get; set; }

        public string Account_Type { get; set; }
    }
}
