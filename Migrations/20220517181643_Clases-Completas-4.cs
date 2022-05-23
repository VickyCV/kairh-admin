using Microsoft.EntityFrameworkCore.Migrations;

namespace kairh_admin.Migrations
{
    public partial class ClasesCompletas4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "repartidorid",
                table: "Pedidos",
                newName: "oRepartidorid");

            migrationBuilder.RenameColumn(
                name: "negocioid",
                table: "Pedidos",
                newName: "oNegocioid");

            migrationBuilder.RenameColumn(
                name: "clienteId",
                table: "Pedidos",
                newName: "oClienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_repartidorid",
                table: "Pedidos",
                newName: "IX_Pedidos_oRepartidorid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_negocioid",
                table: "Pedidos",
                newName: "IX_Pedidos_oNegocioid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_clienteId",
                table: "Pedidos",
                newName: "IX_Pedidos_oClienteid");

            migrationBuilder.RenameColumn(
                name: "clienteId",
                table: "Clientes",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_oClienteid",
                table: "Pedidos",
                column: "oClienteid",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Negocios_oNegocioid",
                table: "Pedidos",
                column: "oNegocioid",
                principalTable: "Negocios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Repartidores_oRepartidorid",
                table: "Pedidos",
                column: "oRepartidorid",
                principalTable: "Repartidores",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_oClienteid",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Negocios_oNegocioid",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Repartidores_oRepartidorid",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "oRepartidorid",
                table: "Pedidos",
                newName: "repartidorid");

            migrationBuilder.RenameColumn(
                name: "oNegocioid",
                table: "Pedidos",
                newName: "negocioid");

            migrationBuilder.RenameColumn(
                name: "oClienteid",
                table: "Pedidos",
                newName: "clienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_oRepartidorid",
                table: "Pedidos",
                newName: "IX_Pedidos_repartidorid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_oNegocioid",
                table: "Pedidos",
                newName: "IX_Pedidos_negocioid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_oClienteid",
                table: "Pedidos",
                newName: "IX_Pedidos_clienteId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Clientes",
                newName: "clienteId");

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
        }
    }
}
