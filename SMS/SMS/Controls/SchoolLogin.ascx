<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SchoolLogin.ascx.cs" Inherits="SMS.Controls.SchoolLogin1" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<style type="text/css">
    .style1
    {
        width: 97%;
        float: left;
        height: 104px;
    }
    .style10
    {
        width: 139px;
        height: 20px;
    }
    .style13
    {
        width: 139px;
        height: 29px;
    }
    .style14
    {
        height: 29px;
    }
    .style15
    {
        width: 75px;
        height: 20px;
    }
    .style16
    {
        width: 152px;
        height: 29px;
    }
    .style17
    {
        width: 152px;
        height: 20px;
    }
    .style18
    {
        height: 29px;
        font-weight: bold;
        color: #003399;
        font-size: x-large;
    }
</style>
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
    <asp:Panel ID="Panel1" GroupingText="School Login" Width="400px" Height="300px" runat="server">
<table align="left" class="style1">
    <tr>
        <td class="style14">
            User ID :</td>
        <td class="style16">
            <telerik:RadTextBox ID="txtbxEduSchoolUserName" Width="150px"  runat="server">
            </telerik:RadTextBox>
        </td>
        <td class="style13">
           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="login" ForeColor="Red"  Font-Size="Small" ControlToValidate="txtbxEduSchoolUserName" runat="server" ErrorMessage="User ID required!"></asp:RequiredFieldValidator> 
            
        </td>
    </tr>
    <tr>
        <td class="style14">
            Password :<td class="style16">
                <telerik:RadTextBox ID="txtbxEduSchoolPassword"  Width="150px" TextMode="Password" runat="server">
                </telerik:RadTextBox>
        </td>
        <td class="style13">
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  ValidationGroup="login" Font-Size="Small" 
                ControlToValidate="txtbxEduSchoolPassword" runat="server" 
                ErrorMessage="Password required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
            <caption>
                &nbsp;</caption>
        </td>
    </tr>
    <tr>
        <td class="style15">
            <td align="center" class="style17">
                <telerik:RadButton ID="btnLogin" ValidationGroup="login" runat="server" Text="Sign In" 
                    onclick="btnLogin_Click">
            </telerik:RadButton>

        </td>
        <td class="style10">
            
            </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Label ID="lblError" Font-Size="Small" ForeColor="Red" runat="server" Text=""></asp:Label>
    </tr>
</table>

</asp:Panel>