using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    public class RR_Pedido
    {

        public RR_Pedido()
        {
            _VentaDetalle = new CH_VentaDetalle();
            _ListaVentaDetalle = new List<CH_VentaDetalle>();
            _Cliente = new CH_Cliente();
        }

        private CH_VentaDetalle _VentaDetalle;
        public CH_VentaDetalle VentaDetalle
        {
            get { return _VentaDetalle; }
            set { _VentaDetalle = value; }
        }

        private CH_Cliente _Cliente;
        public CH_Cliente Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }

        private string _IdFolio;
        public string IdFolio
        {
            get { return _IdFolio; }
            set { _IdFolio = value; }
        }
        
        private List<CH_VentaDetalle> _ListaVentaDetalle;
        public List<CH_VentaDetalle> ListaVentaDetalle
        {
            get { return _ListaVentaDetalle; }
            set { _ListaVentaDetalle = value; }
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
