using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Design2PrintAPIServer.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productViewModels",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryDescription = table.Column<string>(nullable: true),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductTypeName = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductBasePrice = table.Column<double>(nullable: false),
                    ProductImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productViewModels", x => x.CategoryId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productViewModels");
        }
    }
}
