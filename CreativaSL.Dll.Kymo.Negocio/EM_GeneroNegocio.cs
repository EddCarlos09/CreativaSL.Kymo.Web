using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Datos;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class EM_GeneroNegocio
    {
        public List<EM_Genero> ObtenerGeneroCombo(EM_Genero Datos)
        {
            try
            {
                EM_GeneroDatos GN = new EM_GeneroDatos();
                return GN.ObtenerComboGenero(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
