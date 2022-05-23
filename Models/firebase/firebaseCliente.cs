using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kairh_admin.Models.firebase
{
    public class firebaseCliente: MyFbContext
    {
        public dynamic list()
        {
            FirebaseResponse response = client.Get("Clients");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            return data;
        }
        public cliente details(string _idcliente, int _id)
        {
            FirebaseResponse response = client.Get("Clients/" + _idcliente);
            modelCliente model = JsonConvert.DeserializeObject<modelCliente>(response.Body);
            // Modelo real
            var m = new cliente
            {
                id = _id,
                idcliente = _idcliente,
                apellidos = model.apellidos,
                callePred = model.callePred,
                ciudadPred = model.ciudadPred,
                clave = model.clave,
                coloniaPred = model.coloniaPred,
                correo = model.correo,
                cpPred = model.cpPred,
                estadoPred = model.estadoPred,
                latPred = model.latPred,
                lonPred = model.lonPred,
                municipioPred = model.municipioPred,
                noExtPred = model.noExtPred,
                noIntPred = model.noIntPred,
                nombres = model.nombres,
                telefono = model.telefono,

            };
            return m;
        }
    }
}
