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
    public partial class sfrmDelCupon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string conexion = Comun.Conexion;
                string idCliente = HttpContext.Current.Profile.UserName;
                bool esAnonimo = !Request.IsAuthenticated;
                CH_CarritoNegocio cartNeg = new CH_CarritoNegocio();
                CH_Carrito resultado = cartNeg.EliminarCuponACarrito(idCliente, esAnonimo, conexion);
                CultureInfo esMX = new CultureInfo("es-MX");
                Result dataRes = new Result { resultado = resultado.Resultado, descuento = string.Format(esMX, "{0:c}", resultado.Descuento), total = string.Format(esMX, "{0:c}", resultado.Total), mensaje = resultado.MensajeError, subtotal = string.Empty };
                var json = JsonConvert.SerializeObject(dataRes);
                Response.Clear();
                Response.ContentType = "application/text;";
                Response.Write(json);
                Response.End();
            }
            else
            {
                var json = JsonConvert.SerializeObject(new Result { resultado = -10, mensaje = "Error al procesar los datos", total = string.Empty, descuento = string.Empty });
                Response.Clear();
                Response.ContentType = "application/text;";
                Response.Write(json);
                Response.End();
            }
        }
    }
}