using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMS.Model;
using SMS.DAL;
using System.Threading;
using Telerik.Web.UI;
using SMS.Helper;
using System.IO;
using System.Data;

namespace SMS.Teachers
{
    public partial class AddTeacherInfo : System.Web.UI.Page
    {
        Lists objlist = new Lists();
        PersonalData objPersonalData = new PersonalData();
        TeachersDetailInfoManager objDataManager = new TeachersDetailInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Convert.ToString(Session["SchoolU_Id"])) && string.IsNullOrEmpty(Convert.ToString(Session["SchoolR_Id"])))
                {
                    Response.Redirect("~/Login.aspx");
                }
                if(!IsPostBack){

                    objlist.Fill_Status(cmbxTeachingStaff);
                    Load_PersonalDataByNIC(Convert.ToInt64(Request.QueryString["cnic"]));
                
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void Load_PersonalDataByNIC(long NIC){
        
            DataTable objDt = new DataTable();
            objDt = objDataManager.PersonalData_GetAllByNIC(NIC);
            foreach(DataRow dr in objDt.Rows){
            
                txtbxName.Text = dr["Employee_Name"].ToString();
                txtbxFatherName.Text = dr["Father_Name"].ToString();
                txtbxNIC.Text = dr["NIC"].ToString();
                txtbxDesignation.Text = dr["Designation"].ToString();
                txtbxGrade.Text = dr["Grade"].ToString();
                txtbxEmail.Text = dr["Email"].ToString();
                txtbxCellNo.Text = dr["Cell_No"].ToString();
                txtbxOfficeNo.Text = dr["Office_No"].ToString();
                txtbxResidenceNo.Text = dr["Residence_No"].ToString();
                txtbxPersonalNo.Text = dr["Personal_No"].ToString();
                txtbxDomicile.Text = dr["Domicile"].ToString();
                txtbxGBFNo.Text = dr["GBF_No"].ToString();
                txtbxQualification.Text = dr["Qualification"].ToString();

                if (dr["IsTeachingStaff"].ToString() == "True")
                {
                    RadComboBoxItem item = cmbxTeachingStaff.FindItemByText("Yes");
                    item.Selected = true;
                }
                else{

                    RadComboBoxItem item = cmbxTeachingStaff.FindItemByText("No");
                    item.Selected = true;
                
                }
                
                DatePickerDateOfBirth.SelectedDate = Convert.ToDateTime(dr["DateOfBirth"]);
                DatePickerJoiningDate.SelectedDate = Convert.ToDateTime(dr["Joining_Date"]);
                DatePickerJoiningPresentStation.SelectedDate = Convert.ToDateTime(dr["JoiningPresSta_Date"]);
                DatePickerPermanentDate.SelectedDate = Convert.ToDateTime(dr["JoiningAsPerm_Date"]);

                RadComboBoxItem item1 = cmbxGender.FindItemByText(dr["Gender"].ToString());
                item1.Selected = true;

                RadComboBoxItem item2 = cmbxContractPermanent.FindItemByText(dr["Contract_Permanent"].ToString());
                item2.Selected = true;

                txtbxCurrentAddress.Text = dr["Current_Address"].ToString();
                txtbxPermanentAddress.Text = dr["Perm_Address"].ToString();

            }
        
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            

            try
            {

                //foreach (UploadedFile file in UploadPicture.UploadedFiles)
                //{


                //byte[] image;
                //long fileLength = UploadedFiles.UploadedFiles[0].InputStream.Length;
                //image = new byte[fileLength];
                //UploadedFiles.UploadedFiles[0].InputStream.Read(image, 0, image.Length);
                //UploadedFiles.DataValue = image;

                //string imageUrl = @"http://www.somedomain.com/image.jpg";
                //string saveLocation = @"C:\someImage.jpg";

                //byte[] imageBytes;
                //HttpWebRequest imageRequest = (HttpWebRequest)WebRequest.Create(imageUrl);
                //WebResponse imageResponse = imageRequest.GetResponse();

                //Stream responseStream = imageResponse.GetResponseStream();

                //using (BinaryReader br = new BinaryReader(responseStream))
                //{
                //    imageBytes = br.ReadBytes(500000);
                //    br.Close();
                //}


                //if (UploadPicture.UploadedFiles.Count == 1)
                //{
                //    UploadedFile file = UploadPicture.UploadedFiles[0];
                //    byte[] bytes = new byte[file.ContentLength];
                //    file.InputStream.Read(bytes, 0, file.ContentLength);
                //    objPersonalData.Picture = bytes;
                //}
                //else
                //{

                //    objPersonalData.Picture = null;

                //}

                objPersonalData.NIC = Convert.ToInt64(txtbxNIC.Text);
                objPersonalData.Employee_Name = txtbxName.Text;
                objPersonalData.Father_Name = txtbxFatherName.Text;
                objPersonalData.Designation = txtbxDesignation.Text;
                objPersonalData.Grade = txtbxGrade.Text;

                if (!String.IsNullOrEmpty(txtbxEmail.Text))
                {
                    objPersonalData.Email = txtbxEmail.Text;

                }
                else
                {

                    objPersonalData.Email = "";
                }


                objPersonalData.Cell_No = Convert.ToInt64(txtbxCellNo.Text);

                if (!String.IsNullOrEmpty(txtbxOfficeNo.Text))
                {
                    objPersonalData.Office_No = Convert.ToInt64(txtbxOfficeNo.Text);

                }
                else
                {

                    objPersonalData.Office_No = 0;
                }

                if (!String.IsNullOrEmpty(txtbxResidenceNo.Text))
                {
                    objPersonalData.Residence_No = Convert.ToInt64(txtbxResidenceNo.Text);

                }
                else
                {

                    objPersonalData.Residence_No = 0;
                }


                objPersonalData.Personal_No = Convert.ToInt64(txtbxPersonalNo.Text);
                objPersonalData.Domicile = txtbxDomicile.Text;

                if (!String.IsNullOrEmpty(txtbxGBFNo.Text))
                {
                    objPersonalData.GBF_No = Convert.ToInt64(txtbxGBFNo.Text);

                }
                else
                {

                    objPersonalData.GBF_No = 0;
                }

                objPersonalData.Qualification = txtbxQualification.Text;
                objPersonalData.DateOfBirth = Convert.ToDateTime(DatePickerDateOfBirth.SelectedDate);
                objPersonalData.Joining_Date = Convert.ToDateTime(DatePickerJoiningDate.SelectedDate);
                if (DatePickerPermanentDate.SelectedDate != null)
                {
                    objPersonalData.JoiningAsPerm_Date = Convert.ToDateTime(DatePickerPermanentDate.SelectedDate);

                }
                else
                {

                    objPersonalData.JoiningAsPerm_Date = Convert.ToDateTime(DatePickerJoiningDate.SelectedDate);
                }


                objPersonalData.JoiningPresSta_Date = Convert.ToDateTime(DatePickerJoiningPresentStation.SelectedDate);
                objPersonalData.Gender = cmbxGender.Text;
                objPersonalData.Contract_Permanent = cmbxContractPermanent.Text;

                if (cmbxTeachingStaff.Text == "Yes")
                {

                    objPersonalData.IsTeachingStaff = true;
                }
                else
                {
                    objPersonalData.IsTeachingStaff = false;

                }

                objPersonalData.School_Id = Convert.ToInt32(Session["School_Id"]);
                objPersonalData.Current_Address = txtbxCurrentAddress.Text;
                objPersonalData.Perm_Address = txtbxPermanentAddress.Text;


                if (string.IsNullOrEmpty(Request.QueryString["cnic"]))
                {
                
              
                   

                    objDataManager.TeachersPersonalInfo_Insert(objPersonalData);
                    RadWindowManager1.RadAlert("Staff Information Saved Successfully! ", 330, 180, "ADD STAFF INFO", "alertCallBackFn");
                    //lblMessage.Text = "Staff Information Saved Successfully!";
                    ClearAllFields();


                }
                else
                {

                    objDataManager.TeachersPersonalInfo_Update(objPersonalData);
                    RadWindowManager1.RadAlert("Staff Information Updated Successfully! ", 330, 180, "Update STAFF INFO", "alertCallBackFn");
                    //lblMessage.Text = "Staff Information Saved Successfully!";
                    ClearAllFields();

                }


               // }
                

            }
            catch (Exception ex)
            {
                RadWindowManager1.RadAlert("Staff Information Exception!", 330, 180, "ADD/Edit STAFF INFO", "alertCallBackFn");
               // lblMessage.Text = "Employee Personal Information Saved Exception!";  
            }
        }
        public void ClearAllFields() 
        {
            txtbxNIC.Text = string.Empty;
            txtbxName.Text = string.Empty;
            txtbxFatherName.Text = string.Empty;
            txtbxDesignation.Text = string.Empty;
            txtbxGrade.Text = string.Empty;
            txtbxEmail.Text = string.Empty;
            txtbxCellNo.Text = string.Empty;
            txtbxOfficeNo.Text = string.Empty;
            txtbxResidenceNo.Text = string.Empty;
            txtbxPersonalNo.Text = string.Empty;
            txtbxDomicile.Text = string.Empty;
            txtbxGBFNo.Text = string.Empty;
            txtbxQualification.Text = string.Empty;
            DatePickerDateOfBirth.SelectedDate = DateTime.Now;
            DatePickerJoiningDate.SelectedDate = DateTime.Now;
            DatePickerPermanentDate.SelectedDate = DateTime.Now;
            DatePickerJoiningPresentStation.SelectedDate = DateTime.Now;
            cmbxGender.Text = string.Empty;
            cmbxContractPermanent.Text = string.Empty;
            cmbxTeachingStaff.Text = string.Empty;
            txtbxCurrentAddress.Text = string.Empty;
            txtbxPermanentAddress.Text = string.Empty;

        }

        //protected void UploadPicture_FileUploaded(object sender, FileUploadedEventArgs e)
        //{
        //    UploadPicture.TemporaryFolder = "~/tempimages/";
        //    string strFileType = e.File.FileName;
        //    e.File.SaveAs(Server.MapPath("~/tempimages/" + strFileType));
        //   // strNewPath = Server.MapPath("~/CustomersTradesFiles/" + strFileName + strFileType);
        //}
    }
}