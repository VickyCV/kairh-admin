using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kairh_admin.Models.firebase
{
    public class firebaseNegocio : MyFbContext
    {
        public dynamic list()
        {
            FirebaseResponse response = client.Get("Users");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            return data;
        }
        public negocio details(string _idnegocio, int _id)
        {
            FirebaseResponse response = client.Get("Users/" + _idnegocio);
            modelNegocio model = JsonConvert.DeserializeObject<modelNegocio>(response.Body);
            // Modelo real
            var m = new negocio
            {
                id = _id,
                idnegocio = _idnegocio,
                Estatus = model.Estatus,
                calificacion = model.calificacion,
                calle = model.calle,
                ciudad = model.ciudad,
                colonia = model.colonia,
                cp = model.cp,
                descripcion = model.descripcion,
                domingoFin = model.domingoFin,
                domingoInicio = model.domingoInicio,
                domingock = model.domingock,
                email = model.email,
                especialidad = model.especialidad,
                estado = model.estado,
                estrellas = model.estrellas,
                juevesFin = model.juevesFin,
                juevesInicio = model.juevesInicio,
                latitud = model.latitud,
                longitud = model.longitud,
                lunesFin = model.lunesFin,
                lunesInicio = model.lunesInicio,
                lunesck = model.lunesck,
                martesFin = model.martesFin,
                martesInicio = model.martesInicio,
                martesck = model.martesck,
                miercolesFin = model.miercolesFin,
                miercolesInicio = model.miercolesInicio,
                miercolesck = model.miercolesck,
                municipio = model.municipio,
                nombreComercial = model.nombreComercial,
                numext = model.numext,
                numint = model.numint,
                profileImage = model.profileImage,
                razonSocial = model.razonSocial,
                rfc = model.rfc,
                sabadoFin = model.sabadoFin,
                sabadoInicio = model.sabadoInicio,
                sabadock = model.sabadock,
                telefono = model.telefono,
                tipo = model.tipo,
                viajes = model.viajes,
                viernesFin = model.viernesFin,
                viernesInicio = model.viernesInicio,
                viernesck = model.viernesck
            };
            return m;
        }
        public void update(string idnegocio, string estatus)
        {
            var model = new campo { Estatus = estatus };
            FirebaseResponse response = client.Update("Users/" + idnegocio + "/", model);
        }


        internal class campo
        {
            public string Estatus { get; set; }
        }
    }
}
