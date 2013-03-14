<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="AddSchoolInfo.aspx.cs" Inherits="SMS.AddSchoolInfo" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<script type="text/javascript">
      var imgUrl = null;
    function alertCallBackFn(arg) {
        // radalert("<strong>radalert</strong> returned the following result: <h3 style='color: #ff0000;'>" + arg + "</h3>", null, null, "Result");
    }
    
</script>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="Panel1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl LoadingPanelID="RadAjaxLoadingPanel1" ControlID="Panel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadFormDecorator ID="RadFormDecorator1" DecoratedControls="All" EnableRoundedCorners="true"
        EnableEmbeddedSkins="true" runat="server" />
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
    </telerik:RadWindowManager>
    <asp:Panel ID="Panel1" GroupingText="Add/Edit School Information" runat="server">
        <table>
            <tr>
                <td>
                    Head Name :
                </td>
                <td>
                    <telerik:RadTextBox ID="txtbxHeadName" runat="server">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtbxHeadName"
                        ErrorMessage="***" ForeColor="Red" SetFocusOnError="True" ValidationGroup="schoolinfo"></asp:RequiredFieldValidator>
                </td>
                <td>
                    Head Grade :
                </td>
                <td>
                    <telerik:RadTextBox ID="txtbxHeadGrade" runat="server">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtbxHeadGrade"
                        ErrorMessage="***" ForeColor="Red" SetFocusOnError="True" ValidationGroup="schoolinfo"></asp:RequiredFieldValidator>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Phone No :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxPhoneNo" runat="server" DataType="System.Int32"
                        MaxLength="12">
                        <NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSeparator=""
                            GroupSizes="4"></NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                </td>
                <td>
                    Head Cell No :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxHeadCellNo" runat="server" DataType="System.Int64"
                        MaxLength="12" MinValue="0">
                        <NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSeparator="">
                        </NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtbxHeadCellNo"
                        ErrorMessage="***" ForeColor="Red" SetFocusOnError="True" ValidationGroup="schoolinfo"></asp:RequiredFieldValidator>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    UC No :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxUCNo" runat="server" DataType="System.Int32"
                        MaxLength="5">
                        <NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSeparator="">
                        </NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtbxUCNo"
                        ErrorMessage="***" ForeColor="Red" SetFocusOnError="True" ValidationGroup="schoolinfo"></asp:RequiredFieldValidator>
                </td>
                <td>
                    NA No :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxNANo" runat="server" DataType="System.Int32"
                        MaxLength="5">
                        <NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSeparator="">
                        </NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtbxNANo"
                        ErrorMessage="***" ForeColor="Red" SetFocusOnError="True" ValidationGroup="schoolinfo"></asp:RequiredFieldValidator>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    PP No :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxPPNo" runat="server" DataType="System.Int32"
                        MaxLength="5">
                        <NumberFormat ZeroPattern="n" DecimalDigits="0"></NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtbxPPNo"
                        ErrorMessage="***" ForeColor="Red" SetFocusOnError="True" ValidationGroup="schoolinfo"></asp:RequiredFieldValidator>
                </td>
                <td>
                    Class Rooms :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxClassRooms" runat="server" DataType="System.Int32"
                        MaxLength="3">
                        <NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSeparator="">
                        </NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Rooms :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxRooms" runat="server" DataType="System.Int32"
                        MaxLength="3">
                        <NumberFormat ZeroPattern="n" DecimalDigits="0" GroupSeparator=""></NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                </td>
                <td>
                    Damaged Rooms :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxDamagedRooms" runat="server" DataType="System.Int32"
                        MaxLength="3">
                        <NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSeparator="">
                        </NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Science Rooms :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxScienceRooms" runat="server" DataType="System.Int32"
                        MaxLength="3">
                        <NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSeparator="">
                        </NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                </td>
                <td>
                    Computer Labs :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxComputerLabs" runat="server" DataType="System.Int32"
                        MaxLength="3">
                        <NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSeparator="">
                        </NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Desks :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxDesks" runat="server" DataType="System.Int32"
                        MaxLength="5">
                        <NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSeparator="">
                        </NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                </td>
                <td>
                    Benchs :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxBenchs" runat="server" DataType="System.Int32"
                        MaxLength="5">
                        <NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSeparator="">
                        </NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Chairs :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxChairs" runat="server" DataType="System.Int32"
                        MaxLength="5">
                        <NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSeparator="">
                        </NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                </td>
                <td>
                    Tables :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxTables" runat="server" DataType="System.Int32"
                        MaxLength="5">
                        <NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSeparator="">
                        </NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Toilets :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxToilets" runat="server" DataType="System.Int32"
                        MaxLength="4">
                        <NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSeparator="">
                        </NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Teaching Staff :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxTeachingStaff" runat="server" DataType="System.Int32"
                        MaxLength="5">
                        <NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSeparator="">
                        </NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                </td>
                <td>
                    Non Teaching Staff :
                </td>
                <td>
                    <telerik:RadNumericTextBox ID="txtbxNonTeachingStaff" runat="server" DataType="System.Int32"
                        MaxLength="5">
                        <NumberFormat ZeroPattern="n" DecimalDigits="0" GroupSeparator=""></NumberFormat>
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Total Area :
                </td>
                <td>
                    <telerik:RadTextBox ID="txtbxTotalArea" runat="server">
                    </telerik:RadTextBox>
                </td>
                <td>
                </td>
                <td>
                    Covered Area :
                </td>
                <td>
                    <telerik:RadTextBox ID="txtbxCoveredArea" runat="server">
                    </telerik:RadTextBox>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Unconstructed Area :
                </td>
                <td>
                    <telerik:RadTextBox ID="txtbxUnconstructedArea" runat="server">
                    </telerik:RadTextBox>
                </td>
                <td>
                </td>
                <td>
                    Open Area :
                </td>
                <td>
                    <telerik:RadTextBox ID="txtbxOpenArea" runat="server">
                    </telerik:RadTextBox>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Boundry Area :
                </td>
                <td>
                    <telerik:RadTextBox ID="txtbxBoundaryArea" runat="server">
                    </telerik:RadTextBox>
                </td>
                <td>
                </td>
                <td>
                    Ground Area :
                </td>
                <td>
                    <telerik:RadTextBox ID="txtbxGroundArea" runat="server">
                    </telerik:RadTextBox>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Mosque :
                </td>
                <td>
                    <telerik:RadComboBox ID="cmbxIsMosque" runat="server">
                        
                    </telerik:RadComboBox>
                </td>
                <td>
                </td>
                <td>
                    PlayGround :
                </td>
                <td>
                    <telerik:RadComboBox ID="cmbxIsPlayGround" runat="server">
                        
                    </telerik:RadComboBox>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Boundary Wall :
                </td>
                <td>
                    <telerik:RadComboBox ID="cmbxIsBoundaryWall" runat="server">
                       
                    </telerik:RadComboBox>
                </td>
                <td>
                </td>
                <td>
                    Electricity :
                </td>
                <td>
                    <telerik:RadComboBox ID="cmbxIsElectricity" runat="server">
                        
                    </telerik:RadComboBox>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Telephone Line :
                </td>
                <td>
                    <telerik:RadComboBox ID="cmbxIsTelephoneLine" runat="server">
                       
                    </telerik:RadComboBox>
                </td>
                <td>
                </td>
                <td>
                    Sui Gas :
                </td>
                <td>
                    <telerik:RadComboBox ID="cmbxIsSuiGas" runat="server">
                      
                    </telerik:RadComboBox>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
                <td align="right">
                    <telerik:RadButton ID="btnSave" Width="100px" runat="server" Text="Save" OnClick="btnSave_Click"
                        ValidationGroup="schoolinfo">
                    </telerik:RadButton>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
                <td colspan="4">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="#6666FF"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
