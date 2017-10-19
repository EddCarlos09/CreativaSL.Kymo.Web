using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición de imágenes de las páginas WEB
    /// </summary>
    public class CH_Imagen
    {
        private string _Alt;
        /// <summary>
        /// Texto alternativo de la imagen
        /// </summary>
        public string Alt
        {
            get { return _Alt; }
            set { _Alt = value; }
        }

        private string _Title;
        /// <summary>
        /// Título de la imagen
        /// </summary>
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        
        private string _UrlImagen;
        /// <summary>
        /// Url de la imagen a mostrar
        /// </summary>
        public string UrlImagen
        {
            get { return _UrlImagen; }
            set { _UrlImagen = value; }
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

    }
}
