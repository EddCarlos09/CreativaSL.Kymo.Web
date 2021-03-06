﻿using CreativaSL.Dll.Kymo.Global;
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
    public partial class sfrmPrecioProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["IDProducto"] != null && Request.QueryString["IDColor"] != null && Request.QueryString["IDTalla"] != null)
            {
                string IDProducto = "";
                int IDColor = 0;
                int IDTalla = 0;
                IDProducto = Request.QueryString["IDProducto"].ToString();
                int.TryParse(Request.QueryString["IDColor"], out IDColor);
                int.TryParse(Request.QueryString["IDTalla"], out IDTalla);
                CH_Producto CP = new CH_Producto();
                CP.Color.IdColor = IDColor;
                CP.Talla.IdTalla = IDTalla;
                CP.IdProducto = IDProducto;
                CP.Conexion = Comun.Conexion;/*"Data Source=192.168.1.150;Initial Catalog=CSL_KYMO; user=Leyder; password=12345678; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";*/
                RR_PrecioProductosNegocio PN = new RR_PrecioProductosNegocio();
                List<RR_PrecioJson> Lista = PN.ObtenerPrecioProducto(CP);
                var json = JsonConvert.SerializeObject(Lista);
                Response.Clear();
                Response.ContentType = "application/text;";
                Response.Write(json);
                Response.End();
            }
                
            
        }
    }
}