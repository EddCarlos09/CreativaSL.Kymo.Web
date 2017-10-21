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
    public partial class frmFAQ : System.Web.UI.Page
    {
        public CH_FAQ _dataFaqs = new CH_FAQ(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                _dataFaqs = ObtenerDatosDinamicos();
                if (!_dataFaqs.Completado)
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
        private CH_FAQ ObtenerDatosDinamicos()
        {
            try
            {
                CH_FAQ data = new CH_FAQ { Conexion = Comun.Conexion };
                CH_FAQNegocio faqsNeg = new CH_FAQNegocio();
                return faqsNeg.ObtenerDatosPagFaqs(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}