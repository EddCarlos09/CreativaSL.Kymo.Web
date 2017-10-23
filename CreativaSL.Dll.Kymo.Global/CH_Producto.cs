using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición de entidad producto
    /// </summary>
    public class CH_Producto
    {
        /// <summary>
        /// Inicializa los datos de la clase
        /// </summary>
        public CH_Producto()
        {
            _ListaColores = new List<CH_Color>();
            _ListaTallas = new List<CH_Talla>();
            _ListaImagenes = new List<CH_Imagen>();
            _ListaImagenesThumb = new List<CH_Imagen>();
            _Talla = new CH_Talla();
            _Color = new CH_Color();
            _FamiliaProducto = new CH_Familia();
            _ImagenPrincipal = new CH_Imagen();
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


        private string _IdProducto;
        /// <summary>
        /// Identificador de entidad Producto
        /// </summary>
        public string IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }

        private string _NombreProducto;
        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string NombreProducto
        {
            get { return _NombreProducto; }
            set { _NombreProducto = value; }
        }

        private string _Descripcion;
        /// <summary>
        /// Descripción del producto
        /// </summary>
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }


        private decimal _MinPrecio;
        /// <summary>
        /// Precio menor de las combinaciones posibles
        /// </summary>
        public decimal MinPrecio
        {
            get { return _MinPrecio; }
            set { _MinPrecio = value; }
        }

        private decimal _MinPrecioMayoreo;
        /// <summary>
        /// Precio menor de mayoreo de las combinaciones posibles
        /// </summary>
        public decimal MinPrecioMayoreo
        {
            get { return _MinPrecioMayoreo; }
            set { _MinPrecioMayoreo = value; }
        }

        private decimal _Precio;
        /// <summary>
        /// Precio de producto 
        /// </summary>
        public decimal Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        private decimal _PrecioMayoreo;
        /// <summary>
        /// Precio de mayoreo del producto
        /// </summary>
        public decimal PrecioMayoreo
        {
            get { return _PrecioMayoreo; }
            set { _PrecioMayoreo = value; }
        }

        private decimal _Iva;
        /// <summary>
        /// Iva del producto
        /// </summary>
        public decimal Iva
        {
            get { return _Iva; }
            set { _Iva = value; }
        }

        private decimal _IvaMayoreo;
        /// <summary>
        /// Iva del producto para mayoreo
        /// </summary>
        public decimal IvaMayoreo
        {
            get { return _IvaMayoreo; }
            set { _IvaMayoreo = value; }
        }

        private CH_Talla _Talla;
        /// <summary>
        /// Objeto que contiene la talla seleccionada
        /// </summary>
        public CH_Talla Talla
        {
            get { return _Talla; }
            set { _Talla = value; }
        }

        private CH_Color _Color;
        /// <summary>
        /// Objeto que contiene el color seleccionado
        /// </summary>
        public CH_Color Color
        {
            get { return _Color; }
            set { _Color = value; }
        }



        private List<CH_Talla> _ListaTallas;
        /// <summary>
        /// Lista de tallas disponibles
        /// </summary>
        public List<CH_Talla> ListaTallas
        {
            get { return _ListaTallas; }
            set { _ListaTallas = value; }
        }


        private List<CH_Color> _ListaColores;
        /// <summary>
        /// Lista de colores disponibles
        /// </summary>
        public List<CH_Color> ListaColores
        {
            get { return _ListaColores; }
            set { _ListaColores = value; }
        }


        private CH_Familia _FamiliaProducto;
        /// <summary>
        /// Objeto que contiene la familia a la que pertenece el producto
        /// </summary>
        public CH_Familia FamiliaProducto
        {
            get { return _FamiliaProducto; }
            set { _FamiliaProducto = value; }
        }

        private int _Existencia;
        /// <summary>
        /// Existencia de productos
        /// </summary>
        public int Existencia
        {
            get { return _Existencia; }
            set { _Existencia = value; }
        }

        private int _ExistenciaApartado;
        /// <summary>
        /// Existencia de productos para apartados
        /// </summary>
        public int ExistenciaApartado
        {
            get { return _ExistenciaApartado; }
            set { _ExistenciaApartado = value; }
        }

        private bool _EsRopa;
        /// <summary>
        /// Indica si el producto es de tipo ropa
        /// </summary>
        public bool EsRopa
        {
            get { return _EsRopa; }
            set { _EsRopa = value; }
        }

        private string _Observaciones;
        /// <summary>
        /// Texto con información adicional de un producto
        /// </summary>
        public string Observaciones
        {
            get { return _Observaciones; }
            set { _Observaciones = value; }
        }

        private int _Valoracion;
        /// <summary>
        /// Valoración de los usuarios para los productos
        /// </summary>
        public int Valoracion
        {
            get { return _Valoracion; }
            set { _Valoracion = value; }
        }


        private List<CH_Imagen> _ListaImagenes;
        /// <summary>
        /// Lista de imágenes en tamaño normal
        /// </summary>
        public List<CH_Imagen> ListaImagenes
        {
            get { return _ListaImagenes; }
            set { _ListaImagenes = value; }
        }

        private List<CH_Imagen> _ListaImagenesThumb;
        /// <summary>
        /// Lista de imágenes en tamaño miniatura
        /// </summary>
        public List<CH_Imagen> ListaImagenesThumb
        {
            get { return _ListaImagenesThumb; }
            set { _ListaImagenesThumb = value; }
        }

        private List<CH_Producto> _ListaProductosRelacionados;
        /// <summary>
        /// Lista de productos relacionados. Se tomarán 4 productos al azar
        /// </summary>
        public List<CH_Producto> ListaProductosRelacionados
        {
            get { return _ListaProductosRelacionados; }
            set { _ListaProductosRelacionados = value; }
        }

        private CH_Imagen _ImagenPrincipal;
        /// <summary>
        /// Objeto que contiene datos de la imagen principal del producto
        /// </summary>
        public CH_Imagen ImagenPrincipal
        {
            get { return _ImagenPrincipal; }
            set { _ImagenPrincipal = value; }
        }


    }
}
