using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativaSL.WebForms.Kymo.Web
{
    public static class ClaseAuxiliar
    {
        /// <summary>
        /// Verificar que la configuración sea correcta
        /// </summary>
        /// <param name="_data">Contexto actual de la aplicación</param>
        /// <returns></returns>
        public static bool IsCorrectConfiguration(HttpContext _data)
        {
            try
            {
                bool band = false;
                if(_data.Session["Config"] != null)
                {
                    CH_Configuracion dataConfig = (CH_Configuracion)_data.Session["Config"];
                    band = dataConfig.Completado;
                }
                return band;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtener la configuración de la BD e iniciar la variable de SESSION
        /// </summary>
        /// <param name="_data">Contexto actual de la aplicación</param>
        public static void SetConfiguration(HttpContext _data)
        {
            try
            {
                CH_Configuracion data = new CH_Configuracion { Conexion = Comun.Conexion };
                CH_ConfiguracionNegocio configNeg = new CH_ConfiguracionNegocio();
                data = configNeg.ObtenerConfiguracionGeneral(data);
                _data.Session["Config"] = data;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //public bool IsCorrectConfiguration(HttpContext _data)
        //{
        //    try
        //    {
        //        return _data.Session["Config"] != null;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        
    }
}