using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class frmProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            else
            {
                if (Request.Form.Count > 0)
                {
                    if (Request.IsAuthenticated)
                    {
                        try
                        {
                            string ID = HttpContext.Current.Profile.UserName;                            
                            string IDProducto = "0D691CF3-A795-4AD8-B5C2-5240B2851F5F";                            
                            int valor = 0;
                            int.TryParse(Request.Form["ValueHiddenField"], out valor);
                            CH_Cliente Cliente = new CH_Cliente();                            
                            ///IDProducto = Request.Form["IDProducto"].ToString();                                                                                    
                            RR_Valoraciones Datos = new RR_Valoraciones();
                            Datos.ListaProducto.IdProducto = IDProducto;
                            Datos.Valoracion = valor;
                            Datos.IdCliente = ID;
                            Datos.Conexion = Comun.Conexion;
                            RR_ValoracionProductosNegocio VPN = new RR_ValoracionProductosNegocio();
                            VPN.SetCalificacionProductos(Datos);
                        }

                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                    else
                    {
                        Response.Redirect("/Login", true);
                    }                    
                }                                                   
            }
        }
    }
}