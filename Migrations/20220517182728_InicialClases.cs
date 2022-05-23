using Microsoft.EntityFrameworkCore.Migrations;

namespace kairh_admin.Migrations
{
    public partial class InicialClases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idcliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    callePred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudadPred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coloniaPred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cpPred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estadoPred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latPred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lonPred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    municipioPred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noExtPred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noIntPred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Negocios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idnegocio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    calificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    calle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    colonia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    domingoFin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    domingoInicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    domingock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estrellas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    juevesFin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    juevesInicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    longitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lunesFin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lunesInicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lunesck = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    martesFin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    martesInicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    martesck = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    miercolesFin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    miercolesInicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    miercolesck = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombreComercial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numext = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    profileImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    razonSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rfc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sabadoFin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sabadoInicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sabadock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    viajes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    viernesFin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    viernesInicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    viernesck = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Negocios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Repartidores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idrepartidor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repartidores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idpedido = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaentregado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecharecibido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flagRecolecta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flagprop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    folio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    horaentregado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    horarecibido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idcliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    oClienteid = table.Column<int>(type: "int", nullable: true),
                    idnegocio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    oNegocioid = table.Column<int>(type: "int", nullable: true),
                    idrepartidor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    oRepartidorid = table.Column<int>(type: "int", nullable: true),
                    latentrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lonentrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    metodopago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    montoEnvio = table.Column<double>(type: "float", nullable: false),
                    nombreNegocio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombrerepartidor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    propina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subtotal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tarifa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telrepartidor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    total = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlnegocio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_oClienteid",
                        column: x => x.oClienteid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Negocios_oNegocioid",
                        column: x => x.oNegocioid,
                        principalTable: "Negocios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Repartidores_oRepartidorid",
                        column: x => x.oRepartidorid,
                        principalTable: "Repartidores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PedidosDetalle",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idpedido = table.Column<int>(type: "int", nullable: false),
                    iddetalle = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    complementos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    costosAdicionales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flagcomplementos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flagoptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    folioPedido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombreProd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    option = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precioUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urlProd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pedidoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosDetalle", x => x.id);
                    table.ForeignKey(
                        name: "FK_PedidosDetalle_Pedidos_pedidoid",
                        column: x => x.pedidoid,
                        principalTable: "Pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_oClienteid",
                table: "Pedidos",
                column: "oClienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_oNegocioid",
                table: "Pedidos",
                column: "oNegocioid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_oRepartidorid",
                table: "Pedidos",
                column: "oRepartidorid");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDetalle_pedidoid",
                table: "PedidosDetalle",
                column: "pedidoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidosDetalle");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Negocios");

            migrationBuilder.DropTable(
                name: "Repartidores");
        }
    }
}
