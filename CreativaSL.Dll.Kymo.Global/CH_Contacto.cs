using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición de datos para la página Contacto
    /// </summary>
    public class CH_Contacto
    {
        /// <summary>
        /// Inicializa los datos de la clase
        /// </summary>
        public CH_Contacto()
        {
            _ListaImagenes = new List<CH_Imagen>();
            _ListaTextos = new List<CH_Textos>();
            _Correos = new List<string>();
            _Telefonos = new List<string>();
        }

        #region Datos de control

        private bool _Completado;
        /// <summary>
        /// Bandera que indica si se completó una operación
        /// </summary>
        public bool Completado
        {
            get { return _Completado; }
            set { _Completado = value; }
        }

        private string _Conexion;
        /// <summary>
        /// Cadena de conexión a la base de datos
        /// </summary>
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }

        private int _Resultado;
        /// <summary>
        /// Entero que devuelve un resultado de una operación
        /// </summary>
        public int Resultado
        {
            get { return _Resultado; }
            set { _Resultado = value; }
        }

        private string _IdUsuario;
        /// <summary>
        /// ID del usuario que realiza una operación
        /// </summary>
        public string IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        #endregion


        private double _Latitud;
        /// <summary>
        /// Latitud para mapa de ubicación
        /// </summary>
        public double Latitud
        {
            get { return _Latitud; }
            set { _Latitud = value; }
        }

        private double _Longitud;
        /// <summary>
        /// Longitud para mapa de ubicación
        /// </summary>
        public double Longitud
        {
            get { return _Longitud; }
            set { _Longitud = value; }
        }

        private List<string> _Telefonos;
        /// <summary>
        /// Lista de teléfonos
        /// </summary>
        public List<string> Telefonos
        {
            get { return _Telefonos; }
            set { _Telefonos = value; }
        }


        private List<string> _Correos; 
        /// <summary>
        /// Lista de correos de contacto
        /// </summary>
        public List<string> Correos
        {
            get { return _Correos; }
            set { _Correos = value; }
        }

        private string _Direccion;
        /// <summary>
        /// Dirección de contacto
        /// </summary>
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        private string _CorreoRemitente;
        /// <summary>
        /// E-mail de donde se enviarán los correos de la sección cantacto
        /// </summary>
        public string CorreoRemitente
        {
            get { return _CorreoRemitente; }
            set { _CorreoRemitente = value; }
        }

        private string _PasswordCorreo;
        /// <summary>
        /// Password de la cuenta de correo remitente
        /// </summary>
        public string PasswordCorreo
        {
            get { return _PasswordCorreo; }
            set { _PasswordCorreo = value; }
        }

        private string _CorreoDestinatario;
        /// <summary>
        /// E-mail al que llegarán los correos de contacto para su debida atención
        /// </summary>
        public string CorreoDestinatario
        {
            get { return _CorreoDestinatario; }
            set { _CorreoDestinatario = value; }
        }

        private int _Puerto;
        /// <summary>
        /// Configuración del puerto desde donde se envía el correo de contacto
        /// </summary>
        public int Puerto
        {
            get { return _Puerto; }
            set { _Puerto = value; }
        }

        private bool _EnableSSL;
        /// <summary>
        /// Configuración de habilitación de SSL en el envío del correo de contacto
        /// </summary>
        public bool EnableSSL
        {
            get { return _EnableSSL; }
            set { _EnableSSL = value; }
        }

        private bool _HtmlText;
        /// <summary>
        /// Configuración para el envío de correo de contacto con etiquetas HTML
        /// </summary>
        public bool HtmlText
        {
            get { return _HtmlText; }
            set { _HtmlText = value; }
        }

        private string _HostText;
        /// <summary>
        /// Servidor de correo al que pertenece el e-mail de contacto
        /// </summary>
        public string HostText
        {
            get { return _HostText; }
            set { _HostText = value; }
        }

        private List<CH_Textos> _ListaTextos;
        /// <summary>
        /// Lista que contiene los textos a mostrar en la página Web
        /// </summary>
        public List<CH_Textos> ListaTextos
        {
            get { return _ListaTextos; }
            set { _ListaTextos = value; }
        }

        private List<CH_Imagen> _ListaImagenes;
        /// <summary>
        /// Lista que contiene las imágenes a mostrar en la página Web 
        /// </summary>
        public List<CH_Imagen> ListaImagenes
        {
            get { return _ListaImagenes; }
            set { _ListaImagenes = value; }
        }

        private List<CH_RedesSociales> _ListaRedesSociales;
        /// <summary>
        /// Lista de redes sociales de la empresa
        /// </summary>
        public List<CH_RedesSociales> ListaRedesSociales
        {
            get { return _ListaRedesSociales; }
            set { _ListaRedesSociales = value; }
        }


    }


}
