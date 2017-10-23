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
    public class RR_TerminosCondicionesDatos
    {
        public RR_TerminosCondiciones ObtenerDatosTerminosCondiciones(RR_TerminosCondiciones Datos)
        {
            try
            {
                RR_TerminosCondiciones datos = new RR_TerminosCondiciones();
                DataSet ds = SqlHelper.ExecuteDataset(Datos.Conexion, "RR_spCSLDB_get_TerminosCondicioesDatosGeneralesWeb");
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
                            itemTexto.Texto = dr.GetString(dr.GetOrdinal("texto"));
                            itemTexto.NumPosition = dr.GetInt32(dr.GetOrdinal("numPosition"));
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
                            itemImagen.NumPosition = drImg.GetInt32(drImg.GetOrdinal("Posicion"));
                            listaImagenes.Add(itemImagen);
                        }
                        datos.ListaImagenes = listaImagenes;

                        DataTableReader drAviso = ds.Tables[2].CreateDataReader();
                        List<CH_SeccionB> listaAviso = new List<CH_SeccionB>();
                        CH_SeccionB itemAviso;

                        while (drAviso.Read())
                        {
                            itemAviso = new CH_SeccionB();
                            itemAviso.Titulo = drAviso.GetString(drAviso.GetOrdinal("titulo"));
                            itemAviso.Texto = drAviso.GetString(drAviso.GetOrdinal("texto"));
                            listaAviso.Add(itemAviso);
                        }
                        datos.ListaTerminos = listaAviso;
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
