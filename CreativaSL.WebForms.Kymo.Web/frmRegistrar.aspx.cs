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
        public List<EM_Estado> _ListaEstado = new List<EM_Estado>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                this.CargarComboBox();
                this.CargarComboEstado();
            }
            catch (Exception)
            {
                Response.Redirect("/ErrorPage", true);
            }
        }

        private void CargarComboBox()
        {
            EM_Genero Datos = new EM_Genero { Conexion = Comun.Conexion };
            EM_GeneroNegocio GN = new EM_GeneroNegocio();
            this._ListaGenero = GN.ObtenerGeneroCombo(Datos);
        }
        private void CargarComboEstado()
        {
            EM_Estado Datos = new EM_Estado { Conexion = Comun.Conexion, IdPais = 143 };
            EM_EstadoNegocio EN = new EM_EstadoNegocio();
            this._ListaEstado = EN.ObtenerComboEstados(Datos);
        }
    }
}