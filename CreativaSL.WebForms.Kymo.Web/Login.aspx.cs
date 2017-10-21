using CreativaSL.Dll.Kymo.Global;
using CreativaSL.Dll.Kymo.Negocio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Request.IsAuthenticated)
                    FormsAuthentication.SignOut();
            }
            if(Request.Form.Count > 0)
            {
                string usuario = Request.Form["email"];
                string password = Request.Form["password"];
                bool rememberMe = true;
                CH_Cliente dataCustomer = new CH_Cliente { Conexion = Comun.Conexion, Correo = usuario, Password = password};
                CH_ClienteNegocio custNeg = new CH_ClienteNegocio();
                CH_Cliente dataResult = custNeg.Login(dataCustomer);
                if(dataResult.Completado && dataResult.Resultado == 1)
                {
                    //string userDataString = string.Concat(companyName[i], "|", titleAtCompany[i]);
                    // Create the cookie that contains the forms authentication ticket
                    HttpCookie authCookie = FormsAuthentication.GetAuthCookie(dataResult.IdCliente, rememberMe);
                    // Get the FormsAuthenticationTicket out of the encrypted cookie
                    FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
                    // Create a new FormsAuthenticationTicket that includes our custom User Data
                    CH_ClienteJson data = dataResult.GetClienteJson();
                    string userDataString = JsonConvert.SerializeObject(data);
                    FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, ticket.IssueDate, ticket.Expiration, ticket.IsPersistent, userDataString);
                    // Update the authCookie's Value to use the encrypted version of newTicket
                    authCookie.Value = FormsAuthentication.Encrypt(newTicket);
                    // Manually add the authCookie to the Cookies collection
                    Response.Cookies.Add(authCookie);
                    // Determine redirect URL and send user there
                    //string redirUrl = FormsAuthentication.GetRedirectUrl(idUsuario, rememberMe);
                    string redirUrl = Page.RouteData.Values["ReturnUrl"] != null ? Page.RouteData.Values["ReturnUrl"].ToString() : string.Empty;
                    if (string.IsNullOrEmpty(redirUrl))
                    {
                        redirUrl = FormsAuthentication.GetRedirectUrl(dataResult.IdCliente, rememberMe);
                        if(redirUrl == null)
                        {
                            redirUrl = "/Home";
                        }
                    }
                    else
                    {
                        redirUrl = "/" + redirUrl;
                    }
                    Response.Redirect(redirUrl, true);
                }
            }
        }

        /// <summary>
        /// Método para iniciar sesión a partir de un usuario y contraseña
        /// </summary>
        /// <param name="_user">Cuenta de usuario a validar</param>
        /// <param name="_password">Contraseña de la cuenta de usuario a validar</param>
        /// <returns></returns>
        private bool IsCorrectLogin(string _user, string _password)
        {
            try
            {
                if (_user.Equals("root") && _password.Equals("123456"))
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}