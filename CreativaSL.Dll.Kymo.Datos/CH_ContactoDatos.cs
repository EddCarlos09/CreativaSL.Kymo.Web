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
    /// Clase de acceso a datos para la página de contacto
    /// </summary>
    public class CH_ContactoDatos
    {
        /// <summary>
        /// Retorna datos para dibujado de la página de contacto
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros </param>        
        public CH_Contacto ObtenerDatosPagContacto(CH_Contacto _datos)
        {
            try
            {
                CH_Contacto datos = new CH_Contacto();
                DataSet ds = SqlHelper.ExecuteDataset(_datos.Conexion, "CH_spCSLDB_get_DatosContacto");
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
                        datos.ListaTextos = listaTextos;

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
                                                
                        DataTableReader drContacto = ds.Tables[2].CreateDataReader();
                        while (drContacto.Read())
                        {
                            string correos = drContacto.GetString(drContacto.GetOrdinal("Telefonos"));
                            string telefonos = drContacto.GetString(drContacto.GetOrdinal("Correos"));
                            datos.Direccion = drContacto.GetString(drContacto.GetOrdinal("Direccion"));
                            datos.Latitud = drContacto.GetDouble(drContacto.GetOrdinal("Latitud"));
                            datos.Longitud = drContacto.GetDouble(drContacto.GetOrdinal("Longitud"));

                            List<string> listaCorreos = new List<string>();
                            string[] arregloAux = correos.Split(',');
                            for (int i = 0; i < arregloAux.Length; i++)
                            {
                                listaCorreos.Add(arregloAux[i]);
                            }

                            List<string> listaTelefonos = new List<string>();
                            arregloAux = telefonos.Split(',');
                            for (int i = 0; i < arregloAux.Length; i++)
                            {
                                listaTelefonos.Add(arregloAux[i]);
                            }
                            datos.Correos = listaCorreos;
                            datos.Telefonos = listaTelefonos;
                            break;
                        }

                        DataTableReader drRS = ds.Tables[3].CreateDataReader();
                        List<CH_RedesSociales> listaRS = new List<CH_RedesSociales>();
                        CH_RedesSociales itemRS;
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
                        datos.ListaRedesSociales = listaRS;

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
