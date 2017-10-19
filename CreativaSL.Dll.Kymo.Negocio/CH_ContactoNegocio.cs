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
    /// Define las reglas de negocio para contacto
    /// </summary>
    public class CH_ContactoNegocio
    {
        /// <summary>
        /// Retorna datos para dibujado de la página de contacto
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros </param>        
        public CH_Contacto ObtenerDatosPagContacto(CH_Contacto _datos)
        {
            try
            {
                CH_ContactoDatos contDat = new CH_ContactoDatos();
                return contDat.ObtenerDatosPagContacto(_datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
