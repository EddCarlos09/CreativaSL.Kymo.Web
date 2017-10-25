using CreativaSL.Dll.Kymo.Global;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CreativaSL.Dll.Kymo.Negocio;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class sfrmMunicipios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["estado"] != null)
            {
                int IDEstado = 0;
                int.TryParse(Request.QueryString["estado"], out IDEstado);
                EM_Municipio Datos = new EM_Municipio();
                Datos.IDEstado = IDEstado;
                Datos.Conexion = Comun.Conexion;/*"Data Source=192.168.1.150;Initial Catalog=CSL_KYMO; user=Leyder; password=12345678; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";*/
                EM_MunicipioNegocio CN = new EM_MunicipioNegocio();
                List<EM_MunicipioJSON> Lista = CN.ObtenerMunicipiosXIDEstado(Datos);
                var json = JsonConvert.SerializeObject(Lista);
                Response.Clear();
                Response.ContentType = "application/text;";
                Response.Write(json);
                Response.End();
            }
        }
    }
}