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
    public partial class frmNosotros : System.Web.UI.Page
    {
        public CH_Nosotros _dataAboutUs = new CH_Nosotros();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                _dataAboutUs = ObtenerDatosDinamicos();
                if (!_dataAboutUs.Completado)
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
        private CH_Nosotros ObtenerDatosDinamicos()
        {
            try
            {
                CH_Nosotros data = new CH_Nosotros { Conexion = Comun.Conexion };
                CH_NosotrosNegocio aboutUsNeg = new CH_NosotrosNegocio();
                return aboutUsNeg.ObtenerDatosPagNosotros(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}