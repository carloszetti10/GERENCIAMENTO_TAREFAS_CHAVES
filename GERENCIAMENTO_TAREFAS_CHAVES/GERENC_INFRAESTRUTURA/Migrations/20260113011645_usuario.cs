using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GERENC_INFRAESTRUTURA.Migrations
{
    /// <inheritdoc />
    public partial class usuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PessoaCategoria_Pessoa_PessoaId",
                table: "PessoaCategoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                newName: "Pessoas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Ususarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ususarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agentes_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agentes_Ususarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Ususarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Porteiros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porteiros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Porteiros_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Porteiros_Ususarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Ususarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agentes_PessoaId",
                table: "Agentes",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Agentes_UsuarioId",
                table: "Agentes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Porteiros_PessoaId",
                table: "Porteiros",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Porteiros_UsuarioId",
                table: "Porteiros",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ususarios_Usuario",
                table: "Ususarios",
                column: "Usuario",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PessoaCategoria_Pessoas_PessoaId",
                table: "PessoaCategoria",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PessoaCategoria_Pessoas_PessoaId",
                table: "PessoaCategoria");

            migrationBuilder.DropTable(
                name: "Agentes");

            migrationBuilder.DropTable(
                name: "Porteiros");

            migrationBuilder.DropTable(
                name: "Ususarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "Pessoa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PessoaCategoria_Pessoa_PessoaId",
                table: "PessoaCategoria",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
