﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kairh_admin.Models;

namespace kairh_admin.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220517004520_negocios")]
    partial class negocios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("kairh_admin.Models.negocio", b =>
                {
                    b.Property<int>("id")
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

                    b.Property<string>("idFirebase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("juevesFin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("juevesInicio")
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

                    b.HasKey("id");

                    b.ToTable("Negocios");
                });

            modelBuilder.Entity("kairh_admin.Models.repartidor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idFirebase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Repartidores");
                });
#pragma warning restore 612, 618
        }
    }
}