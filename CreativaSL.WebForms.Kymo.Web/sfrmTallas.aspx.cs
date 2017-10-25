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
            if (Request.QueryString["IDProducto"] != null && Request.QueryString["IDColor"] != null)
            {
                string IDProducto = "3C1B8BBD-746B-4C07-BDC6-B219A9F55D96";
                int IDColor = 7;
                //IDProducto = Request.QueryString["IDProducto"].ToString();
                //int.TryParse(Request.QueryString["IDColor"], out IDColor);
                CH_Producto CP = new CH_Producto();
                CP.Color.IdColor = IDColor;
                CP.IdProducto = IDProducto;
                CP.Conexion = Comun.Conexion;/*"Data Source=192.168.1.150;Initial Catalog=CSL_KYMO; user=Leyder; password=12345678; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";*/               
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