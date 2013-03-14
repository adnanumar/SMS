using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadButton1_Click(object sender, EventArgs e)
        {
            RadWindowManager1.RadAlert("Welcome Successfull! ", 330, 180, "Title Welcome", "alertCallBackFn","42");

            //switch (e.CommandArgument.ToString())
            //{
            //    case "radalert":
            //        RadWindowManager1.RadAlert("RadAlert is called from the server", 330, 180, "Server RadAlert", "alertCallBackFn", choices.SelectedValue);
            //        break;
            //    case "radconfirm":
            //        RadWindowManager1.RadConfirm("Server radconfirm: Are you sure?", "confirmCallBackFn", 330, 180, null, "Server RadConfirm", choices.SelectedValue);
            //        break;
            //    case "radprompt":
            //        RadWindowManager1.RadPrompt("Server RadPrompt: What is the answer of Life, Universe and Everything?", "promptCallBackFn", 330, 200, null, "Server RadPrompt", "42");
            //        break;
            //}

        }
    }
}