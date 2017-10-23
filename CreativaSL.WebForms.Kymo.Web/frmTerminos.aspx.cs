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
    public partial class frmTerminos : System.Web.UI.Page
    {
        public RR_TerminosCondiciones _dataTerminos = new RR_TerminosCondiciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                _dataTerminos = ObtenerDatosDinamicos();
                if (!_dataTerminos.Completado)
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
        private RR_TerminosCondiciones ObtenerDatosDinamicos()
        {
            try
            {
                RR_TerminosCondiciones data = new RR_TerminosCondiciones { Conexion = Comun.Conexion };
                RR_TerminosCondicionesNegocio faqsNeg = new RR_TerminosCondicionesNegocio();
                return faqsNeg.ObtenerDatosTerminosCondiciones(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}