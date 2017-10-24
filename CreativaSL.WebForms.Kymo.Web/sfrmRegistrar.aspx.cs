using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Negocio;
using System.Globalization;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class sfrmRegistrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EM_Clientes Datos = new EM_Clientes { Conexion = Comun.Conexion };
                CultureInfo esMX = new CultureInfo("es-MX");
                int IDGenero = 0, codigoPos = 0, NExterior = 0, NInterior = 0, IDEstado = 0, IDMunicipio = 0;
                Datos.Nombre = Request.Form["Nombre"].ToString();
                Datos.ApPaterno = Request.Form["ApPaterno"].ToString();
                Datos.ApMaterno = Request.Form["ApMaterno"].ToString();
                DateTime FechaNac;
                DateTime.TryParseExact(Request.Form["datepicker"].ToString(), "MM-dd-yyyy", esMX, System.Globalization.DateTimeStyles.None, out FechaNac);
                int.TryParse(Request.Form["cmbGenero"].ToString(), out IDGenero);
                int.TryParse(Request.Form["CP"].ToString(), out codigoPos);
                string Direcc = Request.Form["Direccion"].ToString();
                int.TryParse(Request.Form["NExtarior"].ToString(), out NExterior);
                int.TryParse(Request.Form["NInterior"].ToString(), out NInterior);
                int.TryParse(Request.Form["cmbEstado"].ToString(), out IDEstado);
                int.TryParse(Request.Form["cmbMunicipio"].ToString(), out IDMunicipio);
                Datos.Colonia = Request.Form["Colonia"].ToString();
                Datos.Telefono = Request.Form["Telefono"].ToString();
                Datos.CorreoElec = Request.Form["Correo"].ToString();
                Datos.Contrasena = Request.Form["Contrasena"].ToString();
                if(NInterior == 0)
                {
                    Datos.Direccion = Direcc + ", N°E: " + NExterior + ", CP: " + codigoPos;
                }
                else
                {
                    Datos.Direccion = Direcc + ", N°E: " + NExterior + ", N°I: " + NInterior + ", CP: " + codigoPos;
                }
                bool Band = false;
                string News = Request.Form["CkRecibir"] != null ? Request.Form["CkRecibir"].ToString() : string.Empty;
                bool.TryParse(News, out Band);
                Datos.IdEstado = IDEstado;
                Datos.Id_Municipio = IDMunicipio;
                Datos.IdGenero = IDGenero;
                Datos.IdPais = 143;
                Datos.IdUsuario = "System Web";
                Datos.NewsLetters = Band;
                EM_ClienteNegocio CN = new EM_ClienteNegocio();
                CN.AC_RegistroClientes(Datos);
            }
        }
    }
}