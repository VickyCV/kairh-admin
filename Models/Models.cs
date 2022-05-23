using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kairh_admin.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }

        public DbSet<repartidor> Repartidores { get; set; }
        public DbSet<negocio> Negocios { get; set; }
        public DbSet<cliente> Clientes { get; set; }
        public DbSet<pedido> Pedidos { get; set; }
        public DbSet<pedido_detalle> PedidosDetalle { get; set; }
    }

    public class repartidor
    {
        [Key]
        public int id { get; set; }
        public string idrepartidor { get; set; }
        [Display(Name = "CLAVE")]
        public string clave { get; set; }
        [Display(Name = "CORREO ELECTRÓNICO")]
        public string correo { get; set; }
        [Display(Name = "ESTATUS")]
        public string estatus { get; set; }
        [Display(Name = "NOMBRE")]
        public string nombre { get; set; }
        [Display(Name = "TELÉFONO")]
        public string telefono { get; set; }
        public ICollection<pedido> Pedidos { get; set; }
    }
   
    public class negocio
    {
        [Key]
        public int id { get; set; }
        public string idnegocio { get; set; }
        [Display(Name = "ESTATUS")]
        public string Estatus { get; set; }
        public string calificacion { get; set; }
        public string calle { get; set; }
        public string ciudad { get; set; }
        public string colonia { get; set; }
        public string cp { get; set; }
        [Display(Name = "DESCRIPCIÓN")]
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
        [Display(Name = "NOMBRE")]
        public string nombreComercial { get; set; }
        public string numext { get; set; }
        public string numint { get; set; }
        public string profileImage { get; set; }
        public string razonSocial { get; set; }
        public string rfc { get; set; }
        public string sabadoFin { get; set; }
        public string sabadoInicio { get; set; }
        public string sabadock { get; set; }
        [Display(Name = "TELÉFONO")]
        public string telefono { get; set; }
        public string tipo { get; set; }
        public string viajes { get; set; }
        public string viernesFin { get; set; }
        public string viernesInicio { get; set; }
        public string viernesck { get; set; }
        public ICollection<pedido> Pedidos { get; set; }
    }

    public class cliente
    {
        [Key]
        public int id { get; set; }
        public string idcliente { get; set; }

        public string apellidos { get; set; }
        public string callePred { get; set; }

        [Display(Name = "CIUDAD")]
        public string ciudadPred { get; set; }
        public string clave { get; set; }
        public string coloniaPred { get; set; }
        [Display(Name = "CORREO")]
        public string correo { get; set; }
        public string cpPred { get; set; }
        public string estadoPred { get; set; }
        public string latPred { get; set; }
        public string lonPred { get; set; }
        public string municipioPred { get; set; }
        public string noExtPred { get; set; }
        public string noIntPred { get; set; }
        [Display(Name = "NOMBRE")]
        public string nombres { get; set; }
        [Display(Name = "TELEFONO")]
        public string telefono { get; set; }
        public ICollection<pedido> Pedidos { get; set; }

    }
   
    public class pedido
    {
        [Key]
        public int id { get; set; }
        public int idpedido { get; set; }

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
        public cliente oCliente { get; set; }
        public string idnegocio { get; set; }
        public negocio oNegocio { get; set; }
        public string idrepartidor { get; set; }
        public repartidor oRepartidor { get; set; }
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
        public ICollection<pedido_detalle> Detalle { get; set; }
    }
    
    public class pedido_detalle
    {
        public int idpedido { get; set; }
        public int iddetalle { get; set; }
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
