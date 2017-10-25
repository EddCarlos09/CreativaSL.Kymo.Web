using CreativaSL.Dll.Kymo.Global;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Datos
{
    /// <summary>
    /// Clase de acceso a datos para administración del carrito
    /// </summary>
    public class CH_CarritoDatos
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
                int resultado = 0;
                object[] parametros = { _idCliente, _esAnonimo, _producto.Producto.IdProducto, _producto.Producto.Talla.IdTalla, _producto.Producto.Color.IdColor, _producto.Cantidad};
                SqlDataReader dr = SqlHelper.ExecuteReader(_conexion, "CH_spCSLDB_set_AgregarProductoCarrito", parametros);
                while (dr.Read())
                {
                    resultado = dr.GetInt32(dr.GetOrdinal("Resultado"));
                    break;
                }
                return resultado;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
