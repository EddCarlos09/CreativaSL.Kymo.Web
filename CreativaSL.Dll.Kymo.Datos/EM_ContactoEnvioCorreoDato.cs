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
    public class EM_ContactoEnvioCorreoDato
    {
        public void ObtenerEnvioCorreo(CH_Contacto Datos)
        {
            try
            {
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_ContactoDatosEnviarCorreo");
                while (Dr.Read())
                {
                    Datos.CorreoRemitente = Dr.GetString(Dr.GetOrdinal("CorreoRemitente"));
                    Datos.PasswordCorreo = Dr.GetString(Dr.GetOrdinal("Passwords"));
                    Datos.CorreoDestinatario = Dr.GetString(Dr.GetOrdinal("CorreoDestinatario"));
                    Datos.Puerto = Dr.GetInt32(Dr.GetOrdinal("Puerto"));
                    Datos.EnableSSL = Dr.GetBoolean(Dr.GetOrdinal("EnableSsl"));
                    Datos.HostText = Dr.GetString(Dr.GetOrdinal("HostText"));
                    Datos.HtmlText = Dr.GetBoolean(Dr.GetOrdinal("HtmlText"));
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
