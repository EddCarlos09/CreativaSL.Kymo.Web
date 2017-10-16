using CreativaSL.Dll.Kymo.Global;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;

namespace CreativaSL.WebForms.Kymo.Web
{
    public class CustomIdentity : IIdentity
    {
        private FormsAuthenticationTicket _ticket;
        private DatosUserJson _DatosUsuario;
        public CustomIdentity(FormsAuthenticationTicket ticket)
        {
            _ticket = ticket;
            JObject resut = (JObject)JsonConvert.DeserializeObject(_ticket.UserData);
            JsonSerializer serializer = new JsonSerializer();
            _DatosUsuario = (DatosUserJson)serializer.Deserialize(new JTokenReader(resut), typeof(DatosUserJson));

        }

        public string AuthenticationType
        {
            get
            {
                return "Custom";
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return true; 
            }
        }

        public string Name
        {
            get
            {
                return _ticket.Name;
            }
        }

        public FormsAuthenticationTicket Ticket
        {
            get { return _ticket; }
        }
        
        public DatosUserJson DatosUsuario
        {
            get { return _DatosUsuario; }
        }

    }
}