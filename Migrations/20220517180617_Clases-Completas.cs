using Microsoft.EntityFrameworkCore.Migrations;

namespace kairh_admin.Migrations
{
    public partial class ClasesCompletas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idFirebase",
                table: "Repartidores",
                newName: "keyFirebase");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Repartidores",
                newName: "idRepartidor");

            migrationBuilder.RenameColumn(
                name: "idFirebase",
                table: "Negocios",
                newName: "keyFirebase");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Negocios",
                newName: "idNegocio");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    keyFirebase = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Clientes", x => x.idCliente);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    idPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    keyFirebase = table.Column<int>(type: "int", nullable: false),
                    idNegocio = table.Column<int>(type: "int", nullable: false),
                    oNegocioidNegocio = table.Column<int>(type: "int", nullable: true),
                    idRepartidor = table.Column<int>(type: "int", nullable: false),
                    oRepartidoridRepartidor = table.Column<int>(type: "int", nullable: true),
                    idCliente = table.Column<int>(type: "int", nullable: false),
                    oClienteidCliente = table.Column<int>(type: "int", nullable: true),
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
                    idnegocio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idrepartidor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latentrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lonentrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    metodopago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    montoEnvio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    table.PrimaryKey("PK_Pedidos", x => x.idPedido);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_oClienteidCliente",
                        column: x => x.oClienteidCliente,
                        principalTable: "Clientes",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Negocios_oNegocioidNegocio",
                        column: x => x.oNegocioidNegocio,
                        principalTable: "Negocios",
                        principalColumn: "idNegocio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Repartidores_oRepartidoridRepartidor",
                        column: x => x.oRepartidoridRepartidor,
                        principalTable: "Repartidores",
                        principalColumn: "idRepartidor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PedidosDetalle",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idPedido = table.Column<int>(type: "int", nullable: false),
                    idDetalle = table.Column<int>(type: "int", nullable: false),
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
                    oPedidoidPedido = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosDetalle", x => x.id);
                    table.ForeignKey(
                        name: "FK_PedidosDetalle_Pedidos_oPedidoidPedido",
                        column: x => x.oPedidoidPedido,
                        principalTable: "Pedidos",
                        principalColumn: "idPedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_oClienteidCliente",
                table: "Pedidos",
                column: "oClienteidCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_oNegocioidNegocio",
                table: "Pedidos",
                column: "oNegocioidNegocio");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_oRepartidoridRepartidor",
                table: "Pedidos",
                column: "oRepartidoridRepartidor");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDetalle_oPedidoidPedido",
                table: "PedidosDetalle",
                column: "oPedidoidPedido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidosDetalle");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.RenameColumn(
                name: "keyFirebase",
                table: "Repartidores",
                newName: "idFirebase");

            migrationBuilder.RenameColumn(
                name: "idRepartidor",
                table: "Repartidores",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "keyFirebase",
                table: "Negocios",
                newName: "idFirebase");

            migrationBuilder.RenameColumn(
                name: "idNegocio",
                table: "Negocios",
                newName: "id");
        }
    }
}
