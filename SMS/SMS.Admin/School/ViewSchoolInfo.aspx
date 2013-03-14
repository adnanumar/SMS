<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewSchoolInfo.aspx.cs" Inherits="SMS.Admin.School.ViewSchoolInfo" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <script type="text/javascript">
        function onRequestStart(sender, args) {
            if (args.get_eventTarget().indexOf("ExportToExcelButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToWordButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToCsvButton") >= 0) {
                args.set_enableAjax(false);
            }
        }
</script>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    <ClientEvents OnRequestStart="onRequestStart" />
    <AjaxSettings>
    <telerik:AjaxSetting AjaxControlID="RGSchoolInfo">
    <UpdatedControls>
    <telerik:AjaxUpdatedControl LoadingPanelID="RadAjaxLoadingPanel1"  ControlID="RGSchoolInfo" />
    </UpdatedControls>
    </telerik:AjaxSetting>
    </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadFormDecorator ID="RadFormDecorator1" DecoratedControls="All" EnableRoundedCorners="true" EnableEmbeddedSkins="true" runat="server" />
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server">
    </telerik:RadAjaxLoadingPanel>

<telerik:RadGrid ID="RGSchoolInfo" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" CellSpacing="0" 
        DataSourceID="ODSSchoolInfo" GridLines="None" ShowGroupPanel="True" 
        onitemcommand="RGSchoolInfo_ItemCommand" AllowFilteringByColumn="True">
    <ClientSettings AllowDragToGroup="True" AllowColumnsReorder="True" 
        ReorderColumnsOnClient="True">
    </ClientSettings>
     <ExportSettings HideStructureColumns="false">
        </ExportSettings>
<MasterTableView DataSourceID="ODSSchoolInfo" CommandItemDisplay="TopAndBottom" ShowFooter="true" ShowGroupFooter="true" DataKeyNames="School_Id">

