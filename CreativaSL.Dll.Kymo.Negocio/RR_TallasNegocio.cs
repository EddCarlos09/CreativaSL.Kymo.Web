using CreativaSL.Dll.Kymo.Datos;
using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class RR_TallasNegocio
    {
        public List<RR_TallasJson> ObtenerTallasXIDColorProducto(CH_Producto Datos)
        {
            try
            {
                RR_TallasDatos CD = new RR_TallasDatos();
                return CD.ObtenerTallasXIDColorProducto(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
