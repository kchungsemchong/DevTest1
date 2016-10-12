using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Services;

namespace DevTest1
{
    [System.Web.Script.Services.ScriptService]
    public partial class AjaxTest : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat= ResponseFormat.Json)]
        public static string HelloWorld()
        {
            string msg = "test";
            return msg;
        }
    }
}