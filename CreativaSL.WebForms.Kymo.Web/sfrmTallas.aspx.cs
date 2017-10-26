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
    public partial class sfrmTallas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Form["IDProducto"] != null && Request.Form["IDColor"] != null)
                {
                    string IDProducto = "";
                    int IDColor = 0;
                    IDProducto = Request.Form["IDProducto"].ToString();
                    int.TryParse(Request.Form["IDColor"], out IDColor);
                    CH_Producto CP = new CH_Producto();
                    CP.Color.IdColor = IDColor;
                    CP.IdProducto = IDProducto;
                    CP.Conexion = Comun.Conexion;
                    RR_TallasNegocio CN = new RR_TallasNegocio();
                    List<RR_TallasJson> Lista = CN.ObtenerTallasXIDColorProducto(CP);
                    var json = JsonConvert.SerializeObject(Lista);
                    Response.Clear();
                    Response.ContentType = "application/text;";
                    Response.Write(json);
                    Response.End();
                }
            }
        }
    }
}