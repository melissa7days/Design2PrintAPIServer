using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Design2PrintAPIServer.Migrations
{
    public partial class migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookBindingViewModel",
                columns: table => new
                {
                    ProductTypeBookBindingId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookBindingPrice = table.Column<double>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductTypeName = table.Column<string>(nullable: true),
                    BookBindingId = table.Column<int>(nullable: false),
                    BookBindingName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookBindingViewModel", x => x.ProductTypeBookBindingId);
                });

            migrationBuilder.CreateTable(
                name: "colorViewModel",
                columns: table => new
                {
                    ProductTypeColorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ColorPrice = table.Column<double>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductTypeName = table.Column<string>(nullable: true),
                    ColorId = table.Column<int>(nullable: false),
                    ColorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colorViewModel", x => x.ProductTypeColorId);
                });

            migrationBuilder.CreateTable(
                name: "refinementViewModel",
                columns: table => new
                {
                    ProductTypeRefinementId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RefinementPrice = table.Column<double>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductTypeName = table.Column<string>(nullable: true),
                    RefinementId = table.Column<int>(nullable: false),
                    RefinementName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refinementViewModel", x => x.ProductTypeRefinementId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookBindingViewModel");

            migrationBuilder.DropTable(
                name: "colorViewModel");

            migrationBuilder.DropTable(
                name: "refinementViewModel");
        }
    }
}
