using CreativaSL.Dll.Kymo.Datos;
using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class EM_TertimonialesNegocio
    {
        /// <summary>
        /// Es el metodo que va a recibir los testimoniales
        /// </summary>
        /// <param name="Datos">Se envia la cadena de conexion y lo parametros que recibe</param>
        public void A_Testimoniales(EM_Testimoniales Datos)
        {
            try
            {
                EM_TestimonialesDatos SD = new EM_TestimonialesDatos();
                SD.A_TestimonialesD(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
