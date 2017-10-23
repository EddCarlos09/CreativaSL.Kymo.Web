using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public class RR_TerminosCondiciones
    {
        public RR_TerminosCondiciones()
        {
            _ListaTerminos = new List<CH_SeccionB>();
            _ListaImagenes = new List<CH_Imagen>();
            _ListaTextos = new List<CH_Textos>();
        }

        private List<CH_Textos> _ListaTextos;
        public List<CH_Textos> ListaTextos
        {
            get { return _ListaTextos; }
            set { _ListaTextos = value; }
        }

        private List<CH_Imagen> _ListaImagenes;
        public List<CH_Imagen> ListaImagenes
        {
            get { return _ListaImagenes; }
            set { _ListaImagenes = value; }
        }

        private List<CH_SeccionB> _ListaTerminos;
        public List<CH_SeccionB> ListaTerminos
        {
            get { return _ListaTerminos; }
            set { _ListaTerminos = value; }
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
    }
}
