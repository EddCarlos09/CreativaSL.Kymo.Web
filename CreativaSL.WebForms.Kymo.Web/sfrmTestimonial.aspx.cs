using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Negocio;
using Newtonsoft.Json;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class sfrmTestimonial1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Form["Nombre"] != null && Request.Form["Mensaje"] != null)
                {
                    EM_Testimoniales Datos = new EM_Testimoniales();
                    Datos.NombreCompleto = Request.Form["Nombre"].ToString();
                    Datos.Comentario = Request.Form["Mensaje"].ToString();
                    Datos.IdUsuario = "System Web";
                    Datos.Conexion = Comun.Conexion;
                    EM_TertimonialesNegocio TN = new EM_TertimonialesNegocio();
                    TN.A_Testimoniales(Datos);
                    if (Datos.Completado == true)
                    {
                        var json = JsonConvert.SerializeObject(new Resultado2 { resultado = Datos.Resultado });
                        Response.Clear();
                        Response.ContentType = "application/text;";
                        Response.Write(json);
                        Response.End();
                    }
                    else
                    {
                        var json = JsonConvert.SerializeObject(new Resultado2 { resultado = Datos.Resultado });
                        Response.Clear();
                        Response.ContentType = "application/text;";
                        Response.Write(json);
                        Response.End();
                    }
                }
                else
                {
                    var json = JsonConvert.SerializeObject(new Resultado2 { resultado = -10 });
                    Response.Clear();
                    Response.ContentType = "application/text;";
                    Response.Write(json);
                    Response.End();
                }
            }
            else
            {
                var json = JsonConvert.SerializeObject(new Resultado2 { resultado = -20 });
                Response.Clear();
                Response.ContentType = "application/text;";
                Response.Write(json);
                Response.End();
            }
        }
    }
    struct Resultado2
    {
        public int resultado { get; set; }
    }
}