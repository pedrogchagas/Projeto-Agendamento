using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_Agendamento.Migrations
{
    /// <inheritdoc />
    public partial class correcao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeEmpresa",
                table: "Estabelecimentos",
                newName: "NomeEstabelecimento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeEstabelecimento",
                table: "Estabelecimentos",
                newName: "NomeEmpresa");
        }
    }
}
