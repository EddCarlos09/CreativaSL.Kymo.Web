using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición de entidad VentaDetalle. Representa un producto dentro de una venta
    /// </summary>
    public class CH_VentaDetalle
    {
        /// <summary>
        /// Inicializa datos de la clase
        /// </summary>
        public CH_VentaDetalle()
        {
            _Producto = new CH_Producto();
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


        private CH_Producto _Producto;
        /// <summary>
        /// Datos del producto
        /// </summary>
        public CH_Producto Producto
        {
            get { return _Producto; }
            set { _Producto = value; }
        }

        private int _Cantidad;
        /// <summary>
        /// Cantidad de venta del producto
        /// </summary>
        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        private decimal _PrecioVenta;
        /// <summary>
        /// Precio de venta del producto
        /// </summary>
        public decimal PrecioVenta
        {
            get { return _PrecioVenta; }
            set { _PrecioVenta = value; }
        }
        private decimal _IvaVenta;
        /// <summary>
        /// Iva por producto
        /// </summary>
        public decimal IvaVenta
        {
            get { return _IvaVenta; }
            set { _IvaVenta = value; }
        }

        private decimal _Importe;
        /// <summary>
        /// Precio del producto multiplicado por cantidad
        /// </summary>
        public decimal Importe
        {
            get { return _Importe; }
            set { _Importe = value; }
        }

        private decimal _Iva;
        /// <summary>
        /// Iva del producto multiplicado por cantidad
        /// </summary>
        public decimal Iva
        {
            get { return _Iva; }
            set { _Iva = value; }
        }

        private decimal _Subtotal;
        /// <summary>
        /// Suma del importe y del iva
        /// </summary>
        public decimal Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = value; }
        }

        private decimal _Descuento;
        /// <summary>
        /// Descuento 
        /// </summary>
        public decimal Descuento
        {
            get { return _Descuento; }
            set { _Descuento = value; }
        }

        private decimal _Total;
        /// <summary>
        /// Subtotal menos descuentos
        /// </summary>
        public decimal Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        private string _IdCarritoDetalle;
        /// <summary>
        /// Identificador del registro del producto en la venta
        /// </summary>
        public string IdCarritoDetalle
        {
            get { return _IdCarritoDetalle; }
            set { _IdCarritoDetalle = value; }
        }

        private string _Folio;
        /// <summary>
        /// Folio del producto
        /// </summary>
        public string Folio
        {
            get { return _Folio; }
            set { _Folio = value; }
        }

        private DateTime _FechaVenta;
        /// <summary>
        /// Fecha de la venta del producto
        /// </summary>
        public DateTime FechaVenta
        {
            get { return _FechaVenta; }
            set { _FechaVenta = value; }
        }


    }
}
