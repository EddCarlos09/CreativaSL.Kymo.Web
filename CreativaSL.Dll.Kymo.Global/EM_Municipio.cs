using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public class EM_Municipio
    {
        private int _IDMunicipio;

        public int IDMunicipio
        {
            get { return _IDMunicipio; }
            set { _IDMunicipio = value; }
        }

        private int _IDEstado;

        public int IDEstado
        {
            get { return _IDEstado; }
            set { _IDEstado = value; }
        }
        private string _Conexion;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }

    }
}
