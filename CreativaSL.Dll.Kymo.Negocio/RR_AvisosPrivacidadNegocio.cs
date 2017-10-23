using CreativaSL.Dll.Kymo.Datos;
using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class RR_AvisosPrivacidadNegocio
    {
        public RR_AvisoPrivacidad ObtenerDatosPagAvisos(RR_AvisoPrivacidad _datos)
        {
            try
            {
                RR_AvisoPrivacidadDatos avisosDatos = new RR_AvisoPrivacidadDatos();
                return avisosDatos.ObtenerDatosPagAvisos(_datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
