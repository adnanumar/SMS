using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS.Model
{
   public class Courses
    {
       public int Crs_Id { get; set; }
       public int NIC { get; set; }

       public string Course_Name { get; set; }

       public string Duration { get; set; }

       public DateTime From_Date { get; set; }

       public DateTime To_Date { get; set; }

       public string Venue { get; set; }
    }
}
