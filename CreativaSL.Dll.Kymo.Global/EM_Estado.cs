using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public class EM_Estado
    {
        private int _IdEstado;

        public int IdEstado
        {
            get { return _IdEstado; }
            set { _IdEstado = value; }
        }

        private string _DescripcionEs;

        public string DescrpcionEs
        {
            get { return _DescripcionEs; }
            set { _DescripcionEs = value; }
        }
        private int _IdPais;

        public int IdPais
        {
            get { return _IdPais; }
            set { _IdPais = value; }
        }

        private string _Conexion;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }

    }
}
