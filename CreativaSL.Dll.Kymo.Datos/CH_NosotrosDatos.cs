using CreativaSL.Dll.Kymo.Global;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Datos
{
    /// <summary>
    /// Clase de acceso a datos para la página de nosotros
    /// </summary>
    public class CH_NosotrosDatos
    {
        /// <summary>
        /// Retorna datos para dibujado de la página nosotros
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros </param>        
        public CH_Nosotros ObtenerDatosPagNosotros(CH_Nosotros _datos)
        {
            try
            {
                CH_Nosotros datos = new CH_Nosotros();
                DataSet ds = SqlHelper.ExecuteDataset(_datos.Conexion, "CH_spCSLDB_get_DatosNosotros");
                if (ds != null)
                {
                    if (ds.Tables.Count == 6)
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
                        datos.ListaTextos = listaTextos;
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
                        datos.ListaImagenes = listaImagenes;
                        //Quienes somos
                        DataTableReader drSeccionA = ds.Tables[2].CreateDataReader();
                        List<CH_SeccionA> listaSeccionA = new List<CH_SeccionA>();
                        CH_SeccionA itemSeccionA;
                        while (drSeccionA.Read())
                        {
                            itemSeccionA = new CH_SeccionA();
                            itemSeccionA.Titulo = drSeccionA.GetString(drSeccionA.GetOrdinal("Titulo"));
                            itemSeccionA.TextoHTML = drSeccionA.GetString(drSeccionA.GetOrdinal("TextoHtml"));
                            CH_Imagen imgItem = new CH_Imagen();
                            imgItem.Title = drSeccionA.GetString(drSeccionA.GetOrdinal("TitleImagen"));
                            imgItem.Alt = drSeccionA.GetString(drSeccionA.GetOrdinal("AltImagen"));
                            imgItem.UrlImagen = drSeccionA.GetString(drSeccionA.GetOrdinal("UrlImagen"));
                            itemSeccionA.ImagenSeccion = imgItem;
                            listaSeccionA.Add(itemSeccionA);
                        }
                        datos.ListaSeccionA = listaSeccionA;
                        //Por qué elegirnos
                        DataTableReader drSeccionB = ds.Tables[3].CreateDataReader();
                        List<CH_SeccionB> listaSeccionB = new List<CH_SeccionB>();
                        CH_SeccionB itemSeccionB;
                        while(drSeccionB.Read())
                        {
                            itemSeccionB = new CH_SeccionB();
                            itemSeccionB.Titulo = drSeccionB.GetString(drSeccionB.GetOrdinal("Titulo"));
                            itemSeccionB.Texto = drSeccionB.GetString(drSeccionB.GetOrdinal("Texto"));
                            itemSeccionB.CssClass = drSeccionB.GetString(drSeccionB.GetOrdinal("ClassIcon"));
                            listaSeccionB.Add(itemSeccionB);
                        }
                        datos.ListaSeccionB = listaSeccionB;
                        //Equipo de trabajo 
                        DataTable tablaRedesSociales = ds.Tables[5];
                        DataTableReader drEquipo = ds.Tables[4].CreateDataReader();
                        List<CH_SeccionC> listaSeccionC = new List<CH_SeccionC>();
                        CH_SeccionC itemSeccionC;
                        while(drEquipo.Read())
                        {
                            itemSeccionC = new CH_SeccionC();
                            string id = drEquipo.GetString(drEquipo.GetOrdinal("IDMiembro"));
                            itemSeccionC.Nombre =  drEquipo.GetString(drEquipo.GetOrdinal("Nombre"));
                            itemSeccionC.Puesto = drEquipo.GetString(drEquipo.GetOrdinal("Puesto"));
                            CH_Imagen imgEquipo = new CH_Imagen();
                            imgEquipo.Title = drEquipo.GetString(drEquipo.GetOrdinal("TitleImagen"));
                            imgEquipo.Alt = drEquipo.GetString(drEquipo.GetOrdinal("AltImagen"));
                            imgEquipo.UrlImagen = drEquipo.GetString(drEquipo.GetOrdinal("UrlImagen"));
                            itemSeccionC.Fotografia = imgEquipo;
                            DataRow[] result = tablaRedesSociales.Select("IDMiembro = '" + id + "'");

                            List<CH_RedesSociales> listaRS = new List<CH_RedesSociales>();
                            CH_RedesSociales itemRS;
                            if (result != null)
                            {
                                if (result.Length > 0)
                                {
                                    DataTableReader drRS = result.CopyToDataTable().CreateDataReader();
                                    while (drRS.Read())
                                    {
                                        itemRS = new CH_RedesSociales();
                                        itemRS.UrlBase = drRS.GetString(drRS.GetOrdinal("UrlBase"));
                                        itemRS.CssClass = drRS.GetString(drRS.GetOrdinal("CssClass"));
                                        itemRS.CssClassIcon = drRS.GetString(drRS.GetOrdinal("ClassIcon"));
                                        itemRS.Cuenta = drRS.GetString(drRS.GetOrdinal("Cuenta"));
                                        itemRS.Nombre = drRS.GetString(drRS.GetOrdinal("Nombre"));
                                        listaRS.Add(itemRS);
                                    }
                                }
                            }
                            itemSeccionC.ListaRedesSociales = listaRS;
                            listaSeccionC.Add(itemSeccionC);
                        }
                        datos.ListaSeccionC = listaSeccionC;
                        datos.Completado = true;
                    }
                }
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
