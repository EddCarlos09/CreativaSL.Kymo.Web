using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición  de entidad cliente
    /// </summary>
    public class CH_Cliente
    {
        /// <summary>
        /// Constructor de la clase CH_Cliente
        /// </summary>
        public CH_Cliente()
        {

        }

        #region Datos de control

        private bool _Completado;
        /// <summary>
        /// Bandera que indica si se completó una operación
        /// </summary>
        public bool Completado
        {
            get { return _Completado; }
            set { _Completado = value; }
        }

        private string _Conexion;
        /// <summary>
        /// Cadena de conexión a la base de datos
        /// </summary>
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }

        private int _Resultado;
        /// <summary>
        /// Entero que devuelve un resultado de una operación
        /// </summary>
        public int Resultado
        {
            get { return _Resultado; }
            set { _Resultado = value; }
        }

        private string _IdUsuario;
        /// <summary>
        /// ID del usuario que realiza una operación
        /// </summary>
        public string IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        #endregion

        private string _IdCliente;
        /// <summary>
        /// Identificador del cliente
        /// </summary>
        public string IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        private bool _Entregado;
        /// <summary>
        /// Especifica si la tarjeta de fidelidad ya fue entregada
        /// </summary>
        public bool Entregado
        {
            get { return _Entregado; }
            set { _Entregado = value; }
        }

        private string _Nombre;
        /// <summary>
        /// Nombre del cliente
        /// </summary>
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _ApPat;
        /// <summary>
        /// Apellido paterno del cliente
        /// </summary>
        public string ApPat
        {
            get { return _ApPat; }
            set { _ApPat = value; }
        }

        private string _ApMat;
        /// <summary>
        /// Apellido materno del cliente
        /// </summary>
        public string ApMat
        {
            get { return _ApMat; }
            set { _ApMat = value; }
        }

        private string _Correo;
        /// <summary>
        /// Correo electrónico del cliente
        /// </summary>
        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        private string _Password;   
        /// <summary>
        /// Contraseña de la cuenta del cliente
        /// </summary>
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private int _IdPais;
        /// <summary>
        /// Identificador del país de residencia del cliente
        /// </summary>
        public int IdPais
        {
            get { return _IdPais; }
            set { _IdPais = value; }
        }

        private string _PaisDesc;
        /// <summary>
        /// Pais de residencia del cliente
        /// </summary>
        public string PaisDesc
        {
            get { return _PaisDesc; }
            set { _PaisDesc = value; }
        }

        private int _IdEstado;
        /// <summary>
        /// Identificador del estado de residencia del cliente
        /// </summary>
        public int IdEstado
        {
            get { return _IdEstado; }
            set { _IdEstado = value; }
        }

        private string _EstadoDesc;
        /// <summary>
        /// Estado de residencia del cliente
        /// </summary>
        public string EstadoDesc
        {
            get { return _EstadoDesc; }
            set { _EstadoDesc = value; }
        }

        private int _IdMunicipio;
        /// <summary>
        /// Identificador del municipio de residencia del cliente
        /// </summary>
        public int IdMunicipio
        {
            get { return _IdMunicipio; }
            set { _IdMunicipio = value; }
        }

        private string _MunicipioDesc;
        /// <summary>
        /// Municipio de residencia del cliente
        /// </summary>
        public string MunicipioDesc
        {
            get { return _MunicipioDesc; }
            set { _MunicipioDesc = value; }
        }

        private string _Colonia;
        /// <summary>
        /// Colonia de residencia del cliente
        /// </summary>
        public string Colonia
        {
            get { return _Colonia; }
            set { _Colonia = value; }
        }

        private string _Direccion;
        /// <summary>
        /// Dirección de residencia del cliente
        /// </summary>
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        private string _Telefono;
        /// <summary>
        /// Teléfono de contacto del cliente
        /// </summary>
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        private int _TotalCancelaciones;
        /// <summary>
        /// Total de pedidos cancelados por el cliente
        /// </summary>
        public int TotalCancelaciones
        {
            get { return _TotalCancelaciones; }
            set { _TotalCancelaciones = value; }
        }

        private int _TotalPendientes;
        /// <summary>
        /// Total de pedidos pendientes del cliente
        /// </summary>
        public int TotalPendientes
        {
            get { return _TotalPendientes; }
            set { _TotalPendientes = value; }
        }

        private int _TarjetaPuntos;
        /// <summary>
        /// Total de puntos en tarjeta de fidelidad del cliente 
        /// </summary>
        public int TarjetaPuntos
        {
            get { return _TarjetaPuntos; }
            set { _TarjetaPuntos = value; }
        }

        private decimal _TarjetaSaldo;
        /// <summary>
        /// Saldo disponible en la tarjeta de fidelidad del cliente
        /// </summary>
        public decimal TarjetaSaldo
        {
            get { return _TarjetaSaldo; }
            set { _TarjetaSaldo = value; }
        }

        private int _IdTipoCredencial;
        /// <summary>
        /// Nivel de la tarjeta de fidelidad que tiene el cliente
        /// </summary>
        public int IdTipoCredencial
        {
            get { return _IdTipoCredencial; }
            set { _IdTipoCredencial = value; }
        }

        private string _DatosJson;
        /// <summary>
        /// Cadena en formato Json que se almacenerá en la cookie de sesión
        /// </summary>
        public string DatosJson
        {
            get { return _DatosJson; }
            set { _DatosJson = value; }
        }


        /// <summary>
        /// Generar Json de los datos del cliente a registrar en la cookie de sesión
        /// </summary>
        public void GenerarJSON()
        {
            _DatosJson += "";
            CH_ClienteJson _customerJson = new CH_ClienteJson
            {
                IdCliente = _IdCliente,
                Entregado = _Entregado,
                Nombre = _Nombre,
                ApPat = _ApPat,
                ApMat = _ApMat,
                Correo = _Correo,
                IdPais = _IdPais,
                IdEstado = _IdEstado,
                IdMunicipio = _IdMunicipio,
                Colonia = _Colonia,
                Direccion = _Direccion,
                Telefono = _Telefono,
                TotalCancelaciones = _TotalCancelaciones,
                TotalPendientes = _TotalPendientes,
                TarjetaPuntos = _TarjetaPuntos,
                TarjetaSaldo = _TarjetaSaldo,
                IdTipoCredencial = _IdTipoCredencial
            };
            DatosJson += "";
        }

        /// <summary>
        /// Generar objeto ClienteJson para registrar en cookie de sesión
        /// </summary>
        /// <returns></returns>
        public CH_ClienteJson GetClienteJson()
        {
            try
            {
                CH_ClienteJson _customerJson = new CH_ClienteJson
                {
                    IdCliente = _IdCliente,
                    Entregado = _Entregado,
                    Nombre = _Nombre,
                    ApPat = _ApPat,
                    ApMat = _ApMat,
                    Correo = _Correo,
                    IdPais = _IdPais,
                    IdEstado = _IdEstado,
                    IdMunicipio = _IdMunicipio,
                    Colonia = _Colonia,
                    Direccion = _Direccion,
                    Telefono = _Telefono,
                    TotalCancelaciones = _TotalCancelaciones,
                    TotalPendientes = _TotalPendientes,
                    TarjetaPuntos = _TarjetaPuntos,
                    TarjetaSaldo = _TarjetaSaldo,
                    IdTipoCredencial = _IdTipoCredencial
                };
                return _customerJson;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
