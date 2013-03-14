<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="AddTeacherInfo.aspx.cs" Inherits="SMS.Teachers.AddTeacherInfo" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    //on insert and update buttons click temporarily disables ajax to perform upload actions
//    function conditionalPostback(sender, args) {
//        var re = new RegExp("\.UpdateButton$|\.PerformInsertButton$", "ig");
//        if (sender.EventTarget.match(re)) {
//            sender.EnableAjax = false;
//        }
//    }


    var imgUrl = null;
    function alertCallBackFn(arg) {
       // radalert("<strong>radalert</strong> returned the following result: <h3 style='color: #ff0000;'>" + arg + "</h3>", null, null, "Result");
    }
    
</script>
    
<telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    <AjaxSettings>
    <telerik:AjaxSetting AjaxControlID="Panel1">
    <UpdatedControls>
    <telerik:AjaxUpdatedControl LoadingPanelID="RadAjaxLoadingPanel1"  ControlID="Panel1" />
    </UpdatedControls>
    </telerik:AjaxSetting>
    </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadFormDecorator ID="RadFormDecorator1" DecoratedControls="All" EnableRoundedCorners="true" EnableEmbeddedSkins="true" runat="server" />
    
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server">
    </telerik:RadAjaxLoadingPanel>

    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
    </telerik:RadWindowManager>
    <asp:Panel ID="Panel1" GroupingText="Add/Edit Employee Personal Info" runat="server">
        <table class="style1">
            <%--<tr>
                <td class="style7">
                    Picture :
                </td>
                <td class="style8">
                    <%--<telerik:RadAsyncUpload ID="UploadPicture" ManualUpload="false" 
                        AllowedFileExtensions=".jpg,.jpeg,.bnp,.gif,.png" 
                        MaxFileInputsCount="1"  runat="server" Width="120px" 
                        TemporaryFolder="~/tempimages" 
                        UseApplicationPoolImpersonation="True">
                    </telerik:RadAsyncUpload>
                </td>
                <td class="style3">
                    &nbsp; </td>
                <td class="style5">
                    &nbsp;
                    
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>--%>
            <tr>
                <td class="style7">
                    Name :
                </td>
                <td class="style8">
                    <telerik:RadTextBox ID="txtbxName" runat="server">
                    </telerik:RadTextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtbxName"
                        ErrorMessage="***" ForeColor="Red" ValidationGroup="staffInfo"></asp:RequiredFieldValidator>
                </td>
                <td class="style3">
                    Father Name :
                </td>
                <td class="style5">
                    <telerik:RadTextBox ID="txtbxFatherName" runat="server"
                        LabelWidth="64px" Width="160px">
                    </telerik:RadTextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtbxFatherName"
                        ErrorMessage="***" ForeColor="Red" ValidationGroup="staffInfo"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7">
                    NIC :
                </td>
                <td class="style8">
                    <telerik:RadMaskedTextBox ID="txtbxNIC" runat="server" Mask="#####-#######-#">
                    </telerik:RadMaskedTextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtbxNIC"
                        ErrorMessage="***" ForeColor="Red" ValidationGroup="staffInfo"></asp:RequiredFieldValidator>
                </td>
                <td class="style3">
                    Designation :
                </td>
                <td class="style5">
                    <telerik:RadTextBox ID="txtbxDesignation" runat="server" 
                        EmptyMessage="e.g SSE , SST , Headmaster">
                    </telerik:RadTextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtbxDesignation"
                        ErrorMessage="***" ForeColor="Red" ValidationGroup="staffInfo"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Grade :
                </td>
                <td class="style8">
                    <telerik:RadTextBox ID="txtbxGrade" runat="server" EmptyMessage="e.g 16">
                    </telerik:RadTextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtbxGrade"
                        ErrorMessage="***" ForeColor="Red" ValidationGroup="staffInfo"></asp:RequiredFieldValidator>
                </td>
                <td class="style3">
                    Email :
                </td>
                <td class="style5">
                    <telerik:RadTextBox ID="txtbxEmail" runat="server" 
                        EmptyMessage="e.g john@gmail.com">
                    </telerik:RadTextBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Cell No :
                </td>
                <td class="style8">
                    <telerik:RadMaskedTextBox ID="txtbxCellNo" runat="server" Mask="###-#######">
                    </telerik:RadMaskedTextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtbxCellNo"
                        ErrorMessage="***" ForeColor="Red" ValidationGroup="staffInfo"></asp:RequiredFieldValidator>
                </td>
                <td class="style3">
                    Office No :
                </td>
                <td class="style5">
                   
                    <telerik:RadMaskedTextBox ID="txtbxOfficeNo" runat="server" Mask="###-#######">
                    </telerik:RadMaskedTextBox>

                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Residence No :
                </td>
                <td class="style8">
                    <telerik:RadMaskedTextBox ID="txtbxResidenceNo" Runat="server" 
                        Mask="###-#######">
                    </telerik:RadMaskedTextBox>
                </td>
                <td class="style3">
                    Personal No :
                </td>
                <td class="style5">
                    <telerik:RadMaskedTextBox ID="txtbxPersonalNo" Runat="server" 
                        Mask="#############">
                    </telerik:RadMaskedTextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtbxPersonalNo"
                        ErrorMessage="***" ForeColor="Red" ValidationGroup="staffInfo"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Domicile Distt:
                </td>
                <td class="style8">
                    <telerik:RadTextBox ID="txtbxDomicile" runat="server">
                    </telerik:RadTextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtbxDomicile"
                        ErrorMessage="***" ForeColor="Red" ValidationGroup="staffInfo"></asp:RequiredFieldValidator>
                </td>
                <td class="style3">
                    GBF No :
                </td>
                <td class="style5">
                 <telerik:RadMaskedTextBox ID="txtbxGBFNo" Runat="server" 
                        Mask="#############">
                    </telerik:RadMaskedTextBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Qualification :
                </td>
                <td class="style8">
                    <telerik:RadTextBox ID="txtbxQualification" runat="server">
                    </telerik:RadTextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtbxQualification"
                        ErrorMessage="***" ForeColor="Red" ValidationGroup="staffInfo"></asp:RequiredFieldValidator>
                </td>
                <td class="style3">
                    Teaching Staff :
                </td>
                <td class="style5">
                    <telerik:RadComboBox ID="cmbxTeachingStaff" runat="server">
                       
                    </telerik:RadComboBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Date Of Birth :
                </td>
                <td class="style8">
                    <telerik:RadDatePicker ID="DatePickerDateOfBirth" runat="server">
                    </telerik:RadDatePicker>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="DatePickerDateOfBirth"
                        ErrorMessage="***" ForeColor="Red" ValidationGroup="staffInfo"></asp:RequiredFieldValidator>
                </td>
                <td class="style3">
                    Gender :
                </td>
                <td class="style5">
                    <telerik:RadComboBox ID="cmbxGender" runat="server">
                        <Items>
                            <telerik:RadComboBoxItem runat="server" Text="Male" Value="Male" />
                            <telerik:RadComboBoxItem runat="server" Text="Female" Value="Female" />
                        </Items>
                    </telerik:RadComboBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Joining Date :
                </td>
                <td class="style8">
                    <telerik:RadDatePicker ID="DatePickerJoiningDate" runat="server">
                    </telerik:RadDatePicker>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="DatePickerJoiningDate"
                        ErrorMessage="***" ForeColor="Red" ValidationGroup="staffInfo"></asp:RequiredFieldValidator>
                </td>
                <td class="style3">
                    &nbsp;Permanent Date :
                </td>
                <td class="style5">
                    <telerik:RadDatePicker ID="DatePickerPermanentDate" runat="server">
                    </telerik:RadDatePicker>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Joining Present Station :
                </td>
                <td class="style8">
                    <telerik:RadDatePicker ID="DatePickerJoiningPresentStation" runat="server">
                    </telerik:RadDatePicker>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="DatePickerJoiningPresentStation"
                        ErrorMessage="***" ForeColor="Red" ValidationGroup="staffInfo"></asp:RequiredFieldValidator>
                </td>
                <td class="style3">
                    Contract/Permanent :
                </td>
                <td class="style5">
                    <telerik:RadComboBox ID="cmbxContractPermanent" runat="server">
                        <Items>
                            <telerik:RadComboBoxItem runat="server" Text="Permanent" Value="Permanent" />
                            <telerik:RadComboBoxItem runat="server" Text="Contract" Value="Contract" />
                        </Items>
                    </telerik:RadComboBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Current Address :
                </td>
                <td class="style8">
                    <telerik:RadTextBox ID="txtbxCurrentAddress" runat="server" TextMode="MultiLine"
                        Width="227px">
                    </telerik:RadTextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="txtbxCurrentAddress"
                        ErrorMessage="***" ForeColor="Red" ValidationGroup="staffInfo"></asp:RequiredFieldValidator>
                </td>
                <td class="style3">
                    &nbsp;
                </td>
                <td class="style5">
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Permanent Address :
                </td>
                <td class="style8">
                    <telerik:RadTextBox ID="txtbxPermanentAddress" runat="server" TextMode="MultiLine"
                        Width="227px">
                    </telerik:RadTextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="txtbxPermanentAddress"
                        ErrorMessage="***" ForeColor="Red" ValidationGroup="staffInfo"></asp:RequiredFieldValidator>
                </td>
                <td class="style3">
                    &nbsp;
                </td>
                <td class="style5">
                    &nbsp;
                    <telerik:RadButton ID="btnSave" runat="server" OnClick="btnSave_Click" 
                        Text="Save" ValidationGroup="staffInfo" Width="120px">
                    </telerik:RadButton>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;
                </td>
                <td class="style8">
                    &nbsp;
                </td>
                <td class="style3">
                    &nbsp;
                </td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7" colspan="4">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="#3366FF"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
