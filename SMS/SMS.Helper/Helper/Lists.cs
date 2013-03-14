using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS.DAL;
using SMS.Model;
using System.Data;
using Telerik.Web.UI;
using System.Web;
using SMS.Helper;

namespace SMS.Helper
{
  public class Lists : IHelper.ILists
    {

      public DataTable Status_GetAll()
      {

          DBAccess objDb = new DBAccess();
          return objDb.ExecuteDataTable("Status_GetAll");

      }
      public void Fill_Status(RadComboBox objCmbx)
      {

          DataTable objDt = new DataTable();
          objDt = Status_GetAll();
          objCmbx.Items.Clear();
          foreach (DataRow dr in objDt.Rows)
          {
              RadComboBoxItem item = new RadComboBoxItem();
              item.Text = (string)dr["St_Name"];
              objCmbx.Items.Add(item);
          }

      }
     public DataTable District_GetAllById(int D_Id)
      {

          DBAccess objDb = new DBAccess();
          objDb.AddParameter("@D_Id", D_Id);
          return objDb.ExecuteDataTable("District_GetAllById");
      
      }
      public void Fill_Dist(RadComboBox objCmbx, int D_Id)
      {

          DataTable objDt = new DataTable();
          objDt = District_GetAllById(D_Id);
          objCmbx.Items.Clear();
          foreach (DataRow dr in objDt.Rows)
          {
              RadComboBoxItem item = new RadComboBoxItem();
              item.Text = (string)dr["D_Name"];
              objCmbx.Items.Add(item);
          }
      
      }
      public DataTable Tehsil_GetAllById(int D_Id)
      {

          DBAccess objDb = new DBAccess();
          objDb.AddParameter("@D_Id", D_Id);
          return objDb.ExecuteDataTable("Tehsil_GetAllById");

      }
      public void Fill_Tehsil(RadComboBox objCmbx, int D_Id)
      {

          DataTable objDt = new DataTable();
          objDt = Tehsil_GetAllById(D_Id);
          objCmbx.Items.Clear();
          foreach (DataRow dr in objDt.Rows)
          {
              RadComboBoxItem item = new RadComboBoxItem();
              item.Text = (string)dr["T_Name"];
              objCmbx.Items.Add(item);
          }

      }
      public DataTable Level_GetAll()
      {

          DBAccess objDb = new DBAccess();
          return objDb.ExecuteDataTable("Level_GetAll");

      }
      public void Fill_Level(RadComboBox objCmbx)
      {

          DataTable objDt = new DataTable();
          objDt = Level_GetAll();
          objCmbx.Items.Clear();
          foreach (DataRow dr in objDt.Rows)
          {
              RadComboBoxItem item = new RadComboBoxItem();
              item.Text = (string)dr["Level_Name"];
              objCmbx.Items.Add(item);
          }

      }
    }
}
