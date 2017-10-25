using CreativaSL.Dll.Kymo.Global;
using CreativaSL.WebForms.Kymo.Web.ClaseAux;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CreativaSL.Dll.Kymo.Negocio;


namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class sfrmContactanos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    CH_Contacto DatosAux = new CH_Contacto { Conexion = Comun.Conexion };
                    EM_ContactoEnviarCorreoNegocio CEN = new EM_ContactoEnviarCorreoNegocio();
                    CEN.ObtenerDatosEnvioCorreo(DatosAux);
                    if (DatosAux.Completado == true)
                    {
                        EM_ContactoCorreo Datos = new EM_ContactoCorreo { Conexion = Comun.Conexion };
                        Datos.Nombre = Request.Form["Nombre"].ToString();
                        Datos.Correo = Request.Form["Correo"].ToString();
                        Datos.Telefono = Request.Form["Telefono"].ToString();
                        Datos.Direccion = Request.Form["Direccion"].ToString();
                        Datos.Mensaje = Request.Form["Mensaje"].ToString();
                        Datos.IdUsuario = "System Web";
                        EM_ContactoCorreoNegocio CCN = new EM_ContactoCorreoNegocio();
                        CCN.A_ContactoCorreo(Datos);
                        if (Datos.Completado == true)
                        {
                            if (!string.IsNullOrEmpty(Datos.Correo))
                            {
                                EnvioCorreo.EnviarCorreo(
                                    DatosAux.CorreoRemitente
                                    , DatosAux.PasswordCorreo
                                    , DatosAux.CorreoDestinatario
                                    , "Mensaje de contacto"
                                    , EnvioCorreo.GenerarHtmlContacto(Datos.Nombre, Datos.Correo, Datos.Telefono, Datos.Direccion, Datos.Mensaje)
                                    , false
                                    , ""
                                    , DatosAux.HtmlText
                                    , DatosAux.HostText
                                    , DatosAux.Puerto
                                    , DatosAux.EnableSSL);
                            }
                        }
                    }
                    else
                    {
                        Response.Redirect("/ErrorPage", true);
                    }
                }
                catch (Exception ex)
                {
                    Response.Redirect("/ErrorPage", true);
                }
            }
        }
    }
}