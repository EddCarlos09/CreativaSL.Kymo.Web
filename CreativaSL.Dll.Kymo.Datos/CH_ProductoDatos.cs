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
    /// Clase de acceso a datos para información de productos
    /// </summary>
    public class CH_ProductoDatos
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
                CH_PaginaProducto dataPageResult = new CH_PaginaProducto();

                CH_Producto dataResult = new CH_Producto();
                object[] parametros = { _datos.IdProducto };
                DataSet ds = SqlHelper.ExecuteDataset(_datos.Conexion, "CH_spCSLDB_get_DetalleProductoXID", parametros);
                if(ds != null)
                {
                    if(ds.Tables.Count == 6)
                    {
                        //Textos
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
                        dataPageResult.ListaTextos = listaTextos;
                        //Imagenes
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
                        dataPageResult.ListaImagenes = listaImagenes;

                        DataTableReader drDetalle = ds.Tables[2].CreateDataReader();
                        while(drDetalle.Read())
                        {
                            dataResult.IdProducto = drDetalle.GetString(drDetalle.GetOrdinal("IDProducto"));
                            dataResult.NombreProducto = drDetalle.GetString(drDetalle.GetOrdinal("NombreProducto"));
                            dataResult.Observaciones = drDetalle.GetString(drDetalle.GetOrdinal("Observaciones"));
                            dataResult.Valoracion = drDetalle.GetInt32(drDetalle.GetOrdinal("Valoracion"));
                            dataResult.MinPrecio = drDetalle.GetDecimal(drDetalle.GetOrdinal("PrecioMenor"));
                            dataResult.EsRopa = drDetalle.GetBoolean(drDetalle.GetOrdinal("EsRopa"));
                            dataResult.Completado = true;
                            break;
                        }

                        DataTableReader drColor = ds.Tables[3].CreateDataReader();
                        List<CH_Color> listaColores = new List<CH_Color>();
                        CH_Color itemColor;
                        while(drColor.Read())
                        {
                            itemColor = new CH_Color();
                            itemColor.IdColor = drColor.GetInt32(drColor.GetOrdinal("IDColor"));
                            itemColor.Descripcion = drColor.GetString(drColor.GetOrdinal("Descripcion"));
                            listaColores.Add(itemColor);
                        }
                        dataResult.ListaColores = listaColores;

                        DataTableReader drImagenes = ds.Tables[4].CreateDataReader();
                        List<CH_Imagen> listaImagenesProd = new List<CH_Imagen>();
                        List<CH_Imagen> listaImagenesProdThumb = new List<CH_Imagen>();
                        CH_Imagen itemImagenProd;
                        CH_Imagen itemImagenProdThumb;
                        while(drImagenes.Read())
                        {
                            itemImagenProd = new CH_Imagen();
                            itemImagenProd.UrlImagen = drImagenes.GetString(drImagenes.GetOrdinal("UrlImagen"));
                            itemImagenProd.Title = drImagenes.GetString(drImagenes.GetOrdinal("Title"));
                            itemImagenProd.Alt = drImagenes.GetString(drImagenes.GetOrdinal("Alt"));
                            itemImagenProdThumb = new CH_Imagen { Title = itemImagenProd.Title, Alt = itemImagenProd.Alt };
                            itemImagenProdThumb.UrlImagen = drImagenes.GetString(drImagenes.GetOrdinal("UrlImagenThumb"));
                            listaImagenesProd.Add(itemImagenProd);
                            listaImagenesProdThumb.Add(itemImagenProdThumb);
                        }
                        dataResult.ListaImagenes = listaImagenesProd;
                        dataResult.ListaImagenesThumb = listaImagenesProdThumb;

                        DataTableReader drProductos = ds.Tables[5].CreateDataReader();
                        List<CH_Producto> listaProductos = new List<CH_Producto>();
                        CH_Producto itemProducto;
                        while(drProductos.Read())
                        {
                            CH_Imagen imgProducto = new CH_Imagen();
                            itemProducto = new CH_Producto();
                            itemProducto.IdProducto = drProductos.GetString(drProductos.GetOrdinal("IDProducto"));
                            imgProducto.UrlImagen = drProductos.GetString(drProductos.GetOrdinal("UrlImagen"));
                            itemProducto.ImagenPrincipal = imgProducto;
                            itemProducto.NombreProducto = drProductos.GetString(drProductos.GetOrdinal("Producto"));
                            itemProducto.MinPrecio = drProductos.GetDecimal(drProductos.GetOrdinal("MinPrecio"));
                            itemProducto.MinPrecioMayoreo = drProductos.GetDecimal(drProductos.GetOrdinal("MinPrecioMayoreo"));
                            listaProductos.Add(itemProducto);
                        }
                        dataResult.ListaProductosRelacionados = listaProductos;

                        dataPageResult.Producto = dataResult;
                        dataPageResult.Completado = true;
                        dataPageResult.Producto.ListaImagenes.Add(new CH_Imagen { UrlImagen = "../assets/images/product/01.jpg", Alt = "Img01" });
                        dataPageResult.Producto.ListaImagenes.Add(new CH_Imagen { UrlImagen = "../assets/images/product/02.jpg", Alt = "Img02" });
                        dataPageResult.Producto.ListaImagenes.Add(new CH_Imagen { UrlImagen = "../assets/images/product/03.jpg", Alt = "Img03" });
                        dataPageResult.Producto.ListaImagenes.Add(new CH_Imagen { UrlImagen = "../assets/images/product/04.jpg", Alt = "Img04" });

                        dataPageResult.Producto.ListaImagenesThumb.Add(new CH_Imagen { UrlImagen = "../assets/images/product/01.jpg", Alt = "Img01" });
                        dataPageResult.Producto.ListaImagenesThumb.Add(new CH_Imagen { UrlImagen = "../assets/images/product/02.jpg", Alt = "Img02" });
                        dataPageResult.Producto.ListaImagenesThumb.Add(new CH_Imagen { UrlImagen = "../assets/images/product/03.jpg", Alt = "Img03" });
                        dataPageResult.Producto.ListaImagenesThumb.Add(new CH_Imagen { UrlImagen = "../assets/images/product/04.jpg", Alt = "Img04" });
                        //dataPageResult.Producto.Valoracion = 4;
                        //dataPageResult.Producto.NombreProducto = "Pantalón Niño Preescolar";
                        //dataPageResult.Producto.MinPrecio = 280;
                        //dataPageResult.Producto.Observaciones = "Uniforme UPGCH para niños de preescolar.";
                    }
                }
                return dataPageResult;
            }
            catch(Exception ex)
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
                CH_Producto dataResult = new CH_Producto();
                object[] parametros = { _datos.IdProducto, _datos.Talla.IdTalla, _datos.Color.IdColor };
                SqlDataReader dr = SqlHelper.ExecuteReader(_datos.Conexion, "CH_spCSLDB_get_PrecioProducto", parametros);
                while(dr.Read())
                {
                    dataResult.Precio = dr.GetDecimal(dr.GetOrdinal("precio"));
                    dataResult.PrecioMayoreo = dr.GetDecimal(dr.GetOrdinal("precioMayoreo"));
                    dataResult.Completado = true;
                    break;
                }
                return dataResult;
            }
            catch(Exception ex)
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
                List<CH_Talla> dataResult = new List<CH_Talla>();
                object[] parametros = { _datos.IdProducto, _datos.Color.IdColor };
                SqlDataReader dr = SqlHelper.ExecuteReader(_datos.Conexion, "CH_spCSLDB_get_TallaProductoXIDColor", parametros);
                CH_Talla itemTalla;
                while (dr.Read())
                {
                    itemTalla = new CH_Talla();
                    itemTalla.IdTalla = dr.GetInt32(dr.GetOrdinal("IDTalla"));
                    itemTalla.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                    dataResult.Add(itemTalla);
                }
                return dataResult;
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
                List<CH_Color> dataResult = new List<CH_Color>();
                object[] parametros = { _datos.IdProducto, _datos.Talla.IdTalla };
                SqlDataReader dr = SqlHelper.ExecuteReader(_datos.Conexion, "CH_spCSLDB_get_ColorProductoXIDTalla", parametros);
                CH_Color itemColor;
                while (dr.Read())
                {
                    itemColor = new CH_Color();
                    itemColor.IdColor = dr.GetInt32(dr.GetOrdinal("IDColor"));
                    itemColor.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                    dataResult.Add(itemColor);
                }
                return dataResult;
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
                CH_Busqueda dataResult = new CH_Busqueda();                
                object[] parametros = { _datos.NumPagina, _datos.MaxRows, _datos.BandFamilia,
                                        _datos.Familia.IdFamilia, _datos.Hombre, _datos.Mujer,
                                        _datos.Accesorio, _datos.BandTalla, _datos.Talla.IdTalla,
                                        _datos.BandColor, _datos.Color.IdColor, _datos.BandRangoPrecios,
                                        _datos.PrecioFinal, _datos.PrecioInicial};
                DataSet ds = SqlHelper.ExecuteDataset(_datos.Conexion, "CH_spCSLDB_BusquedaProductosWeb", parametros);
                if (ds.Tables.Count == 2)
                {
                    DataTableReader dr = ds.Tables[0].CreateDataReader();
                    while(dr.Read())
                    {
                        dataResult.TotalRegistros = dr.GetInt32(dr.GetOrdinal("Total"));
                        dataResult.Completado = true;
                        break;
                    }

                    DataTableReader drProductos = ds.Tables[1].CreateDataReader();
                    List<CH_Producto> listaProductos = new List<CH_Producto>();
                    CH_Producto itemProducto;
                    while (drProductos.Read())
                    {
                        CH_Imagen imgProducto = new CH_Imagen();
                        itemProducto = new CH_Producto();
                        itemProducto.IdProducto = drProductos.GetString(drProductos.GetOrdinal("IDProducto"));
                        imgProducto.UrlImagen = drProductos.GetString(drProductos.GetOrdinal("UrlImagen"));
                        itemProducto.ImagenPrincipal = imgProducto;
                        itemProducto.NombreProducto = drProductos.GetString(drProductos.GetOrdinal("Producto"));
                        itemProducto.MinPrecio = drProductos.GetDecimal(drProductos.GetOrdinal("MinPrecio"));
                        itemProducto.MinPrecioMayoreo = drProductos.GetDecimal(drProductos.GetOrdinal("Descripcion"));
                        listaProductos.Add(itemProducto);
                    }
                    dataResult.ListaProductosResultado = listaProductos;
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
