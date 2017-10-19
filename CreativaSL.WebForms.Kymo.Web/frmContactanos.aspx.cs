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
    public partial class frmContactanos : System.Web.UI.Page
    {
        public CH_Contacto _dataContact = new CH_Contacto();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                _dataContact = ObtenerDatosDinamicos();
                if(!_dataContact.Completado)
                {
                    Response.Redirect("/ErrorPage", true);
                }

                if(_dataContact.Latitud == 0) _dataContact.Latitud = 23.8103;
                if(_dataContact.Longitud == 0) _dataContact.Longitud = 90.4125;
            }
            catch(Exception)
            {
                Response.Redirect("/ErrorPage", true);
            }
        }

        /// <summary>
        /// Obtener los datos para presentar la página Web de contacto
        /// </summary>
        private CH_Contacto ObtenerDatosDinamicos()
        {
            try
            {
                CH_Contacto data = new CH_Contacto { Conexion = Comun.Conexion };
                CH_ContactoNegocio contactNeg = new CH_ContactoNegocio();
                return contactNeg.ObtenerDatosPagContacto(data);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}