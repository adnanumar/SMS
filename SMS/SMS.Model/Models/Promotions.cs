using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS.Model
{
   public class Promotions
    {
       public int Promotion_Id { get; set; }
       public string FromScale { get; set; }
       public string ToScale { get; set; }
       public int Promo_TypeId { get; set; }
       public int NIC { get; set; }
       public string FromSchool { get; set; }
       public string ToSchool { get; set; }
       public DateTime Promotion_Date { get; set; }
    }
}
