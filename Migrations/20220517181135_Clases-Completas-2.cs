using Microsoft.EntityFrameworkCore.Migrations;

namespace kairh_admin.Migrations
{
    public partial class ClasesCompletas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_clienteidCliente",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Negocios_negocioidNegocio",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Repartidores_repartidoridRepartidor",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidosDetalle_Pedidos_pedidoidPedido",
                table: "PedidosDetalle");

            migrationBuilder.DropIndex(
                name: "IX_PedidosDetalle_pedidoidPedido",
                table: "PedidosDetalle");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_clienteidCliente",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_negocioidNegocio",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_repartidoridRepartidor",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "pedidoidPedido",
                table: "PedidosDetalle");

            migrationBuilder.DropColumn(
                name: "clienteidCliente",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "negocioidNegocio",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "repartidoridRepartidor",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "idRepartidor",
                table: "Repartidores",
                newName: "repartidorId");

            migrationBuilder.RenameColumn(
                name: "idPedido",
                table: "PedidosDetalle",
                newName: "pedidoId");

            migrationBuilder.RenameColumn(
                name: "idDetalle",
                table: "PedidosDetalle",
                newName: "detalleId");

            migrationBuilder.RenameColumn(
                name: "idRepartidor",
                table: "Pedidos",
                newName: "repartidorId");

            migrationBuilder.RenameColumn(
                name: "idNegocio",
                table: "Pedidos",
                newName: "negocioId");

            migrationBuilder.RenameColumn(
                name: "idCliente",
                table: "Pedidos",
                newName: "clienteId");

            migrationBuilder.RenameColumn(
                name: "idPedido",
                table: "Pedidos",
                newName: "pedidoId");

            migrationBuilder.RenameColumn(
                name: "idNegocio",
                table: "Negocios",
                newName: "negocioId");

            migrationBuilder.RenameColumn(
                name: "idCliente",
                table: "Clientes",
                newName: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDetalle_pedidoId",
                table: "PedidosDetalle",
                column: "pedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_clienteId",
                table: "Pedidos",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_negocioId",
                table: "Pedidos",
                column: "negocioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_repartidorId",
                table: "Pedidos",
                column: "repartidorId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_PedidosDetalle_pedidoId",
                table: "PedidosDetalle");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_clienteId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_negocioId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_repartidorId",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "repartidorId",
                table: "Repartidores",
                newName: "idRepartidor");

            migrationBuilder.RenameColumn(
                name: "pedidoId",
                table: "PedidosDetalle",
                newName: "idPedido");

            migrationBuilder.RenameColumn(
                name: "detalleId",
                table: "PedidosDetalle",
                newName: "idDetalle");

            migrationBuilder.RenameColumn(
                name: "repartidorId",
                table: "Pedidos",
                newName: "idRepartidor");

            migrationBuilder.RenameColumn(
                name: "negocioId",
                table: "Pedidos",
                newName: "idNegocio");

            migrationBuilder.RenameColumn(
                name: "clienteId",
                table: "Pedidos",
                newName: "idCliente");

            migrationBuilder.RenameColumn(
                name: "pedidoId",
                table: "Pedidos",
                newName: "idPedido");

            migrationBuilder.RenameColumn(
                name: "negocioId",
                table: "Negocios",
                newName: "idNegocio");

            migrationBuilder.RenameColumn(
                name: "clienteId",
                table: "Clientes",
                newName: "idCliente");

            migrationBuilder.AddColumn<int>(
                name: "pedidoidPedido",
                table: "PedidosDetalle",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "clienteidCliente",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "negocioidNegocio",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "repartidoridRepartidor",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDetalle_pedidoidPedido",
                table: "PedidosDetalle",
                column: "pedidoidPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_clienteidCliente",
                table: "Pedidos",
                column: "clienteidCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_negocioidNegocio",
                table: "Pedidos",
                column: "negocioidNegocio");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_repartidoridRepartidor",
                table: "Pedidos",
                column: "repartidoridRepartidor");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_clienteidCliente",
                table: "Pedidos",
                column: "clienteidCliente",
                principalTable: "Clientes",
                principalColumn: "idCliente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Negocios_negocioidNegocio",
                table: "Pedidos",
                column: "negocioidNegocio",
                principalTable: "Negocios",
                principalColumn: "idNegocio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Repartidores_repartidoridRepartidor",
                table: "Pedidos",
                column: "repartidoridRepartidor",
                principalTable: "Repartidores",
                principalColumn: "idRepartidor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosDetalle_Pedidos_pedidoidPedido",
                table: "PedidosDetalle",
                column: "pedidoidPedido",
                principalTable: "Pedidos",
                principalColumn: "idPedido",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
