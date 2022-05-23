using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kairh_admin.Models
{
    public class MyFbContext
    {
        private IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "IKZThnvf7convaBaiOty6Dg5bN5ltsYRS7dLf83E",
            BasePath = "https://pruebas-18649.firebaseio.com/"

        };
        public FirebaseClient client;

        public MyFbContext()
        {
            client = new FirebaseClient(config);
        }

        public class modelRepartidor
        {
            public string clave { get; set; }
            public string correo { get; set; }
            public string estatus { get; set; }
            public string nombre { get; set; }
            public string telefono { get; set; }
        }

        public class modelNegocio
        {
            public string Estatus { get; set; }
            public string calificacion { get; set; }
            public string calle { get; set; }
            public string ciudad { get; set; }
            public string colonia { get; set; }
            public string cp { get; set; }
            public string descripcion { get; set; }
            public string domingoFin { get; set; }
            public string domingoInicio { get; set; }
            public string domingock { get; set; }
            public string email { get; set; }
            public string especialidad { get; set; }
            public string estado { get; set; }
            public string estrellas { get; set; }
            public string juevesFin { get; set; }
            public string juevesInicio { get; set; }
            public string latitud { get; set; }
            public string longitud { get; set; }
            public string lunesFin { get; set; }
            public string lunesInicio { get; set; }
            public string lunesck { get; set; }
            public string martesFin { get; set; }
            public string martesInicio { get; set; }
            public string martesck { get; set; }
            public string miercolesFin { get; set; }
            public string miercolesInicio { get; set; }
            public string miercolesck { get; set; }
            public string municipio { get; set; }
            public string nombreComercial { get; set; }
            public string numext { get; set; }
            public string numint { get; set; }
            public string profileImage { get; set; }
            public string razonSocial { get; set; }
            public string rfc { get; set; }
            public string sabadoFin { get; set; }
            public string sabadoInicio { get; set; }
            public string sabadock { get; set; }
            public string telefono { get; set; }
            public string tipo { get; set; }
            public string viajes { get; set; }
            public string viernesFin { get; set; }
            public string viernesInicio { get; set; }
            public string viernesck { get; set; }
        }
        public class modelCliente
        {
            public string apellidos { get; set; }
            public string callePred { get; set; }
            public string ciudadPred { get; set; }
            public string clave { get; set; }
            public string coloniaPred { get; set; }
            public string correo { get; set; }
            public string cpPred { get; set; }
            public string estadoPred { get; set; }
            public string latPred { get; set; }
            public string lonPred { get; set; }
            public string municipioPred { get; set; }
            public string noExtPred { get; set; }
            public string noIntPred { get; set; }
            public string nombres { get; set; }
            public string telefono { get; set; }
    }

        public class modelPedido
        {
            public string costoEnvio { get; set; }
            public string domentrega { get; set; }
            public string estatus { get; set; }

            public string fecha { get; set; }
            public string fechaentregado { get; set; }
            public string fecharecibido { get; set; }
            public string flagRecolecta { get; set; }
            public string flagprop { get; set; }
            public string folio { get; set; }
            public string hora { get; set; }
            public string horaentregado { get; set; }
            public string horarecibido { get; set; }
            public string idcliente { get; set; }
            public string idnegocio { get; set; }
            public string idrepartidor { get; set; }
            public string latentrega { get; set; }
            public string lonentrega { get; set; }
            public string metodopago { get; set; }
            public double montoEnvio { get; set; }
            public string nombreNegocio { get; set; }
            public string nombrerepartidor { get; set; }
            public string propina { get; set; }
            public string subtotal { get; set; }
            public string tarifa { get; set; }
            public string telrepartidor { get; set; }
            public string total { get; set; }
            public string urlnegocio { get; set; }
            public ICollection<modelPedido_detalle> Detalle { get; set; }
        }
        public class modelPedido_detalle
        {
            public string cantidad { get; set; }
            public string complementos { get; set; }
            public string costosAdicionales { get; set; }
            public string flagcomplementos { get; set; }
            public string flagoptions { get; set; }
            public string folioPedido { get; set; }
            public string id { get; set; }
            public string nombreProd { get; set; }
            public string observacion { get; set; }
            public string option { get; set; }
            public string precioUnit { get; set; }
            public string urlProd { get; set; }
        }
    }
}
