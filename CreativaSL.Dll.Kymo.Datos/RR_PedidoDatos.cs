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
    public class RR_PedidoDatos
    {
        public RR_Pedido ObtenerPedidosCliente(RR_Pedido Datos)
        {
            try
            {
                object[] Parametros = { Datos.Cliente.IdCliente };
                RR_MiCuenta DatosCuenta = new RR_MiCuenta();
                DataSet ds = SqlHelper.ExecuteDataset(Datos.Conexion, "RR_spCSLDB_getPedidosWeb", Parametros);
                if (ds != null)
                {
                    if (ds.Tables.Count == 1)
                    {
                        DataTableReader dr = ds.Tables[0].CreateDataReader();
                        List<CH_VentaDetalle> listaVenta = new List<CH_VentaDetalle>();
                        CH_VentaDetalle itemCuenta;
                        while (dr.Read())
                        {
                            itemCuenta = new CH_VentaDetalle();
                            itemCuenta.IdCarritoDetalle = dr.GetString(dr.GetOrdinal("id_venta"));
                            itemCuenta.Folio = dr.GetString(dr.GetOrdinal("folio"));
                            itemCuenta.FechaVenta = dr.GetDateTime(dr.GetOrdinal("fec_venta"));                            
                            listaVenta.Add(itemCuenta);
                        }
                        Datos.ListaVentaDetalle = listaVenta;
                    }
                }
                return Datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RR_Pedido ObtenerDetallePedidosCliente(RR_Pedido Datos)
        {
            try
            {
                object[] Parametros = { Datos.Cliente.IdCliente, Datos.VentaDetalle.IdCarritoDetalle };
                RR_MiCuenta DatosCuenta = new RR_MiCuenta();
                DataSet ds = SqlHelper.ExecuteDataset(Datos.Conexion, "RR_spCSLDB_getPedidosClienteDetalle", Parametros);
                if (ds != null)
                {
                    if (ds.Tables.Count == 1)
                    {
                        DataTableReader dr = ds.Tables[0].CreateDataReader();
                        List<CH_VentaDetalle> listaVenta = new List<CH_VentaDetalle>();
                        CH_VentaDetalle itemCuenta;
                        while (dr.Read())
                        {
                            itemCuenta = new CH_VentaDetalle();
                            itemCuenta.IdCarritoDetalle = dr.GetString(dr.GetOrdinal("id_venta"));
                            itemCuenta.Folio = dr.GetString(dr.GetOrdinal("folio"));
                            itemCuenta.FechaVenta = dr.GetDateTime(dr.GetOrdinal("fec_venta"));
                            itemCuenta.Subtotal = dr.GetDecimal(dr.GetOrdinal("subtotal"));
                            itemCuenta.Total = dr.GetDecimal(dr.GetOrdinal("total"));
                            itemCuenta.Producto.NombreProducto = dr.GetString(dr.GetOrdinal("nombreProducto"));
                            listaVenta.Add(itemCuenta);
                        }
                        Datos.ListaVentaDetalle = listaVenta;
                    }
                }
                return Datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
