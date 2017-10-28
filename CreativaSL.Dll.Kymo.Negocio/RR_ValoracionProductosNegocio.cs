using CreativaSL.Dll.Kymo.Datos;
using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class RR_ValoracionProductosNegocio
    {
        public void SetCalificacionProductos(RR_Valoraciones Datos)
        {
            RR_ValoracionProductosDatos VPD = new RR_ValoracionProductosDatos();
            VPD.SetCalificacionProductos(Datos);
        }
    }
}
