using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        public CH_Configuracion _dataConfig = new CH_Configuracion();
        protected void Page_Load(object sender, EventArgs e)
        {
            VerificarDatosConfiguracion();
        }

        /// <summary>
        /// Verifica si existe la configuración, de lo contrario, la crea.
        /// Si hay error, enviar a página de errores.
        /// </summary>
        public void VerificarDatosConfiguracion()
        {
            try
            {
                if (ClaseAuxiliar.IsCorrectConfiguration(HttpContext.Current))
                {
                    _dataConfig = (CH_Configuracion)Session["Config"];
                }
                else
                {
                    ClaseAuxiliar.SetConfiguration(HttpContext.Current);
                    if (ClaseAuxiliar.IsCorrectConfiguration(HttpContext.Current))
                    {
                        _dataConfig = (CH_Configuracion)Session["Config"];
                    }
                    else
                    {
                        Response.Redirect("/ErrorPage", true);
                    }
                }
            }
            catch (Exception)
            {
                Response.Redirect("/ErrorPage", true);
            }
        }
        
    }


}