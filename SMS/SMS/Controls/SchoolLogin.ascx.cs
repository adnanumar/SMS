using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMS.DAL;
using SMS.Model;
using System.Data;

namespace SMS.Controls
{
    public partial class SchoolLogin1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["SchoolUser_Name"] = "";
            Session["SchoolU_Id"] = "";
            Session["SchoolUser_Password"] = "";
            Session["School_Name"] = "";
            Session["SchoolHead_Name"] = "";
            Session["School_Code"] = "";
            Session["School_Id"] = "";
            Session["SchoolIsActive"] = "";
            Session["SchoolLastLogin_Date"] = "";
            Session["SchoolR_Id"] = "";
            Session["SchoolD_Name"] = "";
            Session["SchoolT_Name"] = "";
            Session["SchoolD_Id"] = "";
            Session["SchoolT_Id"] = "";
           
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session["SchoolUser_Name"] = "";
            Session["SchoolU_Id"] = "";
            Session["SchoolUser_Password"] = "";
            Session["School_Name"] = "";
            Session["SchoolHead_Name"] = "";
            Session["School_Code"] = "";
            Session["School_Id"] = "";
            Session["SchoolIsActive"] = "";
            Session["SchoolLastLogin_Date"] = "";
            Session["SchoolR_Id"] = "";
            Session["SchoolD_Name"] = "";
            Session["SchoolT_Name"] = "";
            Session["SchoolD_Id"] = "";
            Session["SchoolT_Id"] = "";
           
            try
            {


            Users objUsers = new Users();
            SchoolUsersManager objSchoolUsersManager = new SchoolUsersManager();

            DataTable objDt = new DataTable();

             objUsers.UserName = txtbxEduSchoolUserName.Text.Trim();
            objUsers.Password = txtbxEduSchoolPassword.Text.Trim();
            objDt = objSchoolUsersManager.School_AuthenticateUser(objUsers);

            foreach (DataRow dr in objDt.Rows)
            {

                Session["SchoolUser_Name"] = dr["User_Name"].ToString();
                Session["SchoolU_Id"] = dr["U_Id"].ToString();
                Session["SchoolUser_Password"] = dr["User_Password"].ToString();
                Session["School_Name"] = dr["School_Name"].ToString();
                Session["SchoolHead_Name"] = dr["Head_Name"].ToString();
                Session["School_Code"] = dr["School_Code"].ToString();
                Session["School_Id"] = dr["School_Id"].ToString();
                Session["SchoolIsActive"] = dr["IsActive"].ToString();
                Session["SchoolLastLogin_Date"] = dr["LastLogin_Date"].ToString();
                Session["SchoolR_Id"] = dr["R_Id"].ToString();
                Session["SchoolD_Name"] = dr["D_Name"].ToString();
                Session["SchoolT_Name"] = dr["T_Name"].ToString();
                Session["SchoolD_Id"] = dr["D_Id"].ToString();
                Session["SchoolT_Id"] = dr["T_Id"].ToString();

                
            }


            if (Session["SchoolUser_Name"].ToString() == txtbxEduSchoolUserName.Text && Session["SchoolUser_Password"].ToString() == txtbxEduSchoolPassword.Text && Session["SchoolIsActive"].ToString() == "True")
            {

                txtbxEduSchoolPassword.Text = string.Empty;
                txtbxEduSchoolUserName.Text = string.Empty;
                Response.Redirect("Home.aspx");
            }
            else if (Session["SchoolUser_Name"].ToString() == txtbxEduSchoolUserName.Text && Session["SchoolUser_Password"].ToString() == txtbxEduSchoolPassword.Text && Session["SchoolIsActive"].ToString() == "False")
            {

                lblError.Text = "Your account is temporarily blocked!";

            }
            else if (Session["SchoolUser_Name"].ToString() != txtbxEduSchoolUserName.Text || Session["SchoolUser_Password"].ToString() != txtbxEduSchoolPassword.Text && Session["SchoolIsActive"].ToString() != "False")
            {

                lblError.Text = "Incorrect username or password!";

            }

            }
            catch (Exception ex)
            
            {
                lblError.Text = "Login Error" + ex;
                txtbxEduSchoolPassword.Text = string.Empty;
                txtbxEduSchoolUserName.Text = string.Empty;
            }
                txtbxEduSchoolPassword.Text = string.Empty;
                txtbxEduSchoolUserName.Text = string.Empty;
            }
        }
    }
