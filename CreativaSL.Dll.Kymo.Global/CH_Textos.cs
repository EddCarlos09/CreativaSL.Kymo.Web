using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Global
{
    /// <summary>
    /// Definición de textos de las páginas WEB
    /// </summary>
    public class CH_Textos
    {
        private string _Texto;
        /// <summary>
        /// Texto a desplegar
        /// </summary>
        public string Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }

        private int _NumPosition;
        /// <summary>
        /// Posición que ocupa el texto dentro de la página
        /// </summary>
        public int NumPosition
        {
            get { return _NumPosition; }
            set { _NumPosition = value; }
        }

    }
}
