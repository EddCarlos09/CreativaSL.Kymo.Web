using CreativaSL.Dll.Kymo.Datos;
using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class RR_PrecioProductosNegocio
    {
        public List<RR_PrecioJson> ObtenerPrecioProducto(CH_Producto Datos)
        {
            try
            {
                RR_PrecioProductosDatos CD = new RR_PrecioProductosDatos();
                return CD.ObtenerPrecioProducto(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
