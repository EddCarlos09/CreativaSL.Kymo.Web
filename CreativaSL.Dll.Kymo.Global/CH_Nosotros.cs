using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición de datos para la página Nosotros
    /// </summary>
    public class CH_Nosotros
    {
        /// <summary>
        /// Inicializa los datos de la clase
        /// </summary>
        public CH_Nosotros()
        {
            _ListaImagenes = new List<CH_Imagen>();
            _ListaTextos = new List<CH_Textos>();
            _ListaSeccionA = new List<CH_SeccionA>();
            _ListaSeccionB = new List<CH_SeccionB>();
            _ListaSeccionC = new List<CH_SeccionC>();
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

        private List<CH_Textos> _ListaTextos;
        /// <summary>
        /// Lista que contiene los textos a mostrar en la página Web
        /// </summary>
        public List<CH_Textos> ListaTextos
        {
            get { return _ListaTextos; }
            set { _ListaTextos = value; }
        }

        private List<CH_Imagen> _ListaImagenes;
        /// <summary>
        /// Lista que contiene las imágenes a mostrar en la página Web 
        /// </summary>
        public List<CH_Imagen> ListaImagenes
        {
            get { return _ListaImagenes; }
            set { _ListaImagenes = value; }
        }

        private List<CH_SeccionA> _ListaSeccionA;
        /// <summary>
        /// Elementos de la sección ¿quienes somos?
        /// </summary>
        public List<CH_SeccionA> ListaSeccionA
        {
            get { return _ListaSeccionA; }
            set { _ListaSeccionA = value; }
        }

        private List<CH_SeccionB> _ListaSeccionB;
        /// <summary>
        /// Elementos de la sección ¿por qué elegirnos?
        /// </summary>
        public List<CH_SeccionB> ListaSeccionB
        {
            get { return _ListaSeccionB; }
            set { _ListaSeccionB = value; }
        }

        private List<CH_SeccionC> _ListaSeccionC;
        /// <summary>
        /// Elementos de la sección Equipo de trabajo
        /// </summary>
        public List<CH_SeccionC> ListaSeccionC
        {
            get { return _ListaSeccionC; }
            set { _ListaSeccionC = value; }
        }


    }
}
