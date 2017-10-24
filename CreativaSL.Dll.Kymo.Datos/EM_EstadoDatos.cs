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
    public class EM_EstadoDatos
    {
        public List<EM_Estado> ObtenerComboxEstado(EM_Estado Datos)
        {
            try
            {
                List<EM_Estado> Lista = new List<EM_Estado>();
                EM_Estado Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_ComboCatEstado", Datos.IdPais);
                while (Dr.Read())
                {
                    Item = new EM_Estado();
                    Item.IdEstado = Dr.GetInt32(Dr.GetOrdinal("id_estado"));
                    Item.DescrpcionEs = Dr.GetString(Dr.GetOrdinal("descripcion"));
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
