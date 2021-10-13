using Microsoft.EntityFrameworkCore.Migrations;

namespace Simulacion_PC.Migrations
{
    public partial class CategoriaMgrs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_solicitud_t_categoria_categoriaId",
                table: "t_solicitud");

            migrationBuilder.RenameColumn(
                name: "categoriaId",
                table: "t_solicitud",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_t_solicitud_categoriaId",
                table: "t_solicitud",
                newName: "IX_t_solicitud_CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_t_solicitud_t_categoria_CategoriaId",
                table: "t_solicitud",
                column: "CategoriaId",
                principalTable: "t_categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_solicitud_t_categoria_CategoriaId",
                table: "t_solicitud");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "t_solicitud",
                newName: "categoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_t_solicitud_CategoriaId",
                table: "t_solicitud",
                newName: "IX_t_solicitud_categoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_t_solicitud_t_categoria_categoriaId",
                table: "t_solicitud",
                column: "categoriaId",
                principalTable: "t_categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
