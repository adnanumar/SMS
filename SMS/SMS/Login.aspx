<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SMS.Login" %>
<%@ Register Src="~/Controls/SchoolLogin.ascx" TagName="schoollogin" TagPrefix="schoollogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<schoollogin:schoollogin ID="schoolloginid" runat="Server" />
</asp:Content>
