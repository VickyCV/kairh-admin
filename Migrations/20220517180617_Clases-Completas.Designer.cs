﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kairh_admin.Models;

namespace kairh_admin.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220517180617_Clases-Completas")]
    partial class ClasesCompletas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("kairh_admin.Models.cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("callePred")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudadPred")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("coloniaPred")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cpPred")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoPred")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("keyFirebase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("latPred")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lonPred")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("municipioPred")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noExtPred")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noIntPred")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("kairh_admin.Models.negocio", b =>
                {
                    b.Property<int>("idNegocio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Estatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("calificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("calle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("colonia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("domingoFin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("domingoInicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("domingock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estrellas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("juevesFin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("juevesInicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("keyFirebase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("latitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("longitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lunesFin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lunesInicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lunesck")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("martesFin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("martesInicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("martesck")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("miercolesFin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("miercolesInicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("miercolesck")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreComercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numext")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profileImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("razonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rfc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sabadoFin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sabadoInicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sabadock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("viajes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("viernesFin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("viernesInicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("viernesck")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idNegocio");

                    b.ToTable("Negocios");
                });

            modelBuilder.Entity("kairh_admin.Models.pedido", b =>
                {
                    b.Property<int>("idPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaentregado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecharecibido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("flagRecolecta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("flagprop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("folio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horaentregado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horarecibido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idCliente")
                        .HasColumnType("int");

                    b.Property<int>("idNegocio")
                        .HasColumnType("int");

                    b.Property<int>("idRepartidor")
                        .HasColumnType("int");

                    b.Property<string>("idcliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idnegocio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idrepartidor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("keyFirebase")
                        .HasColumnType("int");

                    b.Property<string>("latentrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lonentrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("metodopago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("montoEnvio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("nombreNegocio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombrerepartidor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("oClienteidCliente")
                        .HasColumnType("int");

                    b.Property<int?>("oNegocioidNegocio")
                        .HasColumnType("int");

                    b.Property<int?>("oRepartidoridRepartidor")
                        .HasColumnType("int");

                    b.Property<string>("propina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subtotal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tarifa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telrepartidor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("total")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlnegocio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPedido");

                    b.HasIndex("oClienteidCliente");

                    b.HasIndex("oNegocioidNegocio");

                    b.HasIndex("oRepartidoridRepartidor");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("kairh_admin.Models.pedido_detalle", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("cantidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("complementos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("costosAdicionales")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("flagcomplementos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("flagoptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("folioPedido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idDetalle")
                        .HasColumnType("int");

                    b.Property<int>("idPedido")
                        .HasColumnType("int");

                    b.Property<string>("nombreProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("oPedidoidPedido")
                        .HasColumnType("int");

                    b.Property<string>("observacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("option")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("precioUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlProd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("oPedidoidPedido");

                    b.ToTable("PedidosDetalle");
                });

            modelBuilder.Entity("kairh_admin.Models.repartidor", b =>
                {
                    b.Property<int>("idRepartidor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("keyFirebase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idRepartidor");

                    b.ToTable("Repartidores");
                });

            modelBuilder.Entity("kairh_admin.Models.pedido", b =>
                {
                    b.HasOne("kairh_admin.Models.cliente", "oCliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("oClienteidCliente");

                    b.HasOne("kairh_admin.Models.negocio", "oNegocio")
                        .WithMany("Pedidos")
                        .HasForeignKey("oNegocioidNegocio");

                    b.HasOne("kairh_admin.Models.repartidor", "oRepartidor")
                        .WithMany("Pedidos")
                        .HasForeignKey("oRepartidoridRepartidor");

                    b.Navigation("oCliente");

                    b.Navigation("oNegocio");

                    b.Navigation("oRepartidor");
                });

            modelBuilder.Entity("kairh_admin.Models.pedido_detalle", b =>
                {
                    b.HasOne("kairh_admin.Models.pedido", "oPedido")
                        .WithMany("Detalle")
                        .HasForeignKey("oPedidoidPedido");

                    b.Navigation("oPedido");
                });

            modelBuilder.Entity("kairh_admin.Models.cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("kairh_admin.Models.negocio", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("kairh_admin.Models.pedido", b =>
                {
                    b.Navigation("Detalle");
                });

            modelBuilder.Entity("kairh_admin.Models.repartidor", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
