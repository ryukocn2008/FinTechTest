using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestASPNETWebApp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHello_Click(object sender, EventArgs e)
        {
            /*
            string script = "alert(\"Hello!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
            */

            string s = "<SCRIPT language='javascript'>alert('Hello!'); </SCRIPT>";
            Type cstype = this.GetType();
            ClientScriptManager cs = this.Page.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());


        }
    }
}