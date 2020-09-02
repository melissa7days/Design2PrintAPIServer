using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Design2PrintAPIServer.Migrations
{
    public partial class migration11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productTypeQuantityViewModels",
                columns: table => new
                {
                    ProductTypeQuantityId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductTypeName = table.Column<string>(nullable: true),
                    QuantityId = table.Column<int>(nullable: false),
                    QuantityName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeQuantityViewModels", x => x.ProductTypeQuantityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productTypeQuantityViewModels");
        }
    }
}
