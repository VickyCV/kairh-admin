using Microsoft.EntityFrameworkCore.Migrations;

namespace kairh_admin.Migrations
{
    public partial class kairhAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Repartidores",
                table: "Repartidores");

            migrationBuilder.RenameTable(
                name: "Repartidores",
                newName: "repartidor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_repartidor",
                table: "repartidor",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_repartidor",
                table: "repartidor");

            migrationBuilder.RenameTable(
                name: "repartidor",
                newName: "Repartidores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Repartidores",
                table: "Repartidores",
                column: "id");
        }
    }
}
