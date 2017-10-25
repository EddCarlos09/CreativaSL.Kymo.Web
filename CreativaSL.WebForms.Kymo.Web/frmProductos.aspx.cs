using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class frmProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.Count > 0)
            {
                try
                {
                    var valor = Request.Form["ctl00$cph_MasterBody$valorEstrella"].ToString();
                }

                catch(Exception ex)
                {
                    throw ex;
                }
                
            }

            valorEstrella.Value = "";
        }
    }
}