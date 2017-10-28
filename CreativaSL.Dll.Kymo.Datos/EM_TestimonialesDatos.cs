using CreativaSL.Dll.Kymo.Global;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Datos
{
    public class EM_TestimonialesDatos
    {
        /// <summary>
        /// Es el metodo conector para realizar la operacion indicada
        /// </summary>
        /// <param name="Datos">Se envia la cadena de conexion y los parametros que recibe</param>
        public void A_TestimonialesD(EM_Testimoniales Datos)
        {
            try
            {
                object[] Parametros = { Datos.NombreCompleto, Datos.Comentario, Datos.IdUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "EM_spCSLDB_AC_Home_Testimoniales", Parametros);
                if (Result != null)
                {
                    int Resultado = 0;
                    int.TryParse(Result.ToString(), out Resultado);
                    if (Resultado == 1)
                    {
                        Datos.Completado = true;
                    }
                    Datos.Resultado = Resultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
