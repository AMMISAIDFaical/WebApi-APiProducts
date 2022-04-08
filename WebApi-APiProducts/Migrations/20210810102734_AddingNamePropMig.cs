using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_APiProducts.Migrations
{
    public partial class AddingNamePropMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Contributeres",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "faiçal");

            migrationBuilder.UpdateData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "yelawolf");

            migrationBuilder.UpdateData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "mark");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Contributeres");
        }
    }
}
