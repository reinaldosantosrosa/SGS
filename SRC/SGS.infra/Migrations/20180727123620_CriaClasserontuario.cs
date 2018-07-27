using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SGS.infra.Migrations
{
    public partial class CriaClasserontuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prontuario",
                columns: table => new
                {
                    ProntuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiarioID = table.Column<int>(nullable: false),
                    DataAtendimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prontuario", x => x.ProntuarioId);
                    table.ForeignKey(
                        name: "FK_Prontuario_Beneficiario_BeneficiarioID",
                        column: x => x.BeneficiarioID,
                        principalTable: "Beneficiario",
                        principalColumn: "BeneficiarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prontuario_BeneficiarioID",
                table: "Prontuario",
                column: "BeneficiarioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prontuario");
        }
    }
}
