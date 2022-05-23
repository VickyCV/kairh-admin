using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kairh_admin.Models.firebase
{
    // Clases modelo

    public class firebaseRepartidor : MyFbContext
    {
        public dynamic list()
        {
            FirebaseResponse response = client.Get("Repartidores");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            return data;
        }
        public repartidor details(string _idrepartidor, int _id)
        {
            FirebaseResponse response = client.Get("Repartidores/" + _idrepartidor);
            modelRepartidor model = JsonConvert.DeserializeObject<modelRepartidor>(response.Body);
            var m = new repartidor
            {
                id = _id,
                idrepartidor = _idrepartidor,
                clave = model.clave,
                correo = model.correo,
                estatus = model.estatus,
                nombre = model.nombre,
                telefono = model.telefono,
            };
            return m;
        }
        public void update(string idrepartidor, string estatus)
        {
            var model = new campo { estatus=estatus };
            FirebaseResponse response = client.Update("Repartidores/" + idrepartidor+"/", model);
        }


        internal class campo
        {
            public string estatus { get; set; }
        }
    }
}
