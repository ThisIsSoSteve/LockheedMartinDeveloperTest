using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LockheedMartin.DeveloperTest.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForecastWeeks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForecastWeeks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForecastTemperatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DayId = table.Column<int>(type: "int", nullable: false),
                    TemperatureC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    ForecastWeekId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForecastTemperatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForecastTemperatures_ForecastWeeks_ForecastWeekId",
                        column: x => x.ForecastWeekId,
                        principalTable: "ForecastWeeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ForecastTemperatures_ForecastWeekId",
                table: "ForecastTemperatures",
                column: "ForecastWeekId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForecastTemperatures");

            migrationBuilder.DropTable(
                name: "ForecastWeeks");
        }
    }
}
