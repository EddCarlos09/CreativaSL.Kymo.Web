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
    public partial class frmProductos : System.Web.UI.Page
    {
        public CH_Busqueda _datosBusqueda = new CH_Busqueda();   
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string ID = HttpContext.Current.Profile.UserName;
                if (Page.RouteData.Values["tipo"] != null)
                {
                    string tipoBusqueda = Page.RouteData.Values["tipo"].ToString();
                    int idTipoBusqueda = 0;
                    bool esHombre = false, esMujer = false, esAccesorio = false;
                    switch (tipoBusqueda.ToUpper())
                    {
                        case "HOMBRE": idTipoBusqueda = 1; esHombre = true; break;
                        case "MUJER": idTipoBusqueda = 2; esMujer = true; break;
                        case "ACCESORIOS": idTipoBusqueda = 3; esAccesorio = true; break;
                        default: idTipoBusqueda = 4; break;
                    }
                    int id_talla = 0;
                    if (Request.QueryString["TL"] != null)
                        int.TryParse(Request.QueryString["TL"].ToString(), out id_talla);
                    int id_color = 0;
                    if (Request.QueryString["CL"] != null)
                        int.TryParse(Request.QueryString["CL"].ToString(), out id_color);
                    int id_familia = 0;
                    if (Request.QueryString["CT"] != null)
                        int.TryParse(Request.QueryString["CT"].ToString(), out id_familia);
                    int numPage = 1;
                    if (Request.QueryString["NP"] != null)
                        int.TryParse(Request.QueryString["NP"].ToString(), out numPage);
                    int maxRows = 10;
                    if (Request.QueryString["MR"] != null)
                        int.TryParse(Request.QueryString["MR"].ToString(), out maxRows);
                    decimal precioInicial = 0;
                    if (Request.QueryString["PI"] != null)
                        decimal.TryParse(Request.QueryString["PI"].ToString(), out precioInicial);
                    decimal precioFinal = 0;
                    if (Request.QueryString["PF"] != null)
                        decimal.TryParse(Request.QueryString["PF"].ToString(), out precioFinal);
                    int tipoOrden = -1;
                    if (Request.QueryString["OB"] != null)
                        int.TryParse(Request.QueryString["OB"].ToString(), out tipoOrden);
                    CH_Busqueda datosBusqueda = new CH_Busqueda();
                    datosBusqueda.TipoOrden = tipoOrden;
                    datosBusqueda.IdTipoBusqueda = idTipoBusqueda;
                    datosBusqueda.NumPagina = numPage;
                    datosBusqueda.MaxRows = maxRows;
                    datosBusqueda.BandFamilia = id_familia > 0;
                    datosBusqueda.Familia.IdFamilia = id_familia;
                    datosBusqueda.Hombre = esHombre;
                    datosBusqueda.Mujer = esMujer;
                    datosBusqueda.Accesorio = esAccesorio;
                    datosBusqueda.BandTalla = id_talla > 0;
                    datosBusqueda.Talla.IdTalla = id_talla;
                    datosBusqueda.BandColor = id_color > 0;
                    datosBusqueda.Color.IdColor = id_color;
                    datosBusqueda.BandRangoPrecios = precioFinal > 0;
                    datosBusqueda.PrecioInicial = precioInicial;
                    datosBusqueda.PrecioFinal = precioFinal;
                    _datosBusqueda = this.ObtenerDatosDinamicos(datosBusqueda);
                    if (!_datosBusqueda.Completado)
                    {
                        Response.Redirect("/ErrorPage", true);
                    }
                }
                else
                {
                    Response.Redirect("/ErrorPage", true);
                }
            }
            catch(Exception)
            {
                Response.Redirect("/ErrorPage", true);
            }
        }

        /// <summary>
        /// Obtener los datos para presentar la página Web de búsqueda de productos
        /// </summary>
        private CH_Busqueda ObtenerDatosDinamicos(CH_Busqueda _data)
        {
            try
            {
                _data.Conexion = Comun.Conexion;
                CH_ProductoNegocio productNeg = new CH_ProductoNegocio();
                return productNeg.ObtenerDatosProductos(_data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}