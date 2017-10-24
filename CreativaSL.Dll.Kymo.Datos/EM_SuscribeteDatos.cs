using CreativaSL.Dll.Kymo.Global;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Datos
{
    public class EM_SuscribeteDatos
    {
        public void AC_Suscribete(EM_Suscribite Datos)
        {
            try
            {
                object[] Parametros = { Datos.NombreSuscribete, Datos.Correo, Datos.IdUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "EM_spCSLDB_AC_Home_Newsletter", Parametros);
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
