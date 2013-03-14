using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMS.DAL;
using SMS.Model;
using System.Data;


namespace SMS.Admin.Controls
{
    public partial class AdminLogin : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            Session["ApplicationUser_Name"] = "";
            Session["ApplicationU_Id"] = "";
            Session["ApplicationUser_Password"] = "";
            Session["ApplicationFirst_Name"] = "";
            Session["ApplicationLast_Name"] = "";
            Session["ApplicationAdminInfo_Id"] = "";
            Session["ApplicationIsActive"] = "";
            Session["ApplicationLastLogin_Date"] = "";
            Session["ApplicationR_Id"] = "";
            Session["ApplicationD_Name"] = "";
            Session["ApplicationT_Name"] = "";
            Session["ApplicationD_Id"] = "";
            Session["ApplicationT_Id"] = "";
           
            try
            {


            Users objUsers = new Users();
            AdminUsersManager objAdminUsersManager = new AdminUsersManager();

            DataTable objDt = new DataTable();

             objUsers.UserName = txtbxEduAdminUserName.Text.Trim();
            objUsers.Password = txtbxEduAdminPassword.Text.Trim();
            objDt = objAdminUsersManager.Admin_AuthenticateUser(objUsers);

            foreach (DataRow dr in objDt.Rows)
            {

                Session["ApplicationUser_Name"] = dr["User_Name"].ToString();
                Session["ApplicationU_Id"] = dr["U_Id"].ToString();
                Session["ApplicationUser_Password"] = dr["User_Password"].ToString();
                Session["ApplicationFirst_Name"] = dr["First_Name"].ToString();
                Session["ApplicationLast_Name"] = dr["Last_Name"].ToString();
                Session["ApplicationAdminInfo_Id"] = dr["AdminInfo_Id"].ToString();
                Session["ApplicationIsActive"] = dr["IsActive"].ToString();
                Session["ApplicationLastLogin_Date"] = dr["LastLogin_Date"].ToString();
                Session["ApplicationR_Id"] = dr["R_Id"].ToString();
                Session["ApplicationD_Name"] = dr["D_Name"].ToString();
                Session["ApplicationT_Name"] = dr["T_Name"].ToString();
                Session["ApplicationD_Id"] = dr["D_Id"].ToString();
                Session["ApplicationT_Id"] = dr["T_Id"].ToString();

                
            }


            if (Session["ApplicationUser_Name"].ToString() == txtbxEduAdminUserName.Text && Session["ApplicationUser_Password"].ToString() == txtbxEduAdminPassword.Text && Session["ApplicationIsActive"].ToString() == "True")
            {
                txtbxEduAdminPassword.Text = string.Empty;
                txtbxEduAdminUserName.Text = string.Empty;
                Response.Redirect("Home.aspx");
            }
            else if (Session["ApplicationUser_Name"].ToString() == txtbxEduAdminUserName.Text && Session["ApplicationUser_Password"].ToString() == txtbxEduAdminPassword.Text && Session["ApplicationIsActive"].ToString() == "False")
            {

                lblError.Text = "Your account is temporarily blocked!";

            }
            else if (Session["ApplicationUser_Name"].ToString() != txtbxEduAdminUserName.Text || Session["ApplicationUser_Password"].ToString() != txtbxEduAdminPassword.Text && Session["ApplicationIsActive"].ToString() != "False")
            {

                lblError.Text = "Incorrect username or password!";

            }

            }
            catch (Exception ex)
            
            {
                lblError.Text = "Login Error";
                txtbxEduAdminPassword.Text = string.Empty;
                txtbxEduAdminUserName.Text = string.Empty;
            }
                txtbxEduAdminPassword.Text = string.Empty;
                txtbxEduAdminUserName.Text = string.Empty;
            }
            
        }
    }
