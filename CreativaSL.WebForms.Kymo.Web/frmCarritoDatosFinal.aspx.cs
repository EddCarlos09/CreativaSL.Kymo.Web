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
    public partial class frmCarritoDatosFinal : System.Web.UI.Page
    {
        public CH_Carrito _dataCart = new CH_Carrito();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                _dataCart = ObtenerDatosDinamicos();
                if (!_dataCart.Completado)
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
        private CH_Carrito ObtenerDatosDinamicos()
        {
            try
            {
                string conexion = Comun.Conexion;
                string idCliente = HttpContext.Current.Profile.UserName;
                bool esAnonimo = !Request.IsAuthenticated;
                CH_CarritoNegocio cartNeg = new CH_CarritoNegocio();
                return cartNeg.ObtenerDatosPaginaCarrito(idCliente, esAnonimo, conexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}