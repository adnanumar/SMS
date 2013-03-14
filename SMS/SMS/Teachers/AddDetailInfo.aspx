<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDetailInfo.aspx.cs" Inherits="SMS.Teachers.AddDetailInfo" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 76%;
        }
       
        .style2
        {
            width: 80px;
        }
       
    </style>
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
    <telerik:AjaxSetting AjaxControlID="RadPageViewAcademics">
    <UpdatedControls>
    <telerik:AjaxUpdatedControl LoadingPanelID="RadAjaxLoadingPanel1"  ControlID="RadPageViewAcademics" />
    </UpdatedControls>
    </telerik:AjaxSetting>
    </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadFormDecorator ID="RadFormDecorator1" DecoratedControls="All" EnableRoundedCorners="true" EnableEmbeddedSkins="true" runat="server" />
    
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server">
    </telerik:RadAjaxLoadingPanel>
   
 <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
    </telerik:RadWindowManager>
    <telerik:RadTabStrip ID="RadTabStrip1" MultiPageID="RadMultiPag1" 
        EnableDragToReorder="True" runat="server" SelectedIndex="0">
        <Tabs>
            <telerik:RadTab runat="server" Text="Academics" Selected="True">   
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Promotions">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Transfers">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Accounts">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Experiances">
            </telerik:RadTab>
        </Tabs>
     </telerik:RadTabStrip>
     <telerik:RadMultiPage ID="RadMultiPag1" runat="server" SelectedIndex="0">
  
     <telerik:RadPageView ID="RadPageViewAcademics" runat="server"
             Style="overflow: hidden; margin-right: 0px;">
         <telerik:RadGrid ID="academicRG" runat="server" AllowPaging="True" 
             AllowSorting="True" CellSpacing="0" GridLines="None" ShowGroupPanel="True">
             <ClientSettings AllowDragToGroup="True">
             </ClientSettings>
             <MasterTableView>
                 <CommandItemSettings ExportToPdfText="Export to PDF" />
                 <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" 
                     Visible="True">
                     <HeaderStyle Width="20px" />
                 </RowIndicatorColumn>
                 <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                     Visible="True">
                     <HeaderStyle Width="20px" />
                 </ExpandCollapseColumn>
                 <EditFormSettings>
                     <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                     </EditColumn>
                 </EditFormSettings>
             </MasterTableView>
             <FilterMenu EnableImageSprites="False">
             </FilterMenu>
         </telerik:RadGrid>
         <asp:ObjectDataSource ID="academicODS" runat="server">
         
         </asp:ObjectDataSource>

        </telerik:RadPageView>

        <telerik:RadPageView ID="RadPageViewPromotions" runat="server" Style="overflow: hidden">
           
        </telerik:RadPageView>

        <telerik:RadPageView ID="RadPageViewTransfers" runat="server"  Style="overflow: hidden">
            
            
        </telerik:RadPageView>
        <telerik:RadPageView ID="RadPageViewAccountInfo" runat="server"  Style="overflow: hidden">
            
           
        </telerik:RadPageView>
        <telerik:RadPageView ID="RadPageViewExperiences" runat="server"  Style="overflow: hidden">
            
          
        </telerik:RadPageView>
     </telerik:RadMultiPage>

</asp:Content>
