using Microsoft.EntityFrameworkCore.Migrations;

namespace kairh_admin.Migrations
{
    public partial class ClasesCompletas1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_oClienteidCliente",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Negocios_oNegocioidNegocio",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Repartidores_oRepartidoridRepartidor",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidosDetalle_Pedidos_oPedidoidPedido",
                table: "PedidosDetalle");

            migrationBuilder.RenameColumn(
                name: "oPedidoidPedido",
                table: "PedidosDetalle",
                newName: "pedidoidPedido");

            migrationBuilder.RenameIndex(
                name: "IX_PedidosDetalle_oPedidoidPedido",
                table: "PedidosDetalle",
                newName: "IX_PedidosDetalle_pedidoidPedido");

            migrationBuilder.RenameColumn(
                name: "oRepartidoridRepartidor",
                table: "Pedidos",
                newName: "repartidoridRepartidor");

            migrationBuilder.RenameColumn(
                name: "oNegocioidNegocio",
                table: "Pedidos",
                newName: "negocioidNegocio");

            migrationBuilder.RenameColumn(
                name: "oClienteidCliente",
                table: "Pedidos",
                newName: "clienteidCliente");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_oRepartidoridRepartidor",
                table: "Pedidos",
                newName: "IX_Pedidos_repartidoridRepartidor");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_oNegocioidNegocio",
                table: "Pedidos",
                newName: "IX_Pedidos_negocioidNegocio");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_oClienteidCliente",
                table: "Pedidos",
                newName: "IX_Pedidos_clienteidCliente");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "pedidoidPedido",
                table: "PedidosDetalle",
                newName: "oPedidoidPedido");

            migrationBuilder.RenameIndex(
                name: "IX_PedidosDetalle_pedidoidPedido",
                table: "PedidosDetalle",
                newName: "IX_PedidosDetalle_oPedidoidPedido");

            migrationBuilder.RenameColumn(
                name: "repartidoridRepartidor",
                table: "Pedidos",
                newName: "oRepartidoridRepartidor");

            migrationBuilder.RenameColumn(
                name: "negocioidNegocio",
                table: "Pedidos",
                newName: "oNegocioidNegocio");

            migrationBuilder.RenameColumn(
                name: "clienteidCliente",
                table: "Pedidos",
                newName: "oClienteidCliente");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_repartidoridRepartidor",
                table: "Pedidos",
                newName: "IX_Pedidos_oRepartidoridRepartidor");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_negocioidNegocio",
                table: "Pedidos",
                newName: "IX_Pedidos_oNegocioidNegocio");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_clienteidCliente",
                table: "Pedidos",
                newName: "IX_Pedidos_oClienteidCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_oClienteidCliente",
                table: "Pedidos",
                column: "oClienteidCliente",
                principalTable: "Clientes",
                principalColumn: "idCliente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Negocios_oNegocioidNegocio",
                table: "Pedidos",
                column: "oNegocioidNegocio",
                principalTable: "Negocios",
                principalColumn: "idNegocio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Repartidores_oRepartidoridRepartidor",
                table: "Pedidos",
                column: "oRepartidoridRepartidor",
                principalTable: "Repartidores",
                principalColumn: "idRepartidor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosDetalle_Pedidos_oPedidoidPedido",
                table: "PedidosDetalle",
                column: "oPedidoidPedido",
                principalTable: "Pedidos",
                principalColumn: "idPedido",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
