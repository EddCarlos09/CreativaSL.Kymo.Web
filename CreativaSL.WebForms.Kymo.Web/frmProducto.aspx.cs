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
    public partial class frmProducto : System.Web.UI.Page
    {
        public CH_Producto _dataProduct = new CH_Producto();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.RouteData.Values["id"] != null)
                {
                    string idProducto = Page.RouteData.Values["id"].ToString();
                    _dataProduct = ObtenerDatosProducto(idProducto);
                    if(!_dataProduct.Completado)
                    {
                        Response.Redirect("/ErrorPage", true);
                    }
                }
                else
                {
                    Response.Redirect("/Home", true);
                }
            }
            catch (Exception)
            { }
        }

        public CH_Producto ObtenerDatosProducto(string _idProducto)
        {
            try
            {
                CH_Producto data = new CH_Producto { IdProducto = _idProducto, Conexion = Comun.Conexion };
                CH_ProductoNegocio prodNeg = new CH_ProductoNegocio();
                return prodNeg.ObtenerDetalleProductoXID(data);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}