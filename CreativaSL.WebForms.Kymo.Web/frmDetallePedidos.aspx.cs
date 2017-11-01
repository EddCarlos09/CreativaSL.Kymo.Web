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
    public partial class frmDetallePedidos : System.Web.UI.Page
    {
        public RR_Pedido PedidoDetalle = new RR_Pedido();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.IsAuthenticated)
                {
                    if (Request.QueryString["op"] != null)
                    {
                        if (Request.QueryString["op"] == "2")
                        {
                            if (Request.QueryString["id"] != null)
                            {
                                string IDVenta = Request.QueryString["id"].ToString() != null ? Request.QueryString["id"].ToString() : string.Empty;
                                if (Request.QueryString["id"].ToString() == IDVenta)
                                {
                                    string IDCliente = HttpContext.Current.Profile.UserName;
                                    RR_Pedido Datos = new RR_Pedido();
                                    Datos.Cliente.IdCliente = IDCliente;
                                    Datos.VentaDetalle.IdCarritoDetalle = IDVenta;
                                    Datos.Conexion = Comun.Conexion;
                                    RR_MiCuentaNegocio MCN = new RR_MiCuentaNegocio();
                                    PedidoDetalle = MCN.ObtenerDetallePedidosCliente(Datos);
                                }
                                else
                                {

                                }
                            }
                            else
                            {

                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}