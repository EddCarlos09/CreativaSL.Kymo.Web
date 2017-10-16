using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public class DatosUser
    {
        private string _IdUsuario;
        public string IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        private int _IdTipoUsuario;
        public int IdTipoUsuario
        {
            get { return _IdTipoUsuario; }
            set { _IdTipoUsuario = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _DatosJson;
        public string DatosJson
        {
            get { return _DatosJson; }
            set { _DatosJson = value; }
        }


        public void GenerarJSON()
        {
            _DatosJson += "";
            DatosUserJson invitacionJson = new DatosUserJson
            {
                Nombre = _Nombre
            };
            DatosJson += invitacionJson.ToJSON();
            DatosJson += "";
        }
    }
}
