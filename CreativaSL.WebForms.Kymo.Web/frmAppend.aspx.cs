using CreativaSL.Dll.Kymo.Global;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.Web
{
    
    public partial class frmAppend : System.Web.UI.Page
    {
        DatosUser datos = new DatosUser();
        public List<DatosUser> Lista = new List<DatosUser>();
        public List<DatosUser> Dato = new List<DatosUser>();
        protected void Page_Load(object sender, EventArgs e)
        {
            EscribeJson();
            Lista = RegresaJson();
        }

        public void EscribeJson()
        {
            Lista.Add(new DatosUser() { Nombre = "Rafael Rosales1" });
            Lista.Add(new DatosUser() { Nombre = "Rafael Rosales2" });
            Lista.Add(new DatosUser() { Nombre = "Rafael Rosales3" });
            Lista.Add(new DatosUser() { Nombre = "Rafael Rosales4" });
            Lista.Add(new DatosUser() { Nombre = "Rafael Rosales5" });
            Lista.Add(new DatosUser() { Nombre = "Rafael Rosales6" });
            Lista.Add(new DatosUser() { Nombre = "Rafael Rosales7" });
            Lista.Add(new DatosUser() { Nombre = "Rafael Rosales8" });
            Lista.Add(new DatosUser() { Nombre = "Rafael Rosales9" });
            Lista.Add(new DatosUser() { Nombre = "Rafael Rosales10" });
            Lista.Add(new DatosUser() { Nombre = "Rafael Rosales11" });

            File.WriteAllText(@"c:\user.json", JsonConvert.SerializeObject(Lista));
            using (StreamWriter file = File.CreateText(@"c:\user.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, Lista);
            }
        }
        public List<DatosUser> RegresaJson()
        {
            Dato = JsonConvert.DeserializeObject<List<DatosUser>>(File.ReadAllText(@"c:\user.json"));

            using (StreamReader file = File.OpenText(@"c:\user.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<DatosUser> ListaJ = (List<DatosUser>)serializer.Deserialize(file, typeof(List<DatosUser>));
                return ListaJ;
            }
        }
    }
}