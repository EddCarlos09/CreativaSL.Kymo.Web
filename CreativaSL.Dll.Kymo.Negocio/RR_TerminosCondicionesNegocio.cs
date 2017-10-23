using CreativaSL.Dll.Kymo.Datos;
using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class RR_TerminosCondicionesNegocio
    {
        public RR_TerminosCondiciones ObtenerDatosTerminosCondiciones(RR_TerminosCondiciones _datos)
        {
            try
            {
                RR_TerminosCondicionesDatos terminosDatos = new RR_TerminosCondicionesDatos();
                return terminosDatos.ObtenerDatosTerminosCondiciones(_datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
