<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SMS.WebForm1" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">

    var imgUrl = null;
    function alertCallBackFn(arg) {
       // radalert("<strong>radalert</strong> returned the following result: <h3 style='color: #ff0000;'>" + arg + "</h3>", null, null, "Result");
    }

    function confirmCallBackFn(arg) {
        radalert("<strong>radconfirm</strong> returned the following result: <h3 style='color: #ff0000;'>" + arg + "</h3>", null, null, "Result");
    }

    function promptCallBackFn(arg) {
        radalert("After 7.5 million years, <strong>Deep Thought</strong> answers:<h3 style='color: #ff0000;'>" + arg + "</h3>", null, null, "Deep Thought");
    }

    function pageLoad() {
        //attach a handler to radion buttons to update global variable holding image url
        var $ = $telerik.$;
        $('input:button').bind('click', function () {
            imgUrl = $(this).val();
        });
    }

</script>

<telerik:RadScriptBlock ID="RadScriptBlock1" runat="server">

    <script type="text/javascript">


        function updatePictureAndInfo() {
            var upload = $find("<%=RadAsyncUpload1.ClientID %>");

            if (upload.getUploadedFiles().length > 0 ) {
                __doPostBack('RadButton1', 'RadButton1Args');
            }
            else {
                alert("Please select a picture/country");
            }
        }

    </script>

</telerik:RadScriptBlock>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
    </telerik:RadWindowManager>
    <telerik:RadAsyncUpload ID="RadAsyncUpload1" PostbackTriggers="RadButton1" ManualUpload="false" runat="server" 
        TemporaryFolder="~/App_Data">
    </telerik:RadAsyncUpload>
    <telerik:RadButton ID="RadButton1" OnClientClick="updatePictureAndInfo(); return false;" runat="server" Text="RadButton" 
        onclick="RadButton1_Click">
    </telerik:RadButton>

</asp:Content>
