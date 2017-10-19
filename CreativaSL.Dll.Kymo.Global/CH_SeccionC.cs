using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición de item de sección Tipo A (Titulo, TextoHTML, Imagen)
    /// </summary>
    public class CH_SeccionC
    {
        /// <summary>
        /// Inicializar datos
        /// </summary>
        public CH_SeccionC()
        {
            _Fotografia = new CH_Imagen();
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

        private string _Nombre;
        /// <summary>
        /// Nombre del miembro del equipo de trabajo
        /// </summary>
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Puesto;
        /// <summary>
        /// Puesto del miembro del equipo de trabajo
        /// </summary>
        public string Puesto
        {
            get { return _Puesto; }
            set { _Puesto = value; }
        }

        private CH_Imagen _Fotografia;
        /// <summary>
        /// Objeto que contiene los datos de la fotografía del miembro del equipo de trabajo
        /// </summary>
        public CH_Imagen Fotografia
        {
            get { return _Fotografia; }
            set { _Fotografia = value; }
        }

        private List<CH_RedesSociales> _ListaRedesSociales;
        /// <summary>
        /// Redes sociales de la sección
        /// </summary>
        public List<CH_RedesSociales> ListaRedesSociales
        {
            get { return _ListaRedesSociales; }
            set { _ListaRedesSociales = value; }
        }


    }
}
