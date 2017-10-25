using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.Kymo.Global;

namespace CreativaSL.Dll.Kymo.Datos
{
    public class EM_ContactoCorreoDatos
    {
        public void A_ContactoCorreo(EM_ContactoCorreo Datos)
        {
            try
            {
                object[] Parametros = { Datos.Nombre, Datos.Correo, Datos.Telefono, Datos.Direccion, Datos.Mensaje, Datos.IdUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "JL_spCSLDB_A_ContactoCorreo", Parametros);
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
