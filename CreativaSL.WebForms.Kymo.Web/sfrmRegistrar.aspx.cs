using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Negocio;
using System.Globalization;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class sfrmRegistrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EM_Clientes Datos = new EM_Clientes { Conexion = Comun.Conexion };
                CultureInfo esMX = new CultureInfo("es-MX");
                int IdGenero = 0;
                Datos.Nombre = Request.Form["Nombre"].ToString();
                Datos.ApPaterno = Request.Form["ApPaterno"].ToString();
                Datos.ApMaterno = Request.Form["ApMaterno"].ToString();
                DateTime FechaNac;
                DateTime.TryParseExact(Request.Form["datepicker"].ToString(), "dd-MM-yyyy", esMX, System.Globalization.DateTimeStyles.None, out FechaNac);
                int.TryParse(Request.Form["cmbGenero"].ToString(), out IdGenero);
                string codigoP = Request.Form["CP"].ToString();
                //Datos.Correo = Request.Form["Correo"].ToString();
                //Datos.Telefono = Request.Form["Telefono"].ToString();
                //Datos.Asunto = Request.Form["Asunto"].ToString();
                //Datos.Mensaje = Request.Form["Mensaje"].ToString();
                //if (!string.IsNullOrEmpty(Datos.Correo))
                //{
                //    EnvioCorreo.EnviarCorreo(
                //        ConfigurationManager.AppSettings.Get("CorreoTxt")
                //        , ConfigurationManager.AppSettings.Get("PasswordTxt")
                //        , Datos.Correo
                //        , "Mensaje de contacto"
                //        , EnvioCorreo.GenerarHtmlContacto(Datos.Nombre, Datos.Correo, Datos.Telefono, Datos.Asunto, Datos.Mensaje)
                //        , false
                //        , ""
                //        , Convert.ToBoolean(ConfigurationManager.AppSettings.Get("HtmlTxt"))
                //        , ConfigurationManager.AppSettings.Get("HostTxt")
                //        , Convert.ToInt32(ConfigurationManager.AppSettings.Get("PortTxt"))
                //        , Convert.ToBoolean(ConfigurationManager.AppSettings.Get("EnableSslTxt")));
                //}
            }
        }
    }
}