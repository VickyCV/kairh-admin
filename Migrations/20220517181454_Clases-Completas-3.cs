using Microsoft.EntityFrameworkCore.Migrations;

namespace kairh_admin.Migrations
{
    public partial class ClasesCompletas3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_clienteId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Negocios_negocioId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Repartidores_repartidorId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidosDetalle_Pedidos_pedidoId",
                table: "PedidosDetalle");

            migrationBuilder.RenameColumn(
                name: "keyFirebase",
                table: "Repartidores",
                newName: "idrepartidor");

            migrationBuilder.RenameColumn(
                name: "repartidorId",
                table: "Repartidores",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "pedidoId",
                table: "PedidosDetalle",
                newName: "pedidoid");

            migrationBuilder.RenameColumn(
                name: "detalleId",
                table: "PedidosDetalle",
                newName: "idpedido");

            migrationBuilder.RenameIndex(
                name: "IX_PedidosDetalle_pedidoId",
                table: "PedidosDetalle",
                newName: "IX_PedidosDetalle_pedidoid");

            migrationBuilder.RenameColumn(
                name: "repartidorId",
                table: "Pedidos",
                newName: "repartidorid");

            migrationBuilder.RenameColumn(
                name: "negocioId",
                table: "Pedidos",
                newName: "negocioid");

            migrationBuilder.RenameColumn(
                name: "keyFirebase",
                table: "Pedidos",
                newName: "idpedido");

            migrationBuilder.RenameColumn(
                name: "pedidoId",
                table: "Pedidos",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_repartidorId",
                table: "Pedidos",
                newName: "IX_Pedidos_repartidorid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_negocioId",
                table: "Pedidos",
                newName: "IX_Pedidos_negocioid");

            migrationBuilder.RenameColumn(
                name: "keyFirebase",
                table: "Negocios",
                newName: "idnegocio");

            migrationBuilder.RenameColumn(
                name: "negocioId",
                table: "Negocios",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "keyFirebase",
                table: "Clientes",
                newName: "idcliente");

            migrationBuilder.AlterColumn<int>(
                name: "pedidoid",
                table: "PedidosDetalle",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "iddetalle",
                table: "PedidosDetalle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "repartidorid",
                table: "Pedidos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "negocioid",
                table: "Pedidos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "clienteId",
                table: "Pedidos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_clienteId",
                table: "Pedidos",
                column: "clienteId",
                principalTable: "Clientes",
                principalColumn: "clienteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Negocios_negocioid",
                table: "Pedidos",
                column: "negocioid",
                principalTable: "Negocios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Repartidores_repartidorid",
                table: "Pedidos",
                column: "repartidorid",
                principalTable: "Repartidores",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosDetalle_Pedidos_pedidoid",
                table: "PedidosDetalle",
                column: "pedidoid",
                principalTable: "Pedidos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_clienteId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Negocios_negocioid",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Repartidores_repartidorid",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidosDetalle_Pedidos_pedidoid",
                table: "PedidosDetalle");

            migrationBuilder.DropColumn(
                name: "iddetalle",
                table: "PedidosDetalle");

            migrationBuilder.RenameColumn(
                name: "idrepartidor",
                table: "Repartidores",
                newName: "keyFirebase");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Repartidores",
                newName: "repartidorId");

            migrationBuilder.RenameColumn(
                name: "pedidoid",
                table: "PedidosDetalle",
                newName: "pedidoId");

            migrationBuilder.RenameColumn(
                name: "idpedido",
                table: "PedidosDetalle",
                newName: "detalleId");

            migrationBuilder.RenameIndex(
                name: "IX_PedidosDetalle_pedidoid",
                table: "PedidosDetalle",
                newName: "IX_PedidosDetalle_pedidoId");

            migrationBuilder.RenameColumn(
                name: "repartidorid",
                table: "Pedidos",
                newName: "repartidorId");

            migrationBuilder.RenameColumn(
                name: "negocioid",
                table: "Pedidos",
                newName: "negocioId");

            migrationBuilder.RenameColumn(
                name: "idpedido",
                table: "Pedidos",
                newName: "keyFirebase");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Pedidos",
                newName: "pedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_repartidorid",
                table: "Pedidos",
                newName: "IX_Pedidos_repartidorId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_negocioid",
                table: "Pedidos",
                newName: "IX_Pedidos_negocioId");

            migrationBuilder.RenameColumn(
                name: "idnegocio",
                table: "Negocios",
                newName: "keyFirebase");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Negocios",
                newName: "negocioId");

            migrationBuilder.RenameColumn(
                name: "idcliente",
                table: "Clientes",
                newName: "keyFirebase");

            migrationBuilder.AlterColumn<int>(
                name: "pedidoId",
                table: "PedidosDetalle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "repartidorId",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "negocioId",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "clienteId",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_clienteId",
                table: "Pedidos",
                column: "clienteId",
                principalTable: "Clientes",
                principalColumn: "clienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Negocios_negocioId",
                table: "Pedidos",
                column: "negocioId",
                principalTable: "Negocios",
                principalColumn: "negocioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Repartidores_repartidorId",
                table: "Pedidos",
                column: "repartidorId",
                principalTable: "Repartidores",
                principalColumn: "repartidorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosDetalle_Pedidos_pedidoId",
                table: "PedidosDetalle",
                column: "pedidoId",
                principalTable: "Pedidos",
                principalColumn: "pedidoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
