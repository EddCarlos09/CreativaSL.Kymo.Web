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
    public partial class frmRegistrar : System.Web.UI.Page
    {
        public List<EM_Genero> _ListaGenero = new List<EM_Genero>();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        private void CargarComboBox()
        {
            EM_Genero Datos = new EM_Genero { Conexion = Comun.Conexion };
            EM_GeneroNegocio GN = new EM_GeneroNegocio();
            //Lista = GN.ObtenerCatalogoTipoUsuario(Datos);
        }
    }
}