using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication7.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    Lib_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lib_Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Lib_Autor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Lib_Genero = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Lib_TipoProyecto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Lib_Status = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.Lib_Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Rol_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rol_Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Rol_Status = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Rol_Id);
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    Per_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Per_LibId = table.Column<int>(type: "int", nullable: false),
                    LibrosLib_Id = table.Column<int>(type: "int", nullable: false),
                    Per_RolId = table.Column<int>(type: "int", nullable: false),
                    Per_Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Per_Apellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Per_Descripcion = table.Column<string>(type: "nvarchar(101)", maxLength: 101, nullable: false),
                    Per_FechaNacimiento = table.Column<DateTime>(type: "datetime2", maxLength: 255, nullable: false),
                    Per_LugarNacimiento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Per_Status = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.Per_Id);
                    table.ForeignKey(
                        name: "FK_Personajes_Libros_LibrosLib_Id",
                        column: x => x.LibrosLib_Id,
                        principalTable: "Libros",
                        principalColumn: "Lib_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personajes_Roles_Per_RolId",
                        column: x => x.Per_RolId,
                        principalTable: "Roles",
                        principalColumn: "Rol_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_LibrosLib_Id",
                table: "Personajes",
                column: "LibrosLib_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_Per_RolId",
                table: "Personajes",
                column: "Per_RolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
