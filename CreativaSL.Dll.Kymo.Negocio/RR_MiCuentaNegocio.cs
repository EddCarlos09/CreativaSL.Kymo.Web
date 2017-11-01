using CreativaSL.Dll.Kymo.Datos;
using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Negocio
{
    public class RR_MiCuentaNegocio
    {
        public RR_MiCuenta ObtenerDatosCuenta (RR_MiCuenta Datos)
        {
            try
            {
                RR_MiCuentaDatos MCD = new RR_MiCuentaDatos();
                return MCD.ObtenerDatosCuenta(Datos);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public RR_Pedido ObtenerPedidosCliente(RR_Pedido Datos)
        {
            try
            {
                RR_PedidoDatos MCD = new RR_PedidoDatos();
                return MCD.ObtenerPedidosCliente(Datos);
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
                RR_PedidoDatos MCD = new RR_PedidoDatos();
                return MCD.ObtenerDetallePedidosCliente(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
