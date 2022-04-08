using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_APiProducts.Migrations
{
    public partial class ChangeTableAdminToOwnersMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_Contributeres_ContributereEntityId",
                table: "Admin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.RenameTable(
                name: "Admin",
                newName: "Admins");

            migrationBuilder.RenameIndex(
                name: "IX_Admin_ContributereEntityId",
                table: "Admins",
                newName: "IX_Admins_ContributereEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Contributeres_ContributereEntityId",
                table: "Admins",
                column: "ContributereEntityId",
                principalTable: "Contributeres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Contributeres_ContributereEntityId",
                table: "Admins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.RenameTable(
                name: "Admins",
                newName: "Admin");

            migrationBuilder.RenameIndex(
                name: "IX_Admins_ContributereEntityId",
                table: "Admin",
                newName: "IX_Admin_ContributereEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_Contributeres_ContributereEntityId",
                table: "Admin",
                column: "ContributereEntityId",
                principalTable: "Contributeres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
