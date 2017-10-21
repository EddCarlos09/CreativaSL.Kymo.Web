using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class frmDefault : System.Web.UI.Page
    {
        public List<EM_HomeBanner> _ListaBanner = new List<EM_HomeBanner>();
        public List<EM_Patrocinadores> _ListaPatrocinadores = new List<EM_Patrocinadores>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                this.BannerInicial();
                this.Patrocinadores();
            }
            catch (Exception)
            {
                Response.Redirect("/ErrorPage", true);
            }

        }

        private void BannerInicial()
        {
            EM_HomeBanner DatosAux = new EM_HomeBanner { Conexion = Comun.Conexion};
            EM_HomeNegocio HN = new EM_HomeNegocio();
            this._ListaBanner = HN.ObtenerListaBanner(DatosAux);
        }

        private void Patrocinadores()
        {
            EM_Patrocinadores DatosPatro = new EM_Patrocinadores { Conexion = Comun.Conexion };
            EM_HomeNegocio HN = new EM_HomeNegocio();
            this._ListaPatrocinadores = HN.ObtenerPatrocinadores(DatosPatro);
        }
    }
}