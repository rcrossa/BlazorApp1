using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp2.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    nombre = table.Column<string>(maxLength: 50, nullable: true),
                    usuarioid = table.Column<string>(nullable: true),
                    clave = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recurso",
                columns: table => new
                {
                    nombre = table.Column<string>(nullable: false),
                    usuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.nombre);
                    table.ForeignKey(
                        name: "FK_Recurso_Usuario_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    idTarea = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    Vencimiento = table.Column<DateTime>(nullable: false),
                    Estimacion = table.Column<int>(nullable: false),
                    Responsablenombre = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.idTarea);
                    table.ForeignKey(
                        name: "FK_Tarea_Recurso_Responsablenombre",
                        column: x => x.Responsablenombre,
                        principalTable: "Recurso",
                        principalColumn: "nombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    Tiempo = table.Column<string>(nullable: true),
                    Recursonombre = table.Column<string>(nullable: true),
                    TareaidTarea = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.Fecha);
                    table.ForeignKey(
                        name: "FK_Detalle_Recurso_Recursonombre",
                        column: x => x.Recursonombre,
                        principalTable: "Recurso",
                        principalColumn: "nombre",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalle_Tarea_TareaidTarea",
                        column: x => x.TareaidTarea,
                        principalTable: "Tarea",
                        principalColumn: "idTarea",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Recursonombre",
                table: "Detalle",
                column: "Recursonombre");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_TareaidTarea",
                table: "Detalle",
                column: "TareaidTarea");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_usuarioId",
                table: "Recurso",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_Responsablenombre",
                table: "Tarea",
                column: "Responsablenombre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Recurso");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
