using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_APiProducts.Migrations
{
    public partial class AddMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    LinkDoc = table.Column<string>(nullable: true),
                    LinkApi = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contributeres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    ProductEntityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contributeres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contributeres_Products_ProductEntityId",
                        column: x => x.ProductEntityId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    ContributereEntityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admin_Contributeres_ContributereEntityId",
                        column: x => x.ContributereEntityId,
                        principalTable: "Contributeres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "LinkApi", "LinkDoc", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "www.facebookApi.com", "www.facebookApi-doc.com", "FacebookAPI", "active" },
                    { 2, "www.GoogleMapsAPI.com", "www.GoogleMapsAPI-doc.com", "GoogleMapsAPI", "paused" },
                    { 3, "www.YoutubeAPI.com", "www.YoutubeAPI-doc.com", "YoutubeAPI", "active" },
                    { 4, "www.GmailAPI.com", "www.GmailAPI-doc.com", "GmailAPI", "stopped" }
                });

            migrationBuilder.InsertData(
                table: "Contributeres",
                columns: new[] { "Id", "Email", "Password", "ProductEntityId" },
                values: new object[] { 1, "faicalammisaid2000@gmail.com", "0123azerty", 1 });

            migrationBuilder.InsertData(
                table: "Contributeres",
                columns: new[] { "Id", "Email", "Password", "ProductEntityId" },
                values: new object[] { 2, "slumerican@oulook.com", "mudmouth21", 3 });

            migrationBuilder.InsertData(
                table: "Contributeres",
                columns: new[] { "Id", "Email", "Password", "ProductEntityId" },
                values: new object[] { 3, "facebook@oulook.com", "facebook21", 4 });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "ContributereEntityId", "Email", "Password" },
                values: new object[] { 1, 1, "admin1@gmail.com", "admin1234" });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "ContributereEntityId", "Email", "Password" },
                values: new object[] { 3, 2, "admin3@oulook.com", "admin5544" });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "ContributereEntityId", "Email", "Password" },
                values: new object[] { 2, 3, "admin2@oulook.com", "admin9876" });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_ContributereEntityId",
                table: "Admin",
                column: "ContributereEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Contributeres_ProductEntityId",
                table: "Contributeres",
                column: "ProductEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Contributeres");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
