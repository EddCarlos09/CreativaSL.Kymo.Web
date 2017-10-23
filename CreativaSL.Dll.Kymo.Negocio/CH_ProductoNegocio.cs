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
    /// Define reglas de negocios para productos
    /// </summary>
    public class CH_ProductoNegocio
    {

        /// <summary>
        /// Obtener detalle de un producto para mostrar en página Producto.aspx
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros (Id del producto)</param>
        /// <returns></returns>
        public CH_PaginaProducto ObtenerDetalleProductoXID(CH_Producto _datos)
        {
            try
            {
                CH_ProductoDatos productdat = new CH_ProductoDatos();
                return productdat.ObtenerDetalleProductoXID(_datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtener precio del producto tipo ropa a partir de talla y color
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros (Id, talla y color del producto)</param>
        /// <returns></returns>
        public CH_Producto ObtenerPrecioProductoXIDColorIDTalla(CH_Producto _datos)
        {
            try
            {
                CH_ProductoDatos productdat = new CH_ProductoDatos();
                return productdat.ObtenerPrecioProductoXIDColorIDTalla(_datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtener talla a partir del id del producto y su color
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros (Id y color del producto)</param>
        /// <returns></returns>
        public List<CH_Talla> ObtenerTallasXIDProductoIDColor(CH_Producto _datos)
        {
            try
            {
                CH_ProductoDatos productdat = new CH_ProductoDatos();
                return productdat.ObtenerTallasXIDProductoIDColor(_datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtener color a partir del id del producto y su talla
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros (Id y talla del producto)</param>
        /// <returns></returns>
        public List<CH_Color> ObtenerColoresXIDProductoIDTalla(CH_Producto _datos)
        {
            try
            {
                CH_ProductoDatos productdat = new CH_ProductoDatos();
                return productdat.ObtenerColoresXIDProductoIDTalla(_datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Búsqueda de productos por diversos factores
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros</param>
        /// <returns></returns>
        public CH_Busqueda BusquedaProductos(CH_Busqueda _datos)
        {
            try
            {
                CH_ProductoDatos productdat = new CH_ProductoDatos();
                return productdat.BusquedaProductos(_datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
