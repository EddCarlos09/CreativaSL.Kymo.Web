using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class frmAviso : System.Web.UI.Page
    {
        public RR_AvisoPrivacidad _dataAviso = new RR_AvisoPrivacidad();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                _dataAviso = ObtenerDatosDinamicos();
                if (!_dataAviso.Completado)
                {
                    Response.Redirect("/ErrorPage", true);
                }
            }
            catch (Exception)
            {
                Response.Redirect("/ErrorPage", true);
            }
        }

        /// <summary>
        /// Obtener los datos para presentar la página Web de nosotros
        /// </summary>
        private RR_AvisoPrivacidad ObtenerDatosDinamicos()
        {
            try
            {
                RR_AvisoPrivacidad data = new RR_AvisoPrivacidad { Conexion = Comun.Conexion };
                RR_AvisosPrivacidadNegocio faqsNeg = new RR_AvisosPrivacidadNegocio();
                return faqsNeg.ObtenerDatosPagAvisos(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}