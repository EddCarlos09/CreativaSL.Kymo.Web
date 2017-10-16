using CreativaSL.Dll.Kymo.Global;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace CreativaSL.WebForms.Kymo.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["strConnection"];
            Comun.Conexion = settings.ConnectionString;
            RegisterCustomRoutes(RouteTable.Routes);
        }

        void RegisterCustomRoutes(RouteCollection routes)
        {

            //routes.MapPageRoute("",
            //    "Login/{ReturnUrl}",
            //    "~/Login.aspx");

            routes.MapPageRoute("",
                "Login/{*ReturnUrl}",
                "~/Login.aspx");

            //routes.MapPageRoute("",
            //    "Test",
            //    "~/frmTest.aspx");

            routes.MapPageRoute("",
                "ErrorPage",
                "~/frmErrorPage.aspx");

            //routes.MapPageRoute("",
            //    "Prueba/{op}/{id}",
            //    "~/frmTestUrl.aspx");

            //routes.MapPageRoute("",
            //    "SalesReportSummary/{year}",
            //    "~/sales.aspx");
            //routes.MapPageRoute("SalesRoute",
            //    "SalesReport/{locale}/{year}",
            //    "~/sales.aspx");
            //routes.MapPageRoute("ExpensesRoute",
            //    "ExpenseReport/{locale}/{year}/{*extrainfo}",
            //    "~/expenses.aspx", true,
            //    new RouteValueDictionary {
            //        { "locale", "US" },
            //        { "year", DateTime.Now.Year.ToString() } },
            //    new RouteValueDictionary {
            //        { "locale", "[a-z]{2}" },
            //        { "year", @"\d{4}" } });
        }

        void Application_OnPostAuthenticateRequest(object sender, EventArgs e)
        {
            // Get a reference to the current User
            IPrincipal usr = HttpContext.Current.User;
            // If we are dealing with an authenticated forms authentication request
            if (usr.Identity.IsAuthenticated && usr.Identity.AuthenticationType == "Forms")
            {
                FormsIdentity fIdent = usr.Identity as FormsIdentity;
                // Create a CustomIdentity based on the FormsAuthenticationTicket  
                CustomIdentity ci = new CustomIdentity(fIdent.Ticket);
                // Create the CustomPrincipal
                CustomPrincipal p = new CustomPrincipal(ci);
                // Attach the CustomPrincipal to HttpContext.User and Thread.CurrentPrincipal
                HttpContext.Current.User = p;
                Thread.CurrentPrincipal = p;
            }
        }
    }
}