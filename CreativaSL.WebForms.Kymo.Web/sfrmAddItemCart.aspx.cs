using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Negocio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class sfrmAddItemCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Form["IDProducto"] != null
                    && Request.Form["IDTalla"] != null
                    && Request.Form["IDColor"] != null
                    && Request.Form["Cantidad"] != null)
                {
                    string idProducto = Request.Form["IDProducto"].ToString();
                    int idTalla = 0, idColor = 0, cantidad = 0;
                    int.TryParse(Request.Form["IDTalla"].ToString(), out idTalla);
                    int.TryParse(Request.Form["IDColor"].ToString(), out idColor);
                    int.TryParse(Request.Form["Cantidad"].ToString(), out cantidad);
                    CH_VentaDetalle datos = new CH_VentaDetalle();
                    datos.Producto.IdProducto = idProducto;
                    datos.Producto.Talla.IdTalla = idTalla;
                    datos.Producto.Color.IdColor = idColor;
                    datos.Cantidad = cantidad;
                    string conexion = Comun.Conexion;
                    string idCliente = HttpContext.Current.Profile.UserName;
                    bool esAnonimo = !Request.IsAuthenticated;
                    CH_CarritoNegocio cartNeg = new CH_CarritoNegocio();
                    int resultado = cartNeg.AgregarProductoACarrito(idCliente, esAnonimo, datos, conexion);
                    resultado = 0;
                    var json = JsonConvert.SerializeObject(new Result { resultado = resultado });
                    Response.Clear();
                    Response.ContentType = "application/text;";
                    Response.Write(json);
                    Response.End();
                }
                else
                {
                    var json = JsonConvert.SerializeObject(new Result { resultado = -10 });
                    Response.Clear();
                    Response.ContentType = "application/text;";
                    Response.Write(json);
                    Response.End();
                }
            }
            else
            {
                var json = JsonConvert.SerializeObject(new Result { resultado = -20 });
                Response.Clear();
                Response.ContentType = "application/text;";
                Response.Write(json);
                Response.End();
            }
        }
    }
    struct Result
    {
        public int resultado { get; set; }
    }
}