using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GERENC_INFRAESTRUTURA.Migrations
{
    /// <inheritdoc />
    public partial class salaCatedorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalaCategoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    SalaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaCategoria", x => new { x.SalaId, x.CategoriaId });
                    table.ForeignKey(
                        name: "FK_SalaCategoria_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalaCategoria_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalaCategoria_CategoriaId",
                table: "SalaCategoria",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalaCategoria");
        }
    }
}
