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
    /// Define las reglas de negocio para configuración
    /// </summary>
    public class CH_ConfiguracionNegocio
    {
        /// <summary>
        /// Retorna datos de configuración global para la página
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros </param>        
        public CH_Configuracion ObtenerConfiguracionGeneral(CH_Configuracion _datos)
        {
            try
            {
                CH_ConfiguracionDatos configdat = new CH_ConfiguracionDatos();
                return configdat.ObtenerConfiguracionGeneral(_datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
