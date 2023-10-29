using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroducaoAPI.Migrations
{
    /// <inheritdoc />
    public partial class BancoUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefa_Usuarios_UsuarioId",
                table: "Tarefa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarefa",
                table: "Tarefa");

            migrationBuilder.RenameTable(
                name: "Tarefa",
                newName: "Tarefas");

            migrationBuilder.RenameIndex(
                name: "IX_Tarefa_UsuarioId",
                table: "Tarefas",
                newName: "IX_Tarefas_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Usuarios_UsuarioId",
                table: "Tarefas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Usuarios_UsuarioId",
                table: "Tarefas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas");

            migrationBuilder.RenameTable(
                name: "Tarefas",
                newName: "Tarefa");

            migrationBuilder.RenameIndex(
                name: "IX_Tarefas_UsuarioId",
                table: "Tarefa",
                newName: "IX_Tarefa_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarefa",
                table: "Tarefa",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefa_Usuarios_UsuarioId",
                table: "Tarefa",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