<CommandItemSettings ShowExportToExcelButton="true" ShowAddNewRecordButton="false" ShowRefreshButton="true" ShowExportToWordButton="true" />

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>
<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="School_Id" DataType="System.Int32" 
            FilterControlAltText="Filter School_Id column" Visible="false" ShowFilterIcon="False" 
            UniqueName="School_Id">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="School_Name" FilterControlWidth="120px" ShowFilterIcon="true" Aggregate="Count" FooterText="Total Schools : " HeaderText="School Name"   
            FilterControlAltText="Filter School_Name column" UniqueName="School_Name">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Email" FilterControlWidth="100px" ShowFilterIcon="true"
            FilterControlAltText="Filter Email column" HeaderText="Email" 
            UniqueName="Email">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Head_Name" FilterControlWidth="80px" ShowFilterIcon="true"
            FilterControlAltText="Filter Head_Name column" HeaderText="Head Name" 
            UniqueName="Head_Name">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Head_Grade" FilterControlWidth="40px" ShowFilterIcon="true"
            FilterControlAltText="Filter Head_Grade column" HeaderText="Head Grade" 
            UniqueName="Head_Grade">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Head_CellNo" FilterControlWidth="60px" ShowFilterIcon="true"
            FilterControlAltText="Filter Head_CellNo column" HeaderText="Phone #" 
            UniqueName="Head_CellNo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="No_TStaff" FilterControlWidth="30px" Aggregate="Sum" FooterText="Total : " ShowFilterIcon="true" 
            FilterControlAltText="Filter No_TStaff column" HeaderText="Teaching" 
            UniqueName="No_TStaff">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="No_NonTStaff" FilterControlWidth="30px" Aggregate="Sum" FooterText="Total : " ShowFilterIcon="true" 
            FilterControlAltText="Filter No_NonTStaff column" HeaderText="Non Teaching" 
            UniqueName="No_NonTStaff">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Level_Name" FilterControlWidth="60px" ShowFilterIcon="true" 
            FilterControlAltText="Filter Level_Name column" HeaderText="Level" 
            UniqueName="Level_Name">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="T_Name" FilterControlWidth="60px" ShowFilterIcon="true"
            FilterControlAltText="Filter T_Name column" HeaderText="Tehsil" 
            UniqueName="T_Name">
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn AllowFiltering="false">
                <HeaderTemplate>
                </HeaderTemplate>
        <ItemTemplate>
                 <telerik:RadButton ID="btnEditInfo" CommandName="EditInfo" ButtonType="LinkButton" runat="server"  Text="Edit">
                 </telerik:RadButton>
        </ItemTemplate>
        </telerik:GridTemplateColumn>
    </Columns>
    <NestedViewSettings DataSourceID="ODSSchoolInfoDetail">
    <ParentTableRelation>
    <telerik:GridRelationFields DetailKeyField="School_Id" MasterKeyField="School_Id" />
    </ParentTableRelation>
    </NestedViewSettings>
    <NestedViewTemplate>
    <asp:Panel ID="NestedViewPanel" runat="server" CssClass="viewWrap">
                    <div class="contactWrap">
                        <fieldset style="padding: 10px;">
                            <legend style="padding: 5px;"><b>Detail info for &nbsp; &nbsp;<%#Eval("School_Name") %></b></legend>
                            <table>
                                <tbody>
                                    <tr>
                                        <td>
                                            <table>
                                                <tbody>
                                                    <tr>
                                                        <td>
                                                            Head Name:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="cityLabel" Text='<%#Bind("Head_Name") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Head Grade:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label1" Text='<%#Bind("Head_Grade") %>' runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Phone No:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label2" Text='<%#Bind("Phone_No") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Head Cell No:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label8" Text='<%#Bind("Head_CellNo") %>' runat="server"></asp:Label>
                                                        </td>

                                                         <td>
                                                            School Code:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label21" Text='<%#Bind("School_Code") %>' runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            UC No:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label3" Text='<%#Bind("UC_No") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            NA No:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label9" Text='<%#Bind("NA_No") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            PP No:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label10" Text='<%#Bind("PP_No") %>' runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            No Class Room:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label4" Text='<%#Bind("No_ClassRoom") %>' runat="server"></asp:Label>
                                                        </td>
                                                         <td>
                                                            No Room:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label11" Text='<%#Bind("No_Room") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            No Damage Room:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label12" Text='<%#Bind("Damage_Room") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            No Toilet:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label14" Text='<%#Bind("No_Toilet") %>' runat="server"></asp:Label>
                                                        </td>
                                                        </tr>
                                                        <tr>
                                                        <td>
                                                            No Desk:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label5" Text='<%#Bind("No_Desk") %>' runat="server"></asp:Label>
                                                        </td>
                                                         <td>
                                                            No Bench:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label13" Text='<%#Bind("No_Desk") %>' runat="server"></asp:Label>
                                                        </td>
                                                       <td>
                                                            No Chair:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label6" Text='<%#Bind("No_Chair") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            No Table:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label15" Text='<%#Bind("No_Tables") %>' runat="server"></asp:Label>
                                                        </td>
                                                        </tr>
                                                       <tr>
                                                        <td>
                                                            Toatl Area:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label7" Text='<%#Bind("Total_Area") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Covered Area:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label16" Text='<%#Bind("Covered_Area") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Unconstructed Area:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label17" Text='<%#Bind("UnconstructedBArea") %>' runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                     <tr>
                                                        
                                                        <td>
                                                            Open Area:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label18" Text='<%#Bind("Open_Area") %>' runat="server"></asp:Label>
                                                        </td>
                                                         <td>
                                                            Boundary Area:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label19" Text='<%#Bind("Boundry_Area") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Ground Area:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label20" Text='<%#Bind("Ground_Area") %>' runat="server"></asp:Label>
                                                        </td
                                                    </tr>
                                                     <tr>
                                                        
                                                        <td>
                                                            Is Mosque:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label22" Text='<%# Convert.ToBoolean(Eval("IsMosque")) == true ? "Yes" : "No" %>' runat="server"></asp:Label>
                                                        </td>
                                                         <td>
                                                            Is Boundary Wall:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label23" Text='<%# Convert.ToBoolean(Eval("IsBoundaryWall")) == true ? "Yes" : "No" %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Is Play Ground:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label24" Text='<%# Convert.ToBoolean(Eval("IsPlayGround")) == true ? "Yes" : "No" %>' runat="server"></asp:Label>
                                                        </td
                                                    </tr>
                                                     <tr>
                                                        
                                                        <td>
                                                            Is Electricity:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label25" Text='<%# Convert.ToBoolean(Eval("IsElectricity")) == true ? "Yes" : "No" %>' runat="server"></asp:Label>
                                                        </td>
                                                         <td>
                                                            Is TelephoneLine:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label26" Text='<%# Convert.ToBoolean(Eval("IsTelephoneLine")) == true ? "Yes" : "No" %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Is SuiGas:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label27" Text='<%# Convert.ToBoolean(Eval("IsSuiGas")) == true ? "Yes" : "No" %>' runat="server"></asp:Label>
                                                        </td
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </fieldset>
                    </div>
                </asp:Panel>
    </NestedViewTemplate>
<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>
</telerik:RadGrid>
<asp:ObjectDataSource ID="ODSSchoolInfo" SelectMethod="SchoolInfo_GetAllByD_Id" TypeName="SMS.DAL.SchoolInfoManager" runat="server">
<SelectParameters>
<asp:SessionParameter Name="D_Id" DbType="Int32" DefaultValue="0" SessionField="ApplicationD_Id" />
</SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="ODSSchoolInfoDetail" SelectMethod="SchoolInfo_GetAllByS_Id" TypeName="SMS.DAL.SchoolInfoManager" runat="server">
<SelectParameters>
<asp:Parameter Name="School_Id" />
</SelectParameters>
</asp:ObjectDataSource>
</asp:Content>

