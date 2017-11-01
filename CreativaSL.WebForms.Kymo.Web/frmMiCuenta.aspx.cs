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
    public partial class frmMiCuenta : System.Web.UI.Page
    {
        public RR_MiCuenta _listaCliente = new RR_MiCuenta();
        public RR_Pedido _listaPedido = new RR_Pedido();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.IsAuthenticated)
                {
                    string ID = HttpContext.Current.Profile.UserName;                    
                    RR_MiCuenta Datos = new RR_MiCuenta();
                    Datos.Cliente.IdCliente = ID;
                    Datos.Conexion = Comun.Conexion;
                    RR_MiCuentaNegocio MCN = new RR_MiCuentaNegocio();
                    //_listaCliente = MCN.ObtenerDatosCuenta(Datos);

                    string IDCliente = HttpContext.Current.Profile.UserName; //0AB7F66C-CA9D-4C88-BFE3-F8A38D6FD05C
                    RR_Pedido DatoPedido = new RR_Pedido();
                    DatoPedido.Cliente.IdCliente = IDCliente;
                    DatoPedido.Conexion = Comun.Conexion;
                    _listaPedido =  MCN.ObtenerPedidosCliente(DatoPedido);
                }
            }
        }            
    }
}