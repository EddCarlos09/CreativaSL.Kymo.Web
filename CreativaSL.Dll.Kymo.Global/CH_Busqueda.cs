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
            _ListaTextos = new List<CH_Textos>();
            _ListaImagenes = new List<CH_Imagen>();
            _ListaFamilias = new List<CH_Familia>();
            _ListaTallas = new List<CH_Talla>();
            _ListaColor = new List<CH_Color>();
            _Talla = new CH_Talla();
            _Color = new CH_Color();
            _Familia = new CH_Familia();
            _ListaCantRegistros = new List<int>();
            _ListaCantRegistros.Add(10);
            _ListaCantRegistros.Add(15);
            _ListaCantRegistros.Add(20);
            _ListaCantRegistros.Add(25);
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

        private int _IdTipoBusqueda;
        /// <summary>
        /// Identificador del tipo de búsqueda principal para determinas submenús a mostrar
        /// </summary>
        public int IdTipoBusqueda
        {
            get { return _IdTipoBusqueda; }
            set { _IdTipoBusqueda = value; }
        }


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
        /// <summary>
        /// Productos como resultado de una búsqueda
        /// </summary>
        public List<CH_Producto> ListaProductosResultado
        {
            get { return _ListaProductosResultado; }
            set { _ListaProductosResultado = value; }
        }

        private List<CH_Familia> _ListaFamilias;
        /// <summary>
        /// Lista de familias de productos que forman parte del resultado de la búsqueda
        /// </summary>
        public List<CH_Familia> ListaFamilias
        {
            get { return _ListaFamilias; }
            set { _ListaFamilias = value; }
        }

        private List<CH_Talla> _ListaTallas;
        /// <summary>
        /// Lista de tallas que forman parte del resultado de la búsqueda
        /// </summary>
        public List<CH_Talla> ListaTallas 
        {
            get { return _ListaTallas; }
            set { _ListaTallas = value; }
        }

        private List<CH_Color> _ListaColor;
        /// <summary>
        /// Lista de colores que forman parte del resultado de la búsqueda
        /// </summary>
        public List<CH_Color> ListaColor
        {
            get { return _ListaColor; }
            set { _ListaColor = value; }
        }

        private int _TotalPaginas;
        /// <summary>
        /// Total de páginas como resultado de la búsqueda
        /// </summary>
        public int TotalPaginas
        {
            get { return _TotalPaginas; }
            set { _TotalPaginas = value; }
        }

        private int _TipoOrden;
        /// <summary>
        /// Identificador del ordenamiento a utilizar en la búsqueda
        /// </summary>
        public int TipoOrden
        {
            get { return _TipoOrden; }
            set { _TipoOrden = value; }
        }

        private int _RegistroInicial;

        public int RegistroInicial
        {
            get { return _RegistroInicial; }
            set { _RegistroInicial = value; }
        }

        private int _RegistroFinal;

        public int RegistroFinal
        {
            get { return _RegistroFinal; }
            set { _RegistroFinal = value; }
        }

        private List<int> _ListaCantRegistros;
        /// <summary>
        /// Lista con la cantidad de registros que se pueden obtener en una búsqueda
        /// </summary>
        public List<int> ListaCantidadRegistros
        {
            get { return _ListaCantRegistros; }
            set { _ListaCantRegistros = value; }
        }

        private decimal _MaxPrice;
        /// <summary>
        /// Precio máximo como resultado de búsqueda
        /// </summary>
        public decimal MaxPrice
        {
            get { return _MaxPrice; }
            set { _MaxPrice = value; }
        }

        private decimal _MinPrice;
        /// <summary>
        /// Precio mínimo como resultado de búsqueda
        /// </summary>
        public decimal MinPrice
        {
            get { return _MinPrice; }
            set { _MinPrice = value; }
        }

    }
}
