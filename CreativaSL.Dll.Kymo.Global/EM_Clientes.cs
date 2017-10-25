using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public class EM_Clientes
    {
        private string _IdCliente;
        /// <summary>
        /// Sirve para Realizar una accion
        /// </summary>
        public string IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }
        private string _Nombre;
        /// <summary>
        /// El nombre de nuestro nuevo cliente
        /// </summary>
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        private string _ApPaterno;
        /// <summary>
        /// El apellido del cliente
        /// </summary>
        public string ApPaterno
        {
            get { return _ApPaterno; }
            set { _ApPaterno = value; }
        }
        private string _ApMaterno;
        /// <summary>
        /// El Apellido de el cliente
        /// </summary>
        public string ApMaterno
        {
            get { return _ApMaterno; }
            set { _ApMaterno = value; }
        }
        private string _CorreoElec;
        /// <summary>
        /// El correo Electronico que el es usuario del cliente
        /// </summary>
        public string CorreoElec
        {
            get { return _CorreoElec; }
            set { _CorreoElec = value; }
        }
        private string _Contrasena;

        public string Contrasena
        {
            get { return _Contrasena; }
            set { _Contrasena = value; }
        }

        private int _IdPais;
        /// <summary>
        /// El id del pais que por defaul es mexico
        /// </summary>
        public int IdPais
        {
            get { return _IdPais; }
            set { _IdPais = value; }
        }
        private int _IdEstado;
        /// <summary>
        /// El id del estado que de donde vive el cliente 
        /// </summary>
        public int IdEstado
        {
            get { return _IdEstado; }
            set { _IdEstado = value; }
        }

        private int _IdMunicipio;
        /// <summary>
        /// el ide del municipio del cliente
        /// </summary>
        public int Id_Municipio
        {
            get { return _IdMunicipio; }
            set { _IdMunicipio = value; }
        }
        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        private DateTime _FechaNac;
        /// <summary>
        /// la fecha de nacimiento del cliente
        /// </summary>
        public DateTime FechaNac
        {
            get { return _FechaNac; }
            set { _FechaNac = value; }
        }
        private string _Colonia;
        /// <summary>
        /// la colonia del cliente
        /// </summary>
        public string Colonia
        {
            get { return _Colonia; }
            set { _Colonia = value; }
        }
        private int _IdGenero;
        /// <summary>
        /// El genero de el cliente
        /// </summary>
        public int IdGenero
        {
            get { return _IdGenero; }
            set { _IdGenero = value; }
        }
        private string _Telefono;
        /// <summary>
        /// El telefono de el cliente
        /// </summary>
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        private string _Conexion;
        /// <summary>
        /// La cadena de conexion de la base de datos
        /// </summary>
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        private bool _NewsLetters;

        public bool NewsLetters
        {
            get { return _NewsLetters; }
            set { _NewsLetters = value; }
        }

        private string _IdUsuario;
        /// <summary>
        /// El Usuario que por defaul es Web
        /// </summary>
        public string IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
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
