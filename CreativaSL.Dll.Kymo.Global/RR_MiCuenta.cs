using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public class RR_MiCuenta
    {
        public RR_MiCuenta()
        {
            _Cliente = new CH_Cliente();
            _ListaCliente = new List<CH_Cliente>();
        }

        private CH_Cliente _Cliente;
        public CH_Cliente Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }

        private List<CH_Cliente> _ListaCliente;
        public List<CH_Cliente> ListaCliente
        {
            get { return _ListaCliente; }
            set { _ListaCliente = value; }
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
