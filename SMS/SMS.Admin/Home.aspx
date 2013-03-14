<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SMS.Admin.Home" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" 
   runat="server">
  
    <telerik:RadPanelBar ID="RadPanelBar1"  ExpandMode="FullExpandedItem" 
        runat="server" DataSourceID="AdminPanelBarODS" DataFieldID="Menu_Id" 
        DataFieldParentID="Menu_Parent_Id" DataNavigateUrlField="Menu_Url" 
        DataTextField="Menu_Name">    
   </telerik:RadPanelBar>
    <asp:ObjectDataSource ID="AdminPanelBarODS" runat="server" TypeName="SMS.DAL.AdminMenuesManager"
     SelectMethod="AdminMenues_GetAllByRoleId">
     <SelectParameters>
     <asp:SessionParameter Name="RoleId" DefaultValue="0" SessionField="ApplicationR_Id" DbType="Int32" />
     </SelectParameters>
     </asp:ObjectDataSource>
</asp:Content>
