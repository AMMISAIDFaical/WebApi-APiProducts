using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_APiProducts.Migrations
{
    public partial class newDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "atha");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "yelawolf");
        }
    }
}
