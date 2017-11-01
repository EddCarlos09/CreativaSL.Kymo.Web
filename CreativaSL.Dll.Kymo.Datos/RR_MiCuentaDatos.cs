using CreativaSL.Dll.Kymo.Global;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Datos
{
    public class RR_MiCuentaDatos
    {
        public RR_MiCuenta ObtenerDatosCuenta(RR_MiCuenta Datos)
        {
            try
            {
                object[] Parametros = { Datos.Cliente.IdCliente };
                RR_MiCuenta DatosCuenta = new RR_MiCuenta();
                DataSet ds = SqlHelper.ExecuteDataset(Datos.Conexion, "RR_spCSLDB_getDatosCliente", Parametros);
                if(ds != null)
                {
                    if (ds.Tables.Count == 1)
                    {
                        DataTableReader dr = ds.Tables[0].CreateDataReader();
                        List<CH_Cliente> listaCuenta = new List<CH_Cliente>();
                        CH_Cliente itemCuenta;
                        while (dr.Read())
                        {
                            itemCuenta = new CH_Cliente();
                            itemCuenta.IdCliente = dr.GetString(dr.GetOrdinal("id_cliente"));
                            itemCuenta.Nombre = dr.GetString(dr.GetOrdinal("nombre"));
                            itemCuenta.ApPat = dr.GetString(dr.GetOrdinal("apePat"));
                            itemCuenta.ApMat = dr.GetString(dr.GetOrdinal("apeMat"));
                            itemCuenta.Correo = dr.GetString(dr.GetOrdinal("correoElectronico"));
                            itemCuenta.IdPais = dr.GetInt32(dr.GetOrdinal("id_pais"));
                            itemCuenta.IdEstado = dr.GetInt32(dr.GetOrdinal("id_estado"));
                            itemCuenta.IdMunicipio = dr.GetInt32(dr.GetOrdinal("id_municipio"));
                            itemCuenta.Colonia = dr.GetString(dr.GetOrdinal("colonia"));
                            itemCuenta.Telefono = dr.GetString(dr.GetOrdinal("telefono"));
                            itemCuenta.Password = dr.GetString(dr.GetOrdinal("password"));
                            itemCuenta.Direccion = dr.GetString(dr.GetOrdinal("direccion"));
                            listaCuenta.Add(itemCuenta);
                        }
                        DatosCuenta.ListaCliente = listaCuenta;
                    }
                }
                return DatosCuenta;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
