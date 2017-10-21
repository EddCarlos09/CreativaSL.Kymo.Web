using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Datos;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class EM_HomeNegocio
    {
        #region Home Banner Principal
        /// <summary>
        /// Obtener la lista de todo los banner para mostrar
        /// </summary>
        /// <param name="Datos">Enviamos todo los datos como la cadena de conexion y los parametros</param>
        /// <returns></returns>
        public List<EM_HomeBanner> ObtenerListaBanner(EM_HomeBanner Datos)
        {
            try
            {
                EM_HomeDatos LD = new EM_HomeDatos();
                return LD.ObtenerListBanner(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Home Patrocinadores
        /// <summary>
        /// Es para obtener la lista de los patrocinadores
        /// </summary>
        /// <param name="Datos">Los datos son cadena conexion y parametos</param>
        /// <returns>Retorna la lista de los patrocinadores</returns>
        public List<EM_Patrocinadores> ObtenerPatrocinadores(EM_Patrocinadores Datos)
        {
            try
            {
                EM_HomeDatos PD = new EM_HomeDatos();
                return PD.ObtenerPatrocinadoresHome(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
