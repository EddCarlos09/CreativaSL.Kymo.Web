using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Negocio;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class sfrmSucribete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    EM_Suscribite Datos = new EM_Suscribite { Conexion = Comun.Conexion };
                    Datos.Correo = Request.Form["Correo"].ToString();
                    Datos.NombreSuscribete = "";
                    Datos.IdUsuario = "System Web";
                    EM_SuscribeteNegocio SN = new EM_SuscribeteNegocio();
                    SN.AC_Sucribirte(Datos);
                }
                catch (Exception)
                {
                    Response.Redirect("/ErrorPage", true);
                }
            }
        }
    }
}