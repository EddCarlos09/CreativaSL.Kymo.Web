using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class frmTestUrl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.RouteData.Values["id"] != null)
            {
                string ID2 = Page.RouteData.Values["ID"].ToString();
            }
            if (Page.RouteData.Values["op"] != null)
            {
                string op = Page.RouteData.Values["op"].ToString();
            }
        }
    }
}