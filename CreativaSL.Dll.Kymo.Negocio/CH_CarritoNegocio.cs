using CreativaSL.Dll.Kymo.Datos;
using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Negocio
{
    /// <summary>
    /// Reglas de negocio para carrito de compras
    /// </summary>
    public class CH_CarritoNegocio
    {
        /// <summary>
        /// Agregar un producto al carrito de compras del cliente
        /// </summary>
        /// <param name="_idCliente">Identificador del cliente logueado o del cliente anónimo.</param>
        /// <param name="_esAnonimo">Bandera para identificar si un usuario está logueado o no.</param>
        /// <param name="_producto">Datos del producto a agregar al carrito de compras.</param>
        /// <param name="_conexion">Cadena de conexión para acceso </param>
        public int AgregarProductoACarrito(string _idCliente, bool _esAnonimo, CH_VentaDetalle _producto, string _conexion)
        {
            try
            {
                CH_CarritoDatos dataCart = new CH_CarritoDatos();
                return dataCart.AgregarProductoACarrito(_idCliente, _esAnonimo, _producto, _conexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna datos para dibujado de la página carrito
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros </param>  
        public CH_Carrito ObtenerDatosPaginaCarrito(string _idCliente, bool _esAnonimo, string _conexion)
        {
            try
            {
                CH_CarritoDatos dataCart = new CH_CarritoDatos();
                return dataCart.ObtenerDatosPaginaCarrito(_idCliente, _esAnonimo, _conexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Aplicar un cupón al carrito de compras
        /// </summary>
        /// <param name="_idCliente">Identificador del cliente logueado o del cliente anónimo.</param>
        /// <param name="_esAnonimo">Bandera para identificar si un usuario está logueado o no.</param>
        /// <param name="codigoVale">Código del vale a aplicar.</param>
        /// <param name="_conexion">Cadena de conexión para acceso.</param>
        /// <returns>Retorna un objeto carrito con los totales y el resultado</returns>
        public CH_Carrito AplicarCuponACarrito(string _idCliente, bool _esAnonimo, string _codigoVale, string _conexion)
        {
            try
            {
                CH_CarritoDatos dataCart = new CH_CarritoDatos();
                return dataCart.AplicarCuponACarrito(_idCliente, _esAnonimo, _codigoVale, _conexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Eliminar un producto del carrito de compras del cliente
        /// </summary>
        /// <param name="_idCliente">Identificador del cliente logueado o del cliente anónimo.</param>
        /// <param name="_esAnonimo">Bandera para identificar si un usuario está logueado o no.</param>
        /// <param name="_producto">Datos del producto a agregar al carrito de compras.</param>
        /// <param name="_conexion">Cadena de conexión para acceso.</param>
        /// <returns>Retorna un objeto carrito con los totales y el resultado</returns>
        public CH_Carrito EliminarProductoACarrito(string _idCliente, bool _esAnonimo, CH_VentaDetalle _producto, string _conexion)
        {
            try
            {
                CH_CarritoDatos cartData = new CH_CarritoDatos();
                return cartData.EliminarProductoACarrito(_idCliente, _esAnonimo, _producto, _conexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
