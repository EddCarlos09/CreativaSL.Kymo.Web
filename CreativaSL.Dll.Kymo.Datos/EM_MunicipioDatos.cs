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
    public class EM_MunicipioDatos
    {
        public List<EM_MunicipioJSON> ObtenerMunicipiosXIDEstado(EM_Municipio Datos)
        {
            try
            {
                List<EM_MunicipioJSON> Lista = new List<EM_MunicipioJSON>();
                EM_MunicipioJSON Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_ComboCatMunicipio", Datos.IDEstado);
                while (Dr.Read())
                {
                    Item = new EM_MunicipioJSON();
                    Item.IDMunicipio = Dr.GetInt32(Dr.GetOrdinal("IDMunicipio"));
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
