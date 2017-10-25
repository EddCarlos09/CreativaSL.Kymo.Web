using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public class EM_Suscribite
    {
        private string _IdSucribete;

        public string IdSucribete
        {
            get { return _IdSucribete; }
            set { _IdSucribete = value; }
        }
        private string _NombreSuscribete;

        public string NombreSuscribete
        {
            get { return _NombreSuscribete; }
            set { _NombreSuscribete = value; }
        }
        private string _Correo;

        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        private string _IdUsuario;

        public string IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }
        private string _Conexion;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }

        private bool _Completado;

        public bool Completado
        {
            get { return _Completado; }
            set { _Completado = value; }
        }

        private int _Resultado;

        public int Resultado
        {
            get { return _Resultado; }
            set { _Resultado = value; }
        }

    }
}
