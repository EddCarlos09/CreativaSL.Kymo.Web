using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.Kymo.Global;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace CreativaSL.Dll.Kymo.Datos
{
    public class EM_HomeDatos
    {
        #region Home Banner Princial
        /// <summary>
        /// Obtenermos la lista de los banner
        /// </summary>
        /// <param name="Datos">Recibe la la cadena de conexion y los parametos a recibir</param>
        /// <returns></returns>
        public List<EM_HomeBanner> ObtenerListBanner(EM_HomeBanner Datos)
        {
            try
            {
                List<EM_HomeBanner> Lista = new List<EM_HomeBanner>();
                EM_HomeBanner Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_Home_BannerWeb");
                while (Dr.Read())
                {
                    Item = new EM_HomeBanner();
                    Item.IdBanner = Dr.GetString(Dr.GetOrdinal("IdBanner"));
                    Item.TextoInicial = Dr.GetString(Dr.GetOrdinal("TextoInicial"));
                    Item.TextoPrincipal = Dr.GetString(Dr.GetOrdinal("TextoPrincipal"));
                    Item.Comprar = Dr.GetBoolean(Dr.GetOrdinal("ComprarAhora"));
                    Item.UrlDestino = Dr.GetString(Dr.GetOrdinal("UrlDestino"));
                    Item.TextoButton = Dr.GetString(Dr.GetOrdinal("TextButton"));
                    Item.UrlImagen = Dr.GetString(Dr.GetOrdinal("UrlImagen"));
                    Item.Alt = Dr.GetString(Dr.GetOrdinal("TextoAlternativo"));
                    Item.Title = Dr.GetString(Dr.GetOrdinal("Titulo"));
                    Lista.Add(Item);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Home Patrocinadores
        /// <summary>
        /// Obtenemos los datos que se van a dibujar en la pagina web
        /// </summary>
        /// <param name="Datos">Objeto de Datos y Parametros</param>
        /// <returns>Retorna la lista de patrocinadores</returns>
        public List<EM_Patrocinadores> ObtenerPatrocinadoresHome(EM_Patrocinadores Datos)
        {
            try
            {
                List<EM_Patrocinadores> Lista = new List<EM_Patrocinadores>();
                EM_Patrocinadores Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_Home_PatrocinadorWeb");
                while (Dr.Read())
                {
                    Item = new EM_Patrocinadores();
                    Item.IdPatrocinadores = Dr.GetString(Dr.GetOrdinal("IdPatrocinador"));
                    Item.Alt = Dr.GetString(Dr.GetOrdinal("TextoAlternativo"));
                    Item.Title = Dr.GetString(Dr.GetOrdinal("Titulo"));
                    Item.UrlImagen = Dr.GetString(Dr.GetOrdinal("UrlImagen"));
                    Item.UrlDestino = Dr.GetString(Dr.GetOrdinal("UrlDestino"));
                    Lista.Add(Item);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Home Testimoniales
        /// <summary>
        /// Obtenemos los datos que se van a dibujar en la pagina web
        /// </summary>
        /// <param name="Datos">Objeto de Datos y Parametros</param>
        /// <returns>Retorna la lista de patrocinadores</returns>
        public List<EM_Testimoniales> ObtenerTestimonialesHome(EM_Testimoniales Datos)
        {
            try
            {
                List<EM_Testimoniales> Lista = new List<EM_Testimoniales>();
                EM_Testimoniales Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_Home_Testimoniales");
                while (Dr.Read())
                {
                    Item = new EM_Testimoniales();
                    Item.NombreCompleto = Dr.GetString(Dr.GetOrdinal("NombreCompleto"));
                    Item.Comentario = Dr.GetString(Dr.GetOrdinal("Comentario"));
                    Lista.Add(Item);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Home Lista De Imagenes Generales 
        public List<EM_HomeGeneral> ObtenerListaImagenesGenerales(EM_HomeGeneral Datos)
        {
            try
            {
                List<EM_HomeGeneral> Lista = new List<EM_HomeGeneral>();
                EM_HomeGeneral Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_Home_ImagenesGenerales");
                while (Dr.Read())
                {
                    Item = new EM_HomeGeneral();
                    Item.UrlImagen = Dr.GetString(Dr.GetOrdinal("UrlImagen"));
                    Item.Alt = Dr.GetString(Dr.GetOrdinal("TextoAlternativo"));
                    Item.Title = Dr.GetString(Dr.GetOrdinal("TituloImagen"));
                    Item.NumPosition = Dr.GetInt32(Dr.GetOrdinal("NumPosition"));
                    Lista.Add(Item);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
