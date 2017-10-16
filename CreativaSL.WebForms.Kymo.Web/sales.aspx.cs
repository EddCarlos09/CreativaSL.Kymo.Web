using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class sales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.RouteData.Values["year"] != null)
            {
                string Aux = Page.RouteData.Values["year"].ToString();
            }
        }

        protected void btnLogOff_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
        }
    }
}