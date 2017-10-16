using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class frmTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.IsAuthenticated)
                {
                    CustomIdentity ident = User.Identity as CustomIdentity;
                    if (ident != null)
                        Label1.Text += string.Format("ID: {0}, Nombre: {1}, Tipo: {2}",
                            ident.DatosUsuario.IdUsuario,
                            ident.DatosUsuario.Nombre,
                            ident.DatosUsuario.IdTipoUsuario);
                }
            }
        }

        protected void btnLogOff_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            //FormsAuthentication.RedirectToLoginPage();
        }
    }
}