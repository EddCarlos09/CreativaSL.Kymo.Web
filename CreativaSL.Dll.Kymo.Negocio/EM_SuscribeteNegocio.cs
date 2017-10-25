using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.Kymo.Datos;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class EM_SuscribeteNegocio
    {
        public void AC_Sucribirte(EM_Suscribite Datos)
        {
            try
            {
                EM_SuscribeteDatos SD = new EM_SuscribeteDatos();
                SD.AC_Suscribete(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
