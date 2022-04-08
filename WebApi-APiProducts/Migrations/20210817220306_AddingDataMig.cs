using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_APiProducts.Migrations
{
    public partial class AddingDataMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ProdName",
                table: "Products",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "JoinContributerProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdName = table.Column<string>(maxLength: 50, nullable: false),
                    LinkDoc = table.Column<string>(nullable: true),
                    LinkApi = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinContributerProduct", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contributeres",
                columns: new[] { "Id", "Email", "Name", "OwnerEntityId", "Password" },
                values: new object[,]
                {
                    { 4, "tesla@oulook.com", "tesla", 4, "teslak21" },
                    { 5, "dena@UFC.us", "ufc", 5, "UFC21" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProdName",
                value: "FacebookAPI");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProdName",
                value: "GoogleMapsAPI");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProdName",
                value: "YoutubeAPI");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ContributerId", "LinkApi", "LinkDoc", "ProdName", "Status" },
                values: new object[] { 4, 4, "www.TeslaAPI.com", "www.TeslaAPI-doc.com", "TeslaAPI", "paused" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ContributerId", "LinkApi", "LinkDoc", "ProdName", "Status" },
                values: new object[] { 5, 5, "www.UFCAPI.com", "www.UFCAPI-doc.com", "UFCAPI", "paused" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinContributerProduct");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ProdName",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "FacebookAPI");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "GoogleMapsAPI");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "YoutubeAPI");
        }
    }
}
