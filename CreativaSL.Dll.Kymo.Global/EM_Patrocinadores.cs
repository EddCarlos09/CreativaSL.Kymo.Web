using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public class EM_Patrocinadores
    {
        private string _IdPatrocinadores;
        /// <summary>
        /// Es para realizar una operacion
        /// </summary>
        public string IdPatrocinadores
        {
            get { return _IdPatrocinadores; }
            set { _IdPatrocinadores = value; }
        }
        
        private string _UrlDestino;
        /// <summary>
        /// La es si se activa el boton comprar se pedira un url del boton
        /// </summary>
        public string UrlDestino
        {
            get { return _UrlDestino; }
            set { _UrlDestino = value; }
        }
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
       
        #region DatosDeControl
        private string _Conexion;
        /// <summary>
        /// Es la para asignar la cadena de conexion
        /// </summary>
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        private string _IDUsuario;
        /// <summary>
        /// Es para signar el usuario que se encuentra logeado en nuestro sistema
        /// </summary>
        public string IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }

        private DataTable _TablaDatos;
        /// <summary>
        /// ???
        /// </summary>
        public DataTable TablaDatos
        {
            get { return _TablaDatos; }
            set { _TablaDatos = value; }
        }
        #endregion
    }
}
