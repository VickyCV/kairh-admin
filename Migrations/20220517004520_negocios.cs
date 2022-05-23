using Microsoft.EntityFrameworkCore.Migrations;

namespace kairh_admin.Migrations
{
    public partial class negocios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Negocios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idFirebase = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Negocios");

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
    }
}
