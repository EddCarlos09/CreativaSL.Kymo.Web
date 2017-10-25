using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.Kymo.Global;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace CreativaSL.Dll.Kymo.Datos
{
    public class EM_GeneroDatos
    {
        public List<EM_Genero> ObtenerComboGenero(EM_Genero Datos)
        {
            try
            {
                List<EM_Genero> Lista = new List<EM_Genero>();
                EM_Genero Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_ComboCatGenero");
                while (Dr.Read())
                {
                    Item = new EM_Genero();
                    Item.IdGenero = Dr.GetInt32(Dr.GetOrdinal(("id_genero")));
                    Item.NombreGenero = Dr.GetString(Dr.GetOrdinal("descripcion"));
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
