using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición de item de sección tipo B (Icono, Titulo, Texto)
    /// </summary>
    public class CH_SeccionB
    {
        /// <summary>
        /// Inicializar datos
        /// </summary>
        public CH_SeccionB()
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

        private string _Titulo;
        /// <summary>
        /// Título de la sección
        /// </summary>
        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        private string _Texto;
        /// <summary>
        /// Texto de la sección
        /// </summary>
        public string Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }

        private string _CssClass;
        /// <summary>
        /// Clase del ícono a mostrar en la sección
        /// </summary>
        public string CssClass
        {
            get { return _CssClass; }
            set { _CssClass = value; }
        }

    }
}