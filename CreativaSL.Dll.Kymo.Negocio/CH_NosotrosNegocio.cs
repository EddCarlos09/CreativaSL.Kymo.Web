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
    /// Define las reglas de negocio para Nosotros
    /// </summary>
    public class CH_NosotrosNegocio
    {
        /// <summary>
        /// Retorna datos para dibujado de la página nosotros
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros </param>        
        public CH_Nosotros ObtenerDatosPagNosotros(CH_Nosotros _datos)
        {
            try
            {
                CH_NosotrosDatos nosDat = new CH_NosotrosDatos();
                return nosDat.ObtenerDatosPagNosotros(_datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
