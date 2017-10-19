using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Clase con datos staticos globales
    /// </summary>
    public static class Comun
    {
        
        private static string _Conexion = string.Empty;
        /// <summary>
        /// Mantiene la cadena de conexión. Se obtiene al lanzar la aplicación
        /// </summary>
        public static string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }

    }
}
