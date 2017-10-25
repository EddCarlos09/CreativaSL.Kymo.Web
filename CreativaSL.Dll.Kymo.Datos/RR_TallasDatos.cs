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
    public class RR_TallasDatos
    {
        public List<RR_TallasJson> ObtenerTallasXIDColorProducto(CH_Producto Datos)
        {
            try
            {
                List<RR_TallasJson> Lista = new List<RR_TallasJson>();
                RR_TallasJson Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "CH_spCSLDB_get_TallaProductoXIDColor", Datos.IdProducto, Datos.Color.IdColor);
                while (Dr.Read())
                {
                    Item = new RR_TallasJson();
                    Item.IDTalla = Dr.GetInt32(Dr.GetOrdinal("IDTalla"));
                    Item.Descripcion = Dr.GetString(Dr.GetOrdinal("Descripcion"));
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
