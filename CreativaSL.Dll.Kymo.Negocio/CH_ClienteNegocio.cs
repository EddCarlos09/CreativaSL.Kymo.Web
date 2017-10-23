using CreativaSL.Dll.Kymo.Datos;
using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Negocio
{
    /// <summary>
    /// Define las reglas de negocio para los clientes
    /// </summary>
    public class CH_ClienteNegocio
    {
        /// <summary>
        /// Validar credenciales de un cliente
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros (Usuario y contraseña)</param>
        /// <returns></returns>
        public CH_Cliente Login(CH_Cliente _datos)
        {
            try
            {
                CH_ClienteDatos clienteDatos = new CH_ClienteDatos();
                return clienteDatos.Login(_datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
