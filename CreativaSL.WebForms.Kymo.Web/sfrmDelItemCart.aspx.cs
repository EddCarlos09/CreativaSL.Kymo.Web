using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Negocio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class sfrmDelItemCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Form["IDProducto"] != null
                    && Request.Form["IDTalla"] != null
                    && Request.Form["IDColor"] != null)
                {
                    string idProducto = Request.Form["IDProducto"].ToString();
                    int idTalla = 0, idColor = 0;
                    int.TryParse(Request.Form["IDTalla"].ToString(), out idTalla);
                    int.TryParse(Request.Form["IDColor"].ToString(), out idColor);
                    CH_VentaDetalle datos = new CH_VentaDetalle();
                    datos.Producto.IdProducto = idProducto;
                    datos.Producto.Talla.IdTalla = idTalla;
                    datos.Producto.Color.IdColor = idColor;
                    string conexion = Comun.Conexion;
                    string idCliente = HttpContext.Current.Profile.UserName;
                    bool esAnonimo = !Request.IsAuthenticated;
                    CH_CarritoNegocio cartNeg = new CH_CarritoNegocio();
                    CH_Carrito resultado = cartNeg.EliminarProductoACarrito(idCliente, esAnonimo, datos, conexion);
                    CultureInfo esMX = new CultureInfo("es-MX");
                    Result dataRes = new Result { resultado = resultado.Resultado,
                        descuento = string.Format(esMX, "{0:c}", resultado.Descuento),
                        total = string.Format(esMX, "{0:c}", resultado.Total),
                        //mensaje = resultado.MensajeError,
                        subtotal = string.Format(esMX, "{0:c}", resultado.Subtotal),
                        id_vale = resultado.IDVale
                    };
                    var json = JsonConvert.SerializeObject(dataRes);
                    Response.Clear();
                    Response.ContentType = "application/text;";
                    Response.Write(json);
                    Response.End();
                }
                else
                {
                    var json = JsonConvert.SerializeObject(new Result { resultado = -10, mensaje = "Se requiere el código del cupón" });
                    Response.Clear();
                    Response.ContentType = "application/text;";
                    Response.Write(json);
                    Response.End();
                }
            }
            else
            {
                var json = JsonConvert.SerializeObject(new Result { resultado = -20, mensaje = "Error al procesar los datos" });
                Response.Clear();
                Response.ContentType = "application/text;";
                Response.Write(json);
                Response.End();
            }
        }
    }
}