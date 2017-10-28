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
        public List<EM_Testimoniales> _ListaTestimoniales = new List<EM_Testimoniales>();
        public List<EM_HomeGeneral> _ListaImagenes = new List<EM_HomeGeneral>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                this.BannerInicial();
                this.Patrocinadores();
                this.Testimoniales();
                this.ListaImagenes();
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

        private void Testimoniales()
        {
            EM_Testimoniales DatosTes = new EM_Testimoniales { Conexion = Comun.Conexion};
            EM_HomeNegocio HN = new EM_HomeNegocio();
            this._ListaTestimoniales = HN.ObtenerTestimoniales(DatosTes);
        }

        private void ListaImagenes()
        {
            EM_HomeGeneral DatosGen = new EM_HomeGeneral { Conexion = Comun.Conexion };
            EM_HomeNegocio HN = new EM_HomeNegocio();
            this._ListaImagenes = HN.ListaImagenesGenerales(DatosGen);
        }
    }
}