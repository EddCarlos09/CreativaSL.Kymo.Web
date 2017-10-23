using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición de clase para realizar búsqueda
    /// </summary>
    public class CH_Busqueda
    {
        /// <summary>
        /// Inicializa datos de la clase
        /// </summary>
        public CH_Busqueda()
        {
            _ListaProductosResultado = new List<CH_Producto>();
            _Talla = new CH_Talla();
            _Color = new CH_Color();
            _Familia = new CH_Familia();
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

        private bool _Hombre;
        /// <summary>
        /// Indica que la categoría a buscar es hombres
        /// </summary>
        public bool Hombre
        {
            get { return _Hombre; }
            set { _Hombre = value; }
        }

        private bool _Mujer;
        /// <summary>
        /// Indica que la categoría a buscar es mujeres
        /// </summary>
        public bool Mujer
        {
            get { return _Mujer; }
            set { _Mujer = value; }
        }

        private bool _Accesorio;
        /// <summary>
        /// Indica que la categoría a buscar es accesorios
        /// </summary>
        public bool Accesorio
        {
            get { return _Accesorio; }
            set { _Accesorio = value; }
        }

        private bool _BandFamilia;
        /// <summary>
        /// Indica que se buscará por familia de producto
        /// </summary>
        public bool BandFamilia
        {
            get { return _BandFamilia; }
            set { _BandFamilia = value; }
        }

        private CH_Familia _Familia;
        /// <summary>
        /// Datos de la familia de producto a buscar
        /// </summary>
        public CH_Familia Familia
        {
            get { return _Familia; }
            set { _Familia = value; }
        }

        private bool _BandTalla;
        /// <summary>
        /// Indica si se buscará por talla
        /// </summary>
        public bool BandTalla
        {
            get { return _BandTalla; }
            set { _BandTalla = value; }
        }

        private CH_Talla _Talla;
        /// <summary>
        /// Datos de la talla a buscar
        /// </summary>
        public CH_Talla Talla
        {
            get { return _Talla; }
            set { _Talla = value; }
        }

        private bool _BandColor;
        /// <summary>
        /// Indica si se buscará por color
        /// </summary>
        public bool BandColor
        {
            get { return _BandColor; }
            set { _BandColor = value; }
        }

        private CH_Color _Color;
        /// <summary>
        /// Datos del color a buscar
        /// </summary>
        public CH_Color Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        private bool _BandRangoPrecios;
        /// <summary>
        /// Indica si se buscará por rango de precios
        /// </summary>
        public bool BandRangoPrecios
        {
            get { return _BandRangoPrecios; }
            set { _BandRangoPrecios = value; }
        }

        private decimal _PrecioInicial;
        /// <summary>
        /// Precio inicial de búsqueda
        /// </summary>
        public decimal PrecioInicial
        {
            get { return _PrecioInicial; }
            set { _PrecioInicial = value; }
        }

        private decimal _PrecioFinal;
        /// <summary>
        /// Precio final de búsqueda
        /// </summary>
        public decimal PrecioFinal
        {
            get { return _PrecioFinal; }
            set { _PrecioFinal = value; }
        }

        private int _NumPagina;
        /// <summary>
        /// Número de página a buscar
        /// </summary>
        public int NumPagina
        {
            get { return _NumPagina; }
            set { _NumPagina = value; }
        }

        private int _MaxRows;
        /// <summary>
        /// Máxima cantidad de registros
        /// </summary>
        public int MaxRows
        {
            get { return _MaxRows; }
            set { _MaxRows = value; }
        }

        private int _TotalRegistros;
        /// <summary>
        /// Total de registros de la búsqueda
        /// </summary>
        public int TotalRegistros
        {
            get { return _TotalRegistros; }
            set { _TotalRegistros = value; }
        }

        private List<CH_Producto> _ListaProductosResultado;

        public List<CH_Producto> ListaProductosResultado
        {
            get { return _ListaProductosResultado; }
            set { _ListaProductosResultado = value; }
        }

    }
}
