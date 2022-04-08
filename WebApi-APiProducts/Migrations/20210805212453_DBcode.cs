using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_APiProducts.Migrations
{
    public partial class DBcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.CreateTable(
                name: "Owners",
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
                    table.PrimaryKey("PK_Owners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Owners_Contributeres_ContributereEntityId",
                        column: x => x.ContributereEntityId,
                        principalTable: "Contributeres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "ContributereEntityId", "Email", "Password" },
                values: new object[] { 1, 1, "admin1@gmail.com", "admin1234" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "ContributereEntityId", "Email", "Password" },
                values: new object[] { 2, 3, "admin2@oulook.com", "admin9876" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "ContributereEntityId", "Email", "Password" },
                values: new object[] { 3, 2, "admin3@oulook.com", "admin5544" });

            migrationBuilder.CreateIndex(
                name: "IX_Owners_ContributereEntityId",
                table: "Owners",
                column: "ContributereEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContributereEntityId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_Contributeres_ContributereEntityId",
                        column: x => x.ContributereEntityId,
                        principalTable: "Contributeres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "ContributereEntityId", "Email", "Password" },
                values: new object[] { 1, 1, "admin1@gmail.com", "admin1234" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "ContributereEntityId", "Email", "Password" },
                values: new object[] { 2, 3, "admin2@oulook.com", "admin9876" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "ContributereEntityId", "Email", "Password" },
                values: new object[] { 3, 2, "admin3@oulook.com", "admin5544" });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_ContributereEntityId",
                table: "Admins",
                column: "ContributereEntityId");
        }
    }
}
