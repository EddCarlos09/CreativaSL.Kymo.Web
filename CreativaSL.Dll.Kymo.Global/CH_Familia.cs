using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición de entidad Familia de productos
    /// </summary>
    public class CH_Familia
    {
        /// <summary>
        /// Inicializa datos de la clase
        /// </summary>
        public CH_Familia()
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

        private int _IdFamilia;
        /// <summary>
        /// Identificador de entidad Familia de productos
        /// </summary>
        public int IdFamilia
        {
            get { return _IdFamilia; }
            set { _IdFamilia = value; }
        }

        private string _Descripcion;
        /// <summary>
        /// Texto descriptivo de familia de productos
        /// </summary>
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

    }
}
