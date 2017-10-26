using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición de datos para la página Carrito
    /// </summary>
    public class CH_Carrito
    {
        /// <summary>
        /// Inicializa los datos de la clase
        /// </summary>
        public CH_Carrito()
        {
            _ListaImagenes = new List<CH_Imagen>();
            _ListaTextos = new List<CH_Textos>();
            _ListaVentaDetalle = new List<CH_VentaDetalle>();
            _DatosCliente = new CH_Cliente();
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

        private string _MensajeError;
        /// <summary>
        /// Muestra un mensaje de error ocurrido en alguna operación
        /// </summary>
        public string MensajeError
        {
            get { return _MensajeError; }
            set { _MensajeError = value; }
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

        private List<CH_VentaDetalle> _ListaVentaDetalle;
        /// <summary>
        /// Detalle de productos en el carrito de compras
        /// </summary>
        public List<CH_VentaDetalle> ListaVentaDetalle
        {
            get { return _ListaVentaDetalle; }
            set { _ListaVentaDetalle = value; }
        }

        private string _IdCarrito;
        /// <summary>
        /// Identificador del carrito
        /// </summary>
        public string IdCarrito
        {
            get { return _IdCarrito; }
            set { _IdCarrito = value; }
        }

        private decimal _Subtotal;
        /// <summary>
        /// Subtotal del carrito
        /// </summary>
        public decimal Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = value; }
        }

        private decimal _Descuento;
        /// <summary>
        /// Descuento al carrito
        /// </summary>
        public decimal Descuento
        {
            get { return _Descuento; }
            set { _Descuento = value; }
        }

        private decimal _Total;
        /// <summary>
        /// Total carrito
        /// </summary>
        public decimal Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        private int _IDTipoEnvio;
        /// <summary>
        /// Tipo den envío del pedido
        /// </summary>
        public int IDTipoEnvio
        {
            get { return _IDTipoEnvio; }
            set { _IDTipoEnvio = value; }
        }

        private int _CantidadProductos;
        /// <summary>
        /// Cantidad total de productos en el carrito
        /// </summary>
        public int CantidadProductos
        {
            get { return _CantidadProductos; }
            set { _CantidadProductos = value; }
        }

        private CH_Cliente _DatosCliente;
        /// <summary>
        /// Datos del cliente al que pertenece el carrito
        /// </summary>
        public CH_Cliente DatosCliente
        {
            get { return _DatosCliente; }
            set { _DatosCliente = value; }
        }

        private string _IDVale;
        /// <summary>
        /// Identificador del vale aplicado al carrito
        /// </summary>
        public string IDVale
        {
            get { return _IDVale; }
            set { _IDVale = value; }
        }

        private string _CodigoVale;
        /// <summary>
        /// Código del vale aplicado al carrito
        /// </summary>
        public string CodigoVale
        {
            get { return _CodigoVale; }
            set { _CodigoVale = value; }
        }

    }
}
