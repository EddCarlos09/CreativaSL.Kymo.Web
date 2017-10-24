using CreativaSL.Dll.Kymo.Datos;
using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class EM_EstadoNegocio
    {
        public List<EM_Estado> ObtenerComboEstados(EM_Estado Datos)
        {
            try
            {
                EM_EstadoDatos ED = new EM_EstadoDatos();
                return ED.ObtenerComboxEstado(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
