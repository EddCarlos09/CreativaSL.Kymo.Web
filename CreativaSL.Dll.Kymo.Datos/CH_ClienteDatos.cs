using CreativaSL.Dll.Kymo.Global;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Datos
{
    /// <summary>
    /// Clase de acceso a datos para información de cliente
    /// </summary>
    public class CH_ClienteDatos
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
                CH_Cliente dataCustomer = new CH_Cliente();
                object[] parametros = { _datos.Correo, _datos.Password };
                SqlDataReader dr = SqlHelper.ExecuteReader(_datos.Conexion, "CH_spCSLDB_web_Login", parametros);
                while(dr.Read())
                {
                    dataCustomer.Resultado = dr.GetInt32(dr.GetOrdinal("Resultado"));
                    if(dataCustomer.Resultado == 1)
                    {
                        dataCustomer.IdCliente = dr.GetString(dr.GetOrdinal("IDCliente"));
                        dataCustomer.Entregado = dr.GetBoolean(dr.GetOrdinal("Entregado"));
                        dataCustomer.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                        dataCustomer.ApPat = dr.GetString(dr.GetOrdinal("ApPat"));
                        dataCustomer.ApMat = dr.GetString(dr.GetOrdinal("ApMat"));
                        dataCustomer.Correo = dr.GetString(dr.GetOrdinal("Correo"));
                        dataCustomer.IdPais = dr.GetInt32(dr.GetOrdinal("IDPais"));
                        dataCustomer.IdEstado = dr.GetInt32(dr.GetOrdinal("IDEstado"));
                        dataCustomer.IdMunicipio = dr.GetInt32(dr.GetOrdinal("IDMunicipio"));
                        dataCustomer.Colonia = dr.GetString(dr.GetOrdinal("Colonia"));
                        dataCustomer.Direccion = dr.GetString(dr.GetOrdinal("Direccion"));
                        dataCustomer.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));
                        dataCustomer.TotalCancelaciones = dr.GetInt32(dr.GetOrdinal("TotalCancelaciones"));
                        dataCustomer.TotalPendientes = dr.GetInt32(dr.GetOrdinal("TotalPendientes"));
                        dataCustomer.TarjetaPuntos = dr.GetInt32(dr.GetOrdinal("Puntos"));
                        dataCustomer.TarjetaSaldo = dr.GetDecimal(dr.GetOrdinal("Saldo"));
                        dataCustomer.IdTipoCredencial = dr.GetInt32(dr.GetOrdinal("TipoCredencial"));
                    }
                    dataCustomer.Completado = true;
                    break;
                }
                return dataCustomer;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
