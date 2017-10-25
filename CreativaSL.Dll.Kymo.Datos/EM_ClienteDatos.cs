using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.Kymo.Global;
using Microsoft.ApplicationBlocks.Data;

namespace CreativaSL.Dll.Kymo.Datos
{
    public class EM_ClienteDatos
    {
        public void AC_Resgistro(EM_Clientes Datos)
        {
            try
            {
                object[] Parametros = { Datos.Nombre, Datos.ApPaterno, Datos.ApMaterno, Datos.CorreoElec, Datos.IdPais, Datos.IdEstado, Datos.Id_Municipio, Datos.FechaNac, Datos.Colonia, Datos.IdGenero, Datos.Telefono, Datos.Direccion, Datos.Contrasena, Datos.NewsLetters, Datos.IdUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "EM_spCSLDB_AC_CatClienteWeb", Parametros);
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
