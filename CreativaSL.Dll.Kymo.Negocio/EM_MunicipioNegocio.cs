using CreativaSL.Dll.Kymo.Datos;
using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class EM_MunicipioNegocio
    {
        public List<EM_MunicipioJSON> ObtenerMunicipiosXIDEstado(EM_Municipio Datos)
        {
            try
            {
                EM_MunicipioDatos CD = new EM_MunicipioDatos();
                return CD.ObtenerMunicipiosXIDEstado(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
