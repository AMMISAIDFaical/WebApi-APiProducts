using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_APiProducts.Migrations
{
    public partial class UpdatedEntitiesFixedV2Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 2,
                column: "OwnerEntityId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contributeres",
                keyColumn: "Id",
                keyValue: 2,
                column: "OwnerEntityId",
                value: 4);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ContributerId", "LinkApi", "LinkDoc", "Name", "Status" },
                values: new object[] { 4, 4, "www.GmailAPI.com", "www.GmailAPI-doc.com", "GmailAPI", "stopped" });
        }
    }
}
