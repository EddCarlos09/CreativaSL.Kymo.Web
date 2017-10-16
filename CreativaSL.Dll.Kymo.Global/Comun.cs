using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public static class Comun
    {
        private static string _Conexion = string.Empty;

        public static string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }

    }
}
