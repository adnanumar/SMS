<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SMS.Home" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<div align="left">
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
    <asp:Panel ID="Panel1" GroupingText="Menu" runat="server">

    <telerik:RadPanelBar ID="SchoolPanelBar" runat="server" ExpandMode="FullExpandedItem"
     DataSourceID="SchoolPanelBarODS" DataFieldID="Menu_Id" 
        DataFieldParentID="Menu_Parent_Id" DataNavigateUrlField="Menu_Url" 
        DataTextField="Menu_Name" >
    </telerik:RadPanelBar>
    <asp:ObjectDataSource ID="SchoolPanelBarODS" runat="server" TypeName="SMS.DAL.SchoolMenuesManager"
     SelectMethod="SchoolMenuesGetAllRoleId">
     <SelectParameters>
     <asp:SessionParameter Name="RoleId" DefaultValue="0" SessionField="SchoolR_Id" DbType="Int32" />
     </SelectParameters>
     </asp:ObjectDataSource>
         </asp:Panel>
     </div>
</asp:Content>
