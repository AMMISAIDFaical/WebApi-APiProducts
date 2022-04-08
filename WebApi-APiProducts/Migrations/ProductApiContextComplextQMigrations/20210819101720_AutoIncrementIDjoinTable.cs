using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_APiProducts.Migrations.ProductApiContextComplextQMigrations
{
    public partial class AutoIncrementIDjoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinContributerProduct");
        }
    }
}
