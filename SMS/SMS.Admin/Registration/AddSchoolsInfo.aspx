<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddSchoolsInfo.aspx.cs" Inherits="SMS.Admin.Registration.AddSchoolsInfo" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

    <style type="text/css">
        .style1
        {
            width: 100%;
            float: left;
        }
        .style2
        {
            width: 128px;
        }
        .style3
        {
            width: 318px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
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
    <asp:Panel ID="Panel1" GroupingText="Add/Edit School Information" runat="server">

    <table align="left" class="style1">
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                School Name :</td>
            <td class="style3">
                <telerik:RadTextBox ID="txtbxSchoolName" Runat="server" Width="160px">
                </telerik:RadTextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtbxSchoolName" ErrorMessage="value required!" 
                    Font-Size="Small" ForeColor="Red" SetFocusOnError="True" 
                    ValidationGroup="schoolInfo"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Email :</td>
            <td class="style3">
                <telerik:RadTextBox ID="txtbxEmail" Runat="server" Width="160px">
                </telerik:RadTextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtbxEmail" ErrorMessage="value required!" Font-Size="Small" 
                    ForeColor="Red" SetFocusOnError="True" ValidationGroup="schoolInfo"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                EMIS Code :</td>
            <td class="style3">
                <telerik:RadNumericTextBox ID="txtbxEMISCode" Runat="server" Width="160px" 
                    DataType="System.Int32" MaxLength="8">
<NumberFormat ZeroPattern="n" AllowRounding="False" DecimalDigits="0" GroupSizes="8"></NumberFormat>
                </telerik:RadNumericTextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtbxEMISCode" ErrorMessage="value required!" 
                    Font-Size="Small" ForeColor="Red" SetFocusOnError="True" 
                    ValidationGroup="schoolInfo"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Level :</td>
            <td class="style3">
                <telerik:RadComboBox ID="cmbxLevel" Runat="server">
                </telerik:RadComboBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Tehsil :</td>
            <td class="style3">
                <telerik:RadComboBox ID="cmbxTehsil" Runat="server">
                </telerik:RadComboBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                District :</td>
            <td class="style3">
                <telerik:RadComboBox ID="cmbxDistrict" Runat="server" AccessibilityMode="True">
                </telerik:RadComboBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <telerik:RadButton ID="btnAdd" runat="server" Text="Save" 
                    onclick="btnAdd_Click" ValidationGroup="schoolInfo">
                </telerik:RadButton>
            </td>
            <td>
                <asp:Label ID="lblMessage" runat="server" ForeColor="#0066FF"></asp:Label>
            </td>
        </tr>
    </table>
    </asp:Panel>
</asp:Content>
