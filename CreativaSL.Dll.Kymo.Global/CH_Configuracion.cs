using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición de entidad Configuración
    /// </summary>
    public class CH_Configuracion
    {
        /// <summary>
        /// Inicializa los datos de la clase
        /// </summary>
        public CH_Configuracion()
        {
            _ListaRedesSociales = new List<CH_RedesSociales>();
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

        
        private List<CH_RedesSociales> _ListaRedesSociales;
        /// <summary>
        /// Lista de redes sociales de la empresa
        /// </summary>
        public List<CH_RedesSociales> ListaRedesSociales
        {
            get { return _ListaRedesSociales; }
            set { _ListaRedesSociales = value; }
        }
        
        private int _MaxCantPedidosActivos;
        /// <summary>
        /// Máxima cantidad de pedidos activos que puede tener un usuario
        /// </summary>
        public int MaxCantPedidosActivos
        {
            get { return _MaxCantPedidosActivos; }
            set { _MaxCantPedidosActivos = value; }
        }
        
        private int _MaxCantProductos;
        /// <summary>
        /// Máxima cantidad que se puede solicitar de un producto
        /// </summary>
        public int MaxCantProductos
        {
            get { return _MaxCantProductos; }
            set { _MaxCantProductos = value; }
        }
        
        private string _UrlBaseImagen;
        /// <summary>
        /// Url base donde se encuentran hospedadas las imágenes
        /// </summary>
        public string UrlBaseImagen
        {
            get { return _UrlBaseImagen; }
            set { _UrlBaseImagen = value; }
        }

        private List<string> _Telefonos;
        /// <summary>
        /// Lista de teléfonos de contacto
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

    }
}
