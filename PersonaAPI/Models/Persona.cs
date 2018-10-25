
using System;

namespace Models{
    public class Persona{
        public string nombre {get; set;}
        public string ci {get; set;}
        public string telefono {get; set;}

        public override string ToString(){        
        //String json = "";
        string json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
        return json;
    }
    }
}