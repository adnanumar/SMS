using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Globalization;



namespace SMS.Model
{
    

 public  class SchoolInfo
    {

        public int School_Id { get; set; }

        public int T_Id { get; set; }

        public int D_Id { get; set; }

        public string School_Name { get; set; }

        public string Head_Name { get; set; }

        public string Head_CellNo { get; set; }

        public int Head_Grade { get; set; }

        public string School_Code { get; set; }

        public string Phone_No { get; set; }

        public string Email { get; set; }

        public int NA_No { get; set; }

        public int PP_No { get; set; }

        public int UC_No { get; set; }

        public string Total_Area { get; set; }

        public string Covered_Area { get; set; }

        public string Open_Area { get; set; }

        public int No_ClassRoom { get; set; }

        public int No_Room { get; set; }

        public int Damage_Room { get; set; }

        public int No_ScienceRoom { get; set; }

        public int No_ComputerLab { get; set; }

        public bool Is_Mosque { get; set; }

        public int No_Desk { get; set; }

        public int No_Bench { get; set; }

        public int No_Chair { get; set; }

        public int No_Tables { get; set; }

        public int No_TStaff { get; set; }

        public int No_NonTStaff { get; set; }
        
        public bool IsPlayground { get; set; }
        
        public string Ground_Area { get; set; }

        public int No_Toilet { get; set; }
        
        public string Boundary_Area { get; set; }

        public bool IsBoundaryWall { get; set; }
        
        public string Underconstruction_Area { get; set; }

        public bool IsElectricity { get; set; }

        public bool IsTelephone { get; set; }

        public bool IsSuiGas { get; set; }
        
        public DateTime LastUpdated { get; set; }
        public int Level_Id { get; set; }


    }
}
