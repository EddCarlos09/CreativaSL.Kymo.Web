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
    /// Clase de acceso a datos para configuración
    /// </summary>
    public class CH_ConfiguracionDatos
    {
        /// <summary>
        /// Retorna datos de configuración global para la página
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros </param>        
        public CH_Configuracion ObtenerConfiguracionGeneral(CH_Configuracion _datos)
        {
            try
            {
                CH_Configuracion datos = new CH_Configuracion();
                DataSet ds = SqlHelper.ExecuteDataset(_datos.Conexion, "CH_spCSLDB_get_DatosGenerales");
                if(ds != null)
                {
                    if(ds.Tables.Count == 3)
                    {
                        DataTableReader dr = ds.Tables[0].CreateDataReader();
                        while(dr.Read())
                        {
                            datos.UrlBaseImagen = dr.GetString(dr.GetOrdinal("UrlBaseImagen"));
                            datos.MaxCantPedidosActivos = dr.GetInt32(dr.GetOrdinal("MaxCantPedidosActivos"));
                            datos.MaxCantProductos = dr.GetInt32(dr.GetOrdinal("MaxCantProductos"));
                            break;
                        }
                        DataTableReader drRS = ds.Tables[1].CreateDataReader();
                        List<CH_RedesSociales> listaRS = new List<CH_RedesSociales>();
                        CH_RedesSociales itemRS;
                        while(drRS.Read())
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
                        string urlEstatica = "";
                        datos.UrlBaseImagen = string.IsNullOrEmpty(datos.UrlBaseImagen) ? urlEstatica : datos.UrlBaseImagen;


                        DataTableReader drContacto = ds.Tables[2].CreateDataReader();
                        while(drContacto.Read())
                        {
                            string correos = drContacto.GetString(drContacto.GetOrdinal("Telefono"));
                            string telefonos = drContacto.GetString(drContacto.GetOrdinal("Correo"));
                            string direccion = drContacto.GetString(drContacto.GetOrdinal("Direccion"));

                            List<string> listaCorreos = new List<string>();
                            string[] arregloAux = correos.Split(',');
                            for(int i= 0; i<arregloAux.Length; i++)
                            {
                                listaCorreos.Add(arregloAux[i]);
                            }

                            List<string> listaTelefonos = new List<string>();
                            arregloAux = telefonos.Split(',');
                            for (int i = 0; i < arregloAux.Length; i++)
                            {
                                listaTelefonos.Add(arregloAux[i]);
                            }
                            datos.Direccion = direccion;
                            datos.Correos = listaCorreos;
                            datos.Telefonos = listaTelefonos;
                            break;
                        }

                        datos.Completado = true;
                    }
                }
                return datos;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
