using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_APiProducts.Migrations
{
    public partial class UpdatedEntitiesMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contributeres_Products_ProductEntityId",
                table: "Contributeres");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Contributeres_ContributereEntityId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Owners_ContributereEntityId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Contributeres_ProductEntityId",
                table: "Contributeres");

            migrationBuilder.DropColumn(
                name: "ContributereEntityId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "ProductEntityId",
                table: "Contributeres");

            migrationBuilder.AddColumn<int>(
                name: "ContributerId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OwnerEntityId",
                table: "Contributeres",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 1,
                column: "OwnerEntityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 2,
                column: "OwnerEntityId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 3,
                column: "OwnerEntityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContributerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContributerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ContributerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ContributerId",
                value: 4);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ContributerId",
                table: "Products",
                column: "ContributerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contributeres_OwnerEntityId",
                table: "Contributeres",
                column: "OwnerEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contributeres_Owners_OwnerEntityId",
                table: "Contributeres",
                column: "OwnerEntityId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Contributeres_ContributerId",
                table: "Products",
                column: "ContributerId",
                principalTable: "Contributeres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contributeres_Owners_OwnerEntityId",
                table: "Contributeres");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Contributeres_ContributerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ContributerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Contributeres_OwnerEntityId",
                table: "Contributeres");

            migrationBuilder.DropColumn(
                name: "ContributerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OwnerEntityId",
                table: "Contributeres");

            migrationBuilder.AddColumn<int>(
                name: "ContributereEntityId",
                table: "Owners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductEntityId",
                table: "Contributeres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductEntityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductEntityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductEntityId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContributereEntityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContributereEntityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3,
                column: "ContributereEntityId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Owners_ContributereEntityId",
                table: "Owners",
                column: "ContributereEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Contributeres_ProductEntityId",
                table: "Contributeres",
                column: "ProductEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contributeres_Products_ProductEntityId",
                table: "Contributeres",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Contributeres_ContributereEntityId",
                table: "Owners",
                column: "ContributereEntityId",
                principalTable: "Contributeres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
