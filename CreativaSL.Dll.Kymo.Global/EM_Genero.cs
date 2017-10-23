using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public class EM_Genero
    {
        private int _IdGenero;

        public int IdGenero
        {
            get { return _IdGenero; }
            set { _IdGenero = value; }
        }

        private string _NombreGenero;

        public string NombreGenero
        {
            get { return _NombreGenero; }
            set { _NombreGenero = value; }
        }

        private string _Conexion;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }

    }
}
