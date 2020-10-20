using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Dois : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Funcionario");

            migrationBuilder.AddColumn<int>(
                name: "Cpf",
                table: "Funcionario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<int>(nullable: false),
                    Telefone = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    EstadoCivil = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Funcionario");

            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Funcionario",
                nullable: true);
        }
    }
}
