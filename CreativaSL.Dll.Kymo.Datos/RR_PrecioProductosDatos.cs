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
    public class RR_PrecioProductosDatos
    {
        public List<RR_PrecioJson> ObtenerPrecioProducto(CH_Producto Datos)
        {
            try
            {
                List<RR_PrecioJson> Lista = new List<RR_PrecioJson>();
                RR_PrecioJson Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "CH_spCSLDB_get_PrecioProducto", Datos.IdProducto, Datos.Talla.IdTalla, Datos.Color.IdColor);
                while (Dr.Read())
                {
                    Item = new RR_PrecioJson();
                    Item.Precio = Dr.GetDecimal(Dr.GetOrdinal("precio"));
                    Item.PrecioMayoreo = Dr.GetDecimal(Dr.GetOrdinal("precioMayoreo"));
                    Lista.Add(Item);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
