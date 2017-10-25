using CreativaSL.Dll.Kymo.Datos;
using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class EM_ContactoCorreoNegocio
    {
        public void A_ContactoCorreo(EM_ContactoCorreo Datos)
        {
            try
            {
                EM_ContactoCorreoDatos SD = new EM_ContactoCorreoDatos();
                SD.A_ContactoCorreo(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
