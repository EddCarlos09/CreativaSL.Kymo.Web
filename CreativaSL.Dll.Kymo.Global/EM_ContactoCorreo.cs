using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public class EM_ContactoCorreo
    {
        private string _IdCorreo;

        public string IdCorreo
        {
            get { return _IdCorreo; }
            set { _IdCorreo = value; }
        }
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        private string _Correo;

        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }
        private string _Telefono;

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        private string _Mensaje;

        public string Mensaje
        {
            get { return _Mensaje; }
            set { _Mensaje = value; }
        }
        private bool _Leido;

        public bool Leido
        {
            get { return _Leido; }
            set { _Leido = value; }
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
        private string _Conexion;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        private string _IdUsuario;

        public string IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

    }
}
