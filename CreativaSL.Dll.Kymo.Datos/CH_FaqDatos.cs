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
    /// Clase de acceso a datos para la página de preguntas frecuentes
    /// </summary>
    public class CH_FaqDatos
    {
        /// <summary>
        /// Retorna datos para dibujado de la página de preguntas frecuentes
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros </param>        
        public CH_FAQ ObtenerDatosPagFaqs(CH_FAQ _datos)
        {
            try
            {
                CH_FAQ datos = new CH_FAQ();
                DataSet ds = SqlHelper.ExecuteDataset(_datos.Conexion, "CH_spCSLDB_get_DatosFaqs");
                if (ds != null)
                {
                    if (ds.Tables.Count == 3)
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

                        DataTableReader drFaqs = ds.Tables[2].CreateDataReader();
                        List<CH_SeccionB> listaFaqs = new List<CH_SeccionB>();
                        CH_SeccionB itemFaq;
                        while (drFaqs.Read())
                        {
                            itemFaq = new CH_SeccionB();
                            itemFaq.Titulo = drFaqs.GetString(drFaqs.GetOrdinal("Pregunta"));
                            itemFaq.Texto = drFaqs.GetString(drFaqs.GetOrdinal("Respuesta"));
                            listaFaqs.Add(itemFaq);
                        }
                        datos.ListaFaqs = listaFaqs;
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
