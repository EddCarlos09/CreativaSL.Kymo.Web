using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Datos;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class EM_ContactoEnviarCorreoNegocio
    {
        public void ObtenerDatosEnvioCorreo(CH_Contacto Datos)
        {
            try
            {
                EM_ContactoEnvioCorreoDato CD = new EM_ContactoEnvioCorreoDato();
                CD.ObtenerEnvioCorreo(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
