using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public class EM_Testimoniales
    {
        
        private string _NombreCompleto;
        /// <summary>
        /// Es el nombre de quienes escribien el testimonial
        /// </summary>
        public string NombreCompleto
        {
            get { return _NombreCompleto; }
            set { _NombreCompleto = value; }
        }

        private string _Comentario;
        /// <summary>
        /// el comentario que nos envian para visualizar en l web
        /// </summary>
        public string Comentario
        {
            get { return _Comentario; }
            set { _Comentario = value; }
        }

        private string _Conexion;
        /// <summary>
        /// Es la acceso a la base de datos
        /// </summary>
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        private int _Resultado;
        /// <summary>
        /// Es para devolder un valor para la operacion realizada
        /// </summary>
        public int Resultado
        {
            get { return _Resultado; }
            set { _Resultado = value; }
        }
        private bool _Completado;
        /// <summary>
        /// Para verificar si la operacion termino 
        /// </summary>
        public bool Completado
        {
            get { return _Completado; }
            set { _Completado = value; }
        }
        private string _IdUsuario;
        /// <summary>
        /// El usuario es Web
        /// </summary>
        public string IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

    }
}
