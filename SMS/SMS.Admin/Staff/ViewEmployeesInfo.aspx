<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewEmployeesInfo.aspx.cs" Inherits="SMS.Admin.Staff.ViewEmployeesInfo" %>
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
    <telerik:AjaxSetting AjaxControlID="GVPersonalData">
    <UpdatedControls>
    <telerik:AjaxUpdatedControl LoadingPanelID="RadAjaxLoadingPanel1"  ControlID="GVPersonalData" />
    </UpdatedControls>
    </telerik:AjaxSetting>
    </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadFormDecorator ID="RadFormDecorator1" DecoratedControls="All" EnableRoundedCorners="true" EnableEmbeddedSkins="true" runat="server" />
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server">
    </telerik:RadAjaxLoadingPanel>
    <telerik:RadGrid ID="GVPersonalData" DataSourceID="PersonalDataODS" runat="server"
        AllowPaging="True" CellSpacing="0" GridLines="None" AutoGenerateColumns="False"
        AllowSorting="True" ShowGroupPanel="True" ShowStatusBar="True" ShowHeader="true" 
        OnItemCommand="GVPersonalData_ItemCommand" AllowFilteringByColumn="True" 
        ShowFooter="True">
        <PagerStyle Mode="NextPrevAndNumeric"></PagerStyle>
        <ClientSettings AllowDragToGroup="True" AllowColumnsReorder="True" ReorderColumnsOnClient="True">
            <Selecting AllowRowSelect="True" />
        </ClientSettings>
        <ExportSettings HideStructureColumns="false">
        </ExportSettings>
        <MasterTableView DataSourceID="PersonalDataODS" CommandItemDisplay="TopAndBottom" ShowGroupFooter="true" Width="100%" DataKeyNames="NIC">
            <RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
            </RowIndicatorColumn>
            <ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
            </ExpandCollapseColumn>
            <CommandItemSettings ShowExportToExcelButton="true" ShowAddNewRecordButton="false" ShowRefreshButton="true" ShowExportToWordButton="true" />
            <Columns>
                <telerik:GridBoundColumn DataField="Employee_Name" FilterControlWidth="90px" Aggregate="Count" FooterText="Total Employees : " ShowFilterIcon="true" UniqueName="Employee_Name" HeaderText="Name"
                    MaxLength="50">
                </telerik:GridBoundColumn>
                
                <telerik:GridBoundColumn DataField="Designation" FilterControlWidth="50px" ShowFilterIcon="true" UniqueName="Designation" HeaderText="Designation"
                    MaxLength="50">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Grade" FilterControlWidth="50px" ShowFilterIcon="true" UniqueName="Grade" HeaderText="Grade"
                    MaxLength="50">
                </telerik:GridBoundColumn>
                 <telerik:GridBoundColumn DataField="Qualification" FilterControlWidth="60px" ShowFilterIcon="true" UniqueName="Qualification" HeaderText="Qualification"
                    MaxLength="50">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="NIC" FilterControlWidth="60px" ShowFilterIcon="true" UniqueName="NIC" HeaderText="NIC"
                    MaxLength="50">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Gender" FilterControlWidth="50px" ShowFilterIcon="true" UniqueName="Gender" HeaderText="Gender"
                    MaxLength="50">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Contract_Permanent" FilterControlWidth="50px" ShowFilterIcon="true" UniqueName="Contract_Permanent" HeaderText="Job Type"
                    MaxLength="50">
                </telerik:GridBoundColumn>
                 <telerik:GridBoundColumn DataField="School_Name" FilterControlWidth="90px" ShowFilterIcon="true" UniqueName="School_Name" HeaderText="School"
                    MaxLength="120">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Level_Name" FilterControlWidth="50px" ShowFilterIcon="true" UniqueName="Level_Name" HeaderText="Level"
                    MaxLength="50">
                </telerik:GridBoundColumn>
                 <telerik:GridBoundColumn DataField="T_Name" FilterControlWidth="50px" ShowFilterIcon="true" UniqueName="T_Name" HeaderText="Tehsil"
                    MaxLength="50">
                </telerik:GridBoundColumn>
                 <telerik:GridBoundColumn DataField="IsTeachingStaff" FilterControlWidth="30px" ShowFilterIcon="true" UniqueName="IsTeachingStaff" HeaderText="IsTeachingStaff"
                    MaxLength="30">
                </telerik:GridBoundColumn>
               
                <telerik:GridTemplateColumn AllowFiltering="false">
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <telerik:RadButton ID="btnViewDetail" CommandName="ViewInfo" ButtonType="LinkButton"
                            runat="server" Text="Detail">
                        </telerik:RadButton>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
            </Columns>
            <NestedViewSettings DataSourceID="PersonalDataNestedODS">
                <ParentTableRelation>
                    <telerik:GridRelationFields />
                </ParentTableRelation>
                <ParentTableRelation>
                    <telerik:GridRelationFields DetailKeyField="NIC" MasterKeyField="NIC" />
                </ParentTableRelation>
            </NestedViewSettings>
            <NestedViewTemplate>
               <asp:Panel ID="NestedViewPanel" runat="server" CssClass="viewWrap">
                    <div class="contactWrap">
                        <fieldset style="padding: 10px;">
                            <legend style="padding: 5px;"><b>Personal Information of &nbsp;<%#Eval("Employee_Name")%></b></legend>
                            <table>
                                <tbody>
                                    <tr>
                                        <td>
                                            <table>
                                                <tbody>
                                                    <tr>
                                                        <td>
                                                            Father Name:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="cityLabel" Text='<%#Bind("Father_Name") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Gender :
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label7" Text='<%#Bind("Gender") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Date of Birth :
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label13" Text='<%# Bind("DateOfBirth","{0:dd/MM/yyyy}") %>' runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Designation:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label1" Text='<%#Bind("Designation") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Grade:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label28" Text='<%#Bind("Grade") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Is Teaching Staff:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label10" Text='<%# Convert.ToBoolean(Eval("IsTeachingStaff")) == true ? "Yes" : "No" %>'
                                                                runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Cell No:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label8" Text='<%#Bind("Cell_No") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Office No:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label21" Text='<%#Bind("Office_No") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Home No:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label29" Text='<%#Bind("Residence_No") %>' runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Domicile:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label3" Text='<%#Bind("Domicile") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Personal No:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label15" Text='<%#Bind("Personal_No") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            GBF No:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label9" Text='<%#Bind("GBF_No") %>' runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Email:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label2" Text='<%#Bind("Email") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Service Type:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label4" Text='<%#Bind("Contract_Permanent") %>' runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Joining Date:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label11" Text='<%#Bind("Joining_Date","{0:dd/MM/yyyy}") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Joining Date Present Station:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label12" Text='<%#Bind("JoiningPresSta_Date","{0:dd/MM/yyyy}") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Joining Date as Permanent:
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label14" Text='<%#Bind("JoiningAsPerm_Date","{0:dd/MM/yyyy}") %>' runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Current Address:
                                                        </td>
                                                        <td  colspan="2">
                                                            <asp:Label ID="Label5" Text='<%#Bind("Current_Address") %>' runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                            Permanent Address:
                                                        </td>
                                                        <td  colspan="2">
                                                            <asp:Label ID="Label6" Text='<%#Bind("Perm_Address") %>' runat="server"></asp:Label>
                                                        </td>
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
           <%-- <CommandItemSettings ExportToPdfText="Export to PDF" ExportToCsvImageUrl="mvwres://Telerik.Web.UI, Version=2012.3.1016.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.Grid.ExportToCsv.gif"
                ExportToExcelImageUrl="mvwres://Telerik.Web.UI, Version=2012.3.1016.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.Grid.ExportToExcel.gif"
                ExportToPdfImageUrl="mvwres://Telerik.Web.UI, Version=2012.3.1016.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.Grid.ExportToPdf.gif"
                ExportToWordImageUrl="mvwres://Telerik.Web.UI, Version=2012.3.1016.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.Grid.ExportToWord.gif">
            </CommandItemSettings>--%>
            <EditFormSettings>
                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                </EditColumn>
            </EditFormSettings>
        </MasterTableView>
        <FilterMenu EnableImageSprites="False">
        </FilterMenu>
    </telerik:RadGrid>
    <asp:ObjectDataSource ID="PersonalDataODS" TypeName="SMS.DAL.TeachersDetailInfoManager"
        SelectMethod="PersonalData_GetAllByD_Id" runat="server">
        <SelectParameters>
            <asp:SessionParameter Name="D_Id" DefaultValue="0" SessionField="ApplicationD_Id" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="PersonalDataNestedODS" TypeName="SMS.DAL.TeachersDetailInfoManager"
        SelectMethod="PersonalData_GetAllByNIC" runat="server">
        <SelectParameters>
            <asp:Parameter Name="NIC" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
