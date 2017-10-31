using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public class RR_Valoraciones
    {
        public RR_Valoraciones()
        {
            ListaProducto = new CH_Producto();
            
        }

        private string _IdValoracion;
        public string IdValoracion
        {
            get { return _IdValoracion; }
            set { _IdValoracion = value; }
        }


        private CH_Producto _ListaProducto;
        public CH_Producto ListaProducto
        {
            get { return _ListaProducto; }
            set { _ListaProducto = value; }
        }

        private bool _NuevaValoracion;
        public bool NuevaValoracion
        {
            get { return _NuevaValoracion; }
            set { _NuevaValoracion = value; }
        }

        private int _Valoracion;
        public int Valoracion
        {
            get { return _Valoracion; }
            set { _Valoracion = value; }
        }

        private string _IdCliente;
        public string IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
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
