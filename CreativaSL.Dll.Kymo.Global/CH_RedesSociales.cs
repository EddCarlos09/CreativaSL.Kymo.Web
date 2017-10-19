using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición de entidad Red Social
    /// </summary>
    public class CH_RedesSociales
    {
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
        
        private string _Cuenta;
        /// <summary>
        /// Cuenta de la red social a la que se redigirá
        /// </summary>
        public string Cuenta
        {
            get { return _Cuenta; }
            set { _Cuenta = value; }
        }
        
        private string _CssClass;
        /// <summary>
        /// Clase con la que se dibujará la red social
        /// </summary>
        public string CssClass
        {
            get { return _CssClass; }
            set { _CssClass = value; }
        }
        
        private string _CssClassIcon;
        /// <summary>
        /// Clase con la que se dibujará el ícono de la red social
        /// </summary>
        public string CssClassIcon
        {
            get { return _CssClassIcon; }
            set { _CssClassIcon = value; }
        }
        private string _Nombre;
        /// <summary>
        /// Nombre de la red Social
        /// </summary>
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        
        private string _UrlBase;
        /// <summary>
        /// Url base de la red social
        /// </summary>
        public string UrlBase
        {
            get { return _UrlBase; }
            set { _UrlBase = value; }
        }



    }
}
