using CreativaSL.Dll.Kymo.Datos;
using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.Kymo.Negocio
{
    /// <summary>
    /// Define las reglas de negocio para Faqs
    /// </summary>
    public class CH_FAQNegocio
    {
        /// <summary>
        /// Retorna datos para dibujado de la página de preguntas frecuentes
        /// </summary>
        /// <param name="_datos">Objeto con datos de conexión y parámetros </param>        
        public CH_FAQ ObtenerDatosPagFaqs(CH_FAQ _datos)
        {
            try
            {
                CH_FaqDatos faqDatos = new CH_FaqDatos();
                return faqDatos.ObtenerDatosPagFaqs(_datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
