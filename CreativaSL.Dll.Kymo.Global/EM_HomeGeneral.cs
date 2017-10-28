using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public class EM_HomeGeneral
    {
        private string _UrlImagen;
        /// <summary>
        /// Es la url completa de ruta donde se guarda la imagen
        /// </summary>
        public string UrlImagen
        {
            get { return _UrlImagen; }
            set { _UrlImagen = value; }
        }

        private string _Alt;
        /// <summary>
        /// Es el texto alternativo de la imagen para seo
        /// </summary>
        public string Alt
        {
            get { return _Alt; }
            set { _Alt = value; }
        }
        private string _Title;
        /// <summary>
        /// El es titulo de la imagen en seo
        /// </summary>
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        private int _NumPosition;
        /// <summary>
        /// Posición que ocupa la imagen dentro de la página
        /// </summary>
        public int NumPosition
        {
            get { return _NumPosition; }
            set { _NumPosition = value; }
        }
        private string _Conexion;
        /// <summary>
        /// Es la para asignar la cadena de conexion
        /// </summary>
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
    }
}
