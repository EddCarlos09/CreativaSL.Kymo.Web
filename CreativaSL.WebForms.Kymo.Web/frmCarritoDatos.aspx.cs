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
    public partial class frmCarritoDatos : System.Web.UI.Page
    {
        public List<EM_Genero> _ListaGenero = new List<EM_Genero>();
        public List<EM_Estado> _ListaEstado = new List<EM_Estado>();
        public CH_Carrito _dataCart = new CH_Carrito();
        public int IDGenero = 0, IDEstado = 0, IDMunicipio = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                this.CargarComboBox();
                this.CargarComboEstado();
                _dataCart = ObtenerDatosDinamicos();
                EM_Clientes Cliente = new EM_Clientes();
                Cliente.Conexion = Comun.Conexion;
                Cliente.IdCliente = HttpContext.Current.Profile.UserName;
                bool esAnonimo = !Request.IsAuthenticated;
                if (esAnonimo == true)
                {
                    this.IniciarDatos();
                }
                else
                {
                    EM_ClienteNegocio CN = new EM_ClienteNegocio();
                    CN.ObtenerCliente(Cliente);
                    this.CargarDatos(Cliente);
                }
                if (!_dataCart.Completado)
                {
                    Response.Redirect("/ErrorPage", true);
                }
            }
            catch (Exception)
            {
                Response.Redirect("/ErrorPage", true);
            }
        }
        /// <summary>
        /// Obtener los datos para presentar la página Web de nosotros
        /// </summary>
        private CH_Carrito ObtenerDatosDinamicos()
        {
            try
            {
                string conexion = Comun.Conexion;
                string idCliente = HttpContext.Current.Profile.UserName;
                bool esAnonimo = !Request.IsAuthenticated;
                CH_CarritoNegocio cartNeg = new CH_CarritoNegocio();
                return cartNeg.ObtenerDatosPaginaCarrito(idCliente, esAnonimo, conexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Obtener los datos para el combox de genero
        /// </summary>
        private void CargarComboBox()
        {
            EM_Genero Datos = new EM_Genero { Conexion = Comun.Conexion };
            EM_GeneroNegocio GN = new EM_GeneroNegocio();
            this._ListaGenero = GN.ObtenerGeneroCombo(Datos);
        }
        /// <summary>
        /// Obtener los datos de el combox de estado 
        /// </summary>
        private void CargarComboEstado()
        {
            EM_Estado Datos = new EM_Estado { Conexion = Comun.Conexion, IdPais = 143 };
            EM_EstadoNegocio EN = new EM_EstadoNegocio();
            this._ListaEstado = EN.ObtenerComboEstados(Datos);
        }
        /// <summary>
        /// Pintar los datos del cliente logeado
        /// </summary>
        /// <param name="DatosAux">Datos del cliente</param>
        private void CargarDatos(EM_Clientes DatosAux)
        {
            try
            {
                this.Nombre.Value = DatosAux.Nombre;
                this.ApPaterno.Value = DatosAux.ApPaterno;
                this.ApMaterno.Value = DatosAux.ApMaterno;
                this.datepicker.Value = DatosAux.FechaNac.ToString("dd-MM-yyyy");
                this.Direccion.Value = DatosAux.Direccion;
                this.Colonia.Value = DatosAux.Colonia;
                this.Telefono.Value = DatosAux.Telefono;
                this.Correo.Value = DatosAux.CorreoElec;
                this.IDGenero = DatosAux.IdGenero;
                this.IDEstado = DatosAux.IdEstado;
                this.IDMunicipio = DatosAux.Id_Municipio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Se inicializa el formulario vacio
        /// </summary>
        private void IniciarDatos()
        {
            try
            {
                this.Nombre.Value = string.Empty;
                this.ApPaterno.Value = string.Empty;
                this.ApMaterno.Value = string.Empty;
                this.datepicker.Value = string.Empty;
                this.Direccion.Value = string.Empty;
                this.Colonia.Value = string.Empty;
                this.Telefono.Value = string.Empty;
                this.Correo.Value = string.Empty;
                this.ApPaterno.Value = string.Empty;
                this.Contrasena.Value = string.Empty;
                this.Contrasena2.Value = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}