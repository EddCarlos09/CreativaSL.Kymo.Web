using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Datos;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class EM_ClienteNegocio
    {
        public void AC_RegistroClientes(EM_Clientes Datos)
        {
            try
            {
                EM_ClienteDatos CD = new EM_ClienteDatos();
                CD.AC_Resgistro(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
