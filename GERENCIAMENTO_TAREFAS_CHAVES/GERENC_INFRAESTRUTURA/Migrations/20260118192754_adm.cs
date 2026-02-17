using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GERENC_INFRAESTRUTURA.Migrations
{
    /// <inheritdoc />
    public partial class adm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agentes_Ususarios_UsuarioId",
                table: "Agentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Porteiros_Ususarios_UsuarioId",
                table: "Porteiros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ususarios",
                table: "Ususarios");

            migrationBuilder.RenameTable(
                name: "Ususarios",
                newName: "Usuarios");

            migrationBuilder.RenameIndex(
                name: "IX_Ususarios_Usuario",
                table: "Usuarios",
                newName: "IX_Usuarios_Usuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Administradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administradores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administradores_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Administradores_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administradores_PessoaId",
                table: "Administradores",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Administradores_UsuarioId",
                table: "Administradores",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agentes_Usuarios_UsuarioId",
                table: "Agentes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Porteiros_Usuarios_UsuarioId",
                table: "Porteiros",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agentes_Usuarios_UsuarioId",
                table: "Agentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Porteiros_Usuarios_UsuarioId",
                table: "Porteiros");

            migrationBuilder.DropTable(
                name: "Administradores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Ususarios");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_Usuario",
                table: "Ususarios",
                newName: "IX_Ususarios_Usuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ususarios",
                table: "Ususarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agentes_Ususarios_UsuarioId",
                table: "Agentes",
                column: "UsuarioId",
                principalTable: "Ususarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Porteiros_Ususarios_UsuarioId",
                table: "Porteiros",
                column: "UsuarioId",
                principalTable: "Ususarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
