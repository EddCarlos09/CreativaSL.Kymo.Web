using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.Kymo.Global;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace CreativaSL.Dll.Kymo.Datos
{
    public class EM_ClienteDatos
    {
        /// <summary>
        /// Se envia la los datos a la base de datos
        /// </summary>
        /// <param name="Datos">Los datos de coneccion y parametros que recibe</param>
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
        /// <summary>
        /// Se obtiene los datos de nuestro clientee logueado
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerClienteLogueado(EM_Clientes Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdCliente };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_ClienteWebLoguado", Parametros);
                while (Dr.Read())
                {
                    Datos.IdCliente = Dr.GetString(Dr.GetOrdinal("IdCliente"));
                    Datos.Nombre = Dr.GetString(Dr.GetOrdinal("Nombre"));
                    Datos.ApPaterno = Dr.GetString(Dr.GetOrdinal("ApPaterno"));
                    Datos.ApMaterno = Dr.GetString(Dr.GetOrdinal("APMaterno"));
                    Datos.FechaNac = Dr.GetDateTime(Dr.GetOrdinal("FechaNac"));
                    Datos.IdEstado = Dr.GetInt32(Dr.GetOrdinal("IdEstado"));
                    Datos.Id_Municipio = Dr.GetInt32(Dr.GetOrdinal("IdMunicipio"));
                    Datos.Direccion = Dr.GetString(Dr.GetOrdinal("Direccion"));
                    Datos.Telefono = Dr.GetString(Dr.GetOrdinal("Telefono"));
                    Datos.CorreoElec = Dr.GetString(Dr.GetOrdinal("Correo"));
                    Datos.Colonia = Dr.GetString(Dr.GetOrdinal("Colonia"));
                    Datos.IdGenero = Dr.GetInt32(Dr.GetOrdinal("IdGenero"));
                    Datos.Completado = true;
                    break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
