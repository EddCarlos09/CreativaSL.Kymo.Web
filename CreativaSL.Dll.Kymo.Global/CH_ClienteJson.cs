using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición de datos del cliente a almacenar en Cookie Session
    /// </summary>
    public class CH_ClienteJson
    {
        /// <summary>
        /// Identificador del cliente
        /// </summary>
        public string IdCliente { get; set; }
        /// <summary>
        /// Especifica si la tarjeta de fidelidad ya fue entregada
        /// </summary>
        public bool Entregado { get; set; }
        /// <summary>
        /// Nombre del cliente
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Apellido paterno del cliente
        /// </summary>
        public string ApPat { get; set; }
        /// <summary>
        /// Apellido materno del cliente
        /// </summary>
        public string ApMat { get; set; }
        /// <summary>
        /// Correo electrónico del cliente
        /// </summary>
        public string Correo { get; set; }
        /// <summary>
        /// Identificador del país de residencia del cliente
        /// </summary>
        public int IdPais { get; set; }
        /// <summary>
        /// Identificador del estado de residencia del cliente
        /// </summary>
        public int IdEstado { get; set; }
        /// <summary>
        /// Identificador del municipio de residencia del cliente
        /// </summary>
        public int IdMunicipio { get; set; }
        /// <summary>
        /// Colonia de residencia del cliente
        /// </summary>
        public string Colonia { get; set; }
        /// <summary>
        /// Dirección de residencia del cliente
        /// </summary>
        public string Direccion { get; set; }
        /// <summary>
        /// Teléfono de contacto del cliente
        /// </summary>
        public string Telefono { get; set; }
        /// <summary>
        /// Total de pedidos cancelados por el cliente
        /// </summary>
        public int TotalCancelaciones { get; set; }
        /// <summary>
        /// Total de pedidos pendientes del cliente
        /// </summary>
        public int TotalPendientes { get; set; }
        /// <summary>
        /// Total de puntos en tarjeta de fidelidad del cliente 
        /// </summary>
        public int TarjetaPuntos { get; set; }
        /// <summary>
        /// Saldo disponible en la tarjeta de fidelidad del cliente
        /// </summary>
        public decimal TarjetaSaldo { get; set; }
        /// <summary>
        /// Nivel de la tarjeta de fidelidad que tiene el cliente
        /// </summary>
        public int IdTipoCredencial { get; set; }
    }
}
