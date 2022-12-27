using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace N5Challenge.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RelantioshipBetweenTypeAndPermissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TipoPermiso",
                schema: "dbo",
                table: "Permisos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_TipoPermiso",
                schema: "dbo",
                table: "Permisos",
                column: "TipoPermiso");

            migrationBuilder.AddForeignKey(
                name: "FK_Permisos_TipoPermisos_TipoPermiso",
                schema: "dbo",
                table: "Permisos",
                column: "TipoPermiso",
                principalSchema: "dbo",
                principalTable: "TipoPermisos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permisos_TipoPermisos_TipoPermiso",
                schema: "dbo",
                table: "Permisos");

            migrationBuilder.DropIndex(
                name: "IX_Permisos_TipoPermiso",
                schema: "dbo",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "TipoPermiso",
                schema: "dbo",
                table: "Permisos");
        }
    }
}
