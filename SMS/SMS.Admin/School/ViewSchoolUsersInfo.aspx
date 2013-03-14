<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ViewSchoolUsersInfo.aspx.cs" Inherits="SMS.Admin.School.ViewSchoolUsersInfo" %>

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
                    <telerik:AjaxUpdatedControl LoadingPanelID="RadAjaxLoadingPanel1" ControlID="RGSchoolInfo" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadFormDecorator ID="RadFormDecorator1" DecoratedControls="All" EnableRoundedCorners="true"
        EnableEmbeddedSkins="true" runat="server" />
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server">
    </telerik:RadAjaxLoadingPanel>
    <telerik:RadGrid ID="RGSchoolInfo" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="ODSSchoolUsersInfo"
        GridLines="None" ShowGroupPanel="True" AutoGenerateEditColumn="True" OnUpdateCommand="RGSchoolInfo_UpdateCommand"
        OnDataBound="RGSchoolInfo_DataBound" AllowFilteringByColumn="True" OnItemCommand="RGSchoolInfo_ItemCommand">
        <ClientSettings AllowDragToGroup="True" AllowColumnsReorder="True" ReorderColumnsOnClient="True">
        </ClientSettings>
        <MasterTableView DataSourceID="ODSSchoolUsersInfo" ShowFooter="true" ShowGroupFooter="true" CommandItemDisplay="TopAndBottom">
            <CommandItemSettings ShowExportToExcelButton="true" ShowAddNewRecordButton="false"
                ShowRefreshButton="true" ShowExportToWordButton="true" />
            <RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
                <HeaderStyle Width="20px"></HeaderStyle>
            </RowIndicatorColumn>
            <ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
                <HeaderStyle Width="20px"></HeaderStyle>
            </ExpandCollapseColumn>
            <Columns>
                <telerik:GridBoundColumn DataField="U_Id" DataType="System.Int32" UniqueName="U_Id"
                    Visible="False" ReadOnly="True">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="School_Name" Aggregate="Count" FooterText="Total Users : "  FilterControlWidth="120px" ShowFilterIcon="true"
                    HeaderText="School Name" FilterControlAltText="Filter School_Name column" UniqueName="School_Name"
                    ReadOnly="True">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="User_Name" FilterControlWidth="60px" ShowFilterIcon="true"
                    FilterControlAltText="Filter Email column" HeaderText="User Name" UniqueName="User_Name"
                    ReadOnly="True">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="User_Password" FilterControlWidth="50px" ShowFilterIcon="true"
                    HeaderText="Password" UniqueName="User_Password">
                </telerik:GridBoundColumn>
                <telerik:GridTemplateColumn DataField="IsActive" HeaderText="Status">
                    <ItemTemplate>
                        <asp:Label ID="lblStatus" runat="server" Text='<%# Convert.ToBoolean(Eval("IsActive")) == true ? "Active" : "In Active" %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <telerik:RadComboBox ID="cmbxStatus" Width="140px" runat="server">
                            <Items>
                                <telerik:RadComboBoxItem Text="Active" Value="True" />
                                <telerik:RadComboBoxItem Text="In Active" Value="False" />
                            </Items>
                        </telerik:RadComboBox>
                    </EditItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridBoundColumn DataField="LastLogin_Date" FilterControlWidth="70px" ShowFilterIcon="true"
                    HeaderText="Last Login" UniqueName="LastLogin_Date" ReadOnly="True">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="T_Name" FilterControlWidth="70px" ShowFilterIcon="true" HeaderText="Tehsil" UniqueName="T_Name"
                    ReadOnly="True">
                </telerik:GridBoundColumn>
            </Columns>
            <EditFormSettings>
                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                </EditColumn>
            </EditFormSettings>
        </MasterTableView>
        <FilterMenu EnableImageSprites="False">
        </FilterMenu>
    </telerik:RadGrid>
    <asp:ObjectDataSource ID="ODSSchoolUsersInfo" SelectMethod="SchoolUsersInfo_GetAllByD_Id"
        TypeName="SMS.DAL.SchoolInfoManager" runat="server">
        <SelectParameters>
            <asp:SessionParameter Name="D_Id" DbType="Int32" DefaultValue="0" SessionField="ApplicationD_Id" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
