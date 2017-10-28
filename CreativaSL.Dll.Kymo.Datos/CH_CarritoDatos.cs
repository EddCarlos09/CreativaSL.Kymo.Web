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
        /// <param name="_conexion">Cadena de conexión para acceso.</param>
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

        /// <summary>
        /// Retorna datos para dibujado de la página carrito
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros </param>  
        public CH_Carrito ObtenerDatosPaginaCarrito(string _idCliente, bool _esAnonimo, string _conexion)
        {
            try
            {
                CH_Carrito dataResult = new CH_Carrito();
                object[] parametros = { _idCliente, _esAnonimo };
                DataSet ds = SqlHelper.ExecuteDataset(_conexion, "CH_spCSLDB_get_DatosCarrito", parametros);
                if (ds != null)
                {
                    if (ds.Tables.Count == 4)
                    {
                        DataTableReader dr = ds.Tables[0].CreateDataReader();
                        List<CH_Textos> listaTextos = new List<CH_Textos>();
                        CH_Textos itemTexto;
                        while (dr.Read())
                        {
                            itemTexto = new CH_Textos();
                            itemTexto.Texto = dr.GetString(dr.GetOrdinal("Texto"));
                            itemTexto.NumPosition = dr.GetInt32(dr.GetOrdinal("NumPosition"));
                            listaTextos.Add(itemTexto);
                        }
                        dataResult.ListaTextos = listaTextos;

                        DataTableReader drImg = ds.Tables[1].CreateDataReader();
                        List<CH_Imagen> listaImagenes = new List<CH_Imagen>();
                        CH_Imagen itemImagen;
                        while (drImg.Read())
                        {
                            itemImagen = new CH_Imagen();
                            itemImagen.Alt = drImg.GetString(drImg.GetOrdinal("TextoAlternativo"));
                            itemImagen.Title = drImg.GetString(drImg.GetOrdinal("TituloImagen"));
                            itemImagen.UrlImagen = drImg.GetString(drImg.GetOrdinal("UrlImagen"));
                            itemImagen.NumPosition = drImg.GetInt32(drImg.GetOrdinal("NumPosition"));
                            listaImagenes.Add(itemImagen);
                        }
                        dataResult.ListaImagenes = listaImagenes;

                        DataTableReader drCart = ds.Tables[2].CreateDataReader();
                        while (drCart.Read())
                        {
                            dataResult.IdCarrito = drCart.GetString(drCart.GetOrdinal("id_carrito"));
                            dataResult.Subtotal = drCart.GetDecimal(drCart.GetOrdinal("subtotal"));
                            dataResult.Descuento = drCart.GetDecimal(drCart.GetOrdinal("descuento"));
                            dataResult.Total = drCart.GetDecimal(drCart.GetOrdinal("total"));
                            dataResult.CodigoVale = drCart.GetString(drCart.GetOrdinal("Vale"));
                            break;
                        }

                        DataTableReader drVD = ds.Tables[3].CreateDataReader();
                        List<CH_VentaDetalle> listaVD = new List<CH_VentaDetalle>();
                        CH_VentaDetalle itemVD;
                        while (drVD.Read())
                        {
                            itemVD = new CH_VentaDetalle();
                            itemVD.IdCarritoDetalle = drVD.GetString(drVD.GetOrdinal("IDCarritoDetalle"));
                            itemVD.Producto.IdProducto = drVD.GetString(drVD.GetOrdinal("IDProducto"));
                            itemVD.Producto.NombreProducto = drVD.GetString(drVD.GetOrdinal("NombreProducto"));
                            itemVD.Cantidad = drVD.GetInt32(drVD.GetOrdinal("cantidad"));
                            itemVD.PrecioVenta = drVD.GetDecimal(drVD.GetOrdinal("Precio"));
                            itemVD.Importe = drVD.GetDecimal(drVD.GetOrdinal("importe"));
                            itemVD.Descuento = drVD.GetDecimal(drVD.GetOrdinal("descuento"));
                            itemVD.Total = drVD.GetDecimal(drVD.GetOrdinal("total"));
                            itemVD.Producto.Talla.IdTalla = drVD.GetInt32(drVD.GetOrdinal("IDTalla"));
                            itemVD.Producto.Color.IdColor = drVD.GetInt32(drVD.GetOrdinal("IDColor"));
                            listaVD.Add(itemVD);
                        }
                        dataResult.ListaVentaDetalle = listaVD;
                        dataResult.Completado = true;
                    }
                }
                return dataResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Eliminar un producto del carrito de compras
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
                CH_Carrito dataResult = new CH_Carrito();
                object[] parametros = { _idCliente, _esAnonimo, _codigoVale };
                SqlDataReader dr = SqlHelper.ExecuteReader(_conexion, "CH_spCSLDB_set_AplicarValeCarrito", parametros);
                while (dr.Read())
                {
                    int resultado = dr.GetInt32(dr.GetOrdinal("Resultado"));
                    if(resultado == 1)
                    {
                        dataResult.Descuento = dr.GetDecimal(dr.GetOrdinal("descuento"));
                        dataResult.Total = dr.GetDecimal(dr.GetOrdinal("total"));
                        dataResult.MensajeError = string.Empty;
                    }
                    else
                    {
                        dataResult.MensajeError = dr.GetString(dr.GetOrdinal("MensajeError"));
                    }
                    dataResult.Resultado = resultado;
                    break;
                }
                return dataResult;
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
                CH_Carrito resultData = new CH_Carrito();
                object[] parametros = { _idCliente, _esAnonimo, _producto.Producto.IdProducto, _producto.Producto.Talla.IdTalla, _producto.Producto.Color.IdColor};
                SqlDataReader dr = SqlHelper.ExecuteReader(_conexion, "CH_spCSLDB_set_EliminarProductoCarrito", parametros);
                while (dr.Read())
                {
                    int resultado = dr.GetInt32(dr.GetOrdinal("Resultado"));
                    if(resultado == 1)
                    {
                        resultData.Descuento = dr.GetDecimal(dr.GetOrdinal("descuento"));
                        resultData.Subtotal = dr.GetDecimal(dr.GetOrdinal("subtotal"));
                        resultData.Total = dr.GetDecimal(dr.GetOrdinal("total"));
                        resultData.IDVale = dr.GetString(dr.GetOrdinal("id_vale"));
                    }
                    resultData.Resultado = resultado;
                    break;
                }
                return resultData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Eliminar un producto del carrito de compras
        /// </summary>
        /// <param name="_idCliente">Identificador del cliente logueado o del cliente anónimo.</param>
        /// <param name="_esAnonimo">Bandera para identificar si un usuario está logueado o no.</param>
        /// <param name="_conexion">Cadena de conexión para acceso.</param>
        /// <returns>Retorna un objeto carrito con los totales y el resultado</returns>
        public CH_Carrito EliminarCuponACarrito(string _idCliente, bool _esAnonimo, string _conexion)
        {
            try
            {
                CH_Carrito dataResult = new CH_Carrito();
                object[] parametros = { _idCliente, _esAnonimo };
                SqlDataReader dr = SqlHelper.ExecuteReader(_conexion, "CH_spCSLDB_set_EliminarValeCarrito", parametros);
                while (dr.Read())
                {
                    int resultado = dr.GetInt32(dr.GetOrdinal("Resultado"));
                    if (resultado == 1)
                    {
                        dataResult.Descuento = dr.GetDecimal(dr.GetOrdinal("descuento"));
                        dataResult.Total = dr.GetDecimal(dr.GetOrdinal("total"));
                        dataResult.MensajeError = string.Empty;
                    }
                    else
                    {
                        dataResult.MensajeError = dr.GetString(dr.GetOrdinal("MensajeError"));
                    }
                    dataResult.Resultado = resultado;
                    break;
                }
                return dataResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
