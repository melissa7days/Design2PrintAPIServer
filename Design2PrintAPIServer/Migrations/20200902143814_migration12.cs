using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Design2PrintAPIServer.Migrations
{
    public partial class migration12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customer_customerBillingDetails_CustomerBillingDetailsId",
                table: "customer");

            migrationBuilder.DropForeignKey(
                name: "FK_customer_customerShippingDetails_CustomerShippingDetailsId",
                table: "customer");

            migrationBuilder.DropTable(
                name: "bookBindingViewModel");

            migrationBuilder.DropTable(
                name: "colorViewModel");

            migrationBuilder.DropTable(
                name: "optionsViewModel");

            migrationBuilder.DropTable(
                name: "refinementViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productViewModels",
                table: "productViewModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productTypeQuantityViewModels",
                table: "productTypeQuantityViewModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productByIdViewModels",
                table: "productByIdViewModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customerShippingDetails",
                table: "customerShippingDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customerBillingDetails",
                table: "customerBillingDetails");

            migrationBuilder.RenameTable(
                name: "productViewModels",
                newName: "productViewModel");

            migrationBuilder.RenameTable(
                name: "productTypeQuantityViewModels",
                newName: "productTypeQuantityViewModel");

            migrationBuilder.RenameTable(
                name: "productByIdViewModels",
                newName: "productByIdViewModel");

            migrationBuilder.RenameTable(
                name: "customerShippingDetails",
                newName: "customerShippingDetail");

            migrationBuilder.RenameTable(
                name: "customerBillingDetails",
                newName: "customerBillingDetail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productViewModel",
                table: "productViewModel",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productTypeQuantityViewModel",
                table: "productTypeQuantityViewModel",
                column: "ProductTypeQuantityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productByIdViewModel",
                table: "productByIdViewModel",
                column: "ProductTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customerShippingDetail",
                table: "customerShippingDetail",
                column: "CustomerShippingDetailsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customerBillingDetail",
                table: "customerBillingDetail",
                column: "CustomerBillingDetailsId");

            migrationBuilder.CreateTable(
                name: "productTypeBookBindingViewModel",
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
                    table.PrimaryKey("PK_productTypeBookBindingViewModel", x => x.ProductTypeBookBindingId);
                });

            migrationBuilder.CreateTable(
                name: "productTypeColorViewModel",
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
                    table.PrimaryKey("PK_productTypeColorViewModel", x => x.ProductTypeColorId);
                });

            migrationBuilder.CreateTable(
                name: "productTypeDesignServiceViewModel",
                columns: table => new
                {
                    ProductTypeDesignServiceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DesignServicePrice = table.Column<double>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductTypeName = table.Column<string>(nullable: true),
                    DesignServiceId = table.Column<int>(nullable: false),
                    DesignServiceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeDesignServiceViewModel", x => x.ProductTypeDesignServiceId);
                });

            migrationBuilder.CreateTable(
                name: "productTypeDiscountViewModels",
                columns: table => new
                {
                    ProductTypeDiscountId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DiscountPrice = table.Column<double>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductTypeName = table.Column<string>(nullable: true),
                    DiscountId = table.Column<int>(nullable: false),
                    DiscountName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeDiscountViewModels", x => x.ProductTypeDiscountId);
                });

            migrationBuilder.CreateTable(
                name: "productTypeFinishedFormatViewModel",
                columns: table => new
                {
                    ProductTypeFinishedFormatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FinishedFormatPrice = table.Column<double>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductTypeName = table.Column<string>(nullable: true),
                    FinishedFormatId = table.Column<int>(nullable: false),
                    FinishedFormatName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeFinishedFormatViewModel", x => x.ProductTypeFinishedFormatId);
                });

            migrationBuilder.CreateTable(
                name: "productTypeFinishingViewModel",
                columns: table => new
                {
                    ProductTypeFinishingId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FinishingPrice = table.Column<double>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductTypeName = table.Column<string>(nullable: true),
                    FinishingId = table.Column<int>(nullable: false),
                    FinishingName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeFinishingViewModel", x => x.ProductTypeFinishingId);
                });

            migrationBuilder.CreateTable(
                name: "productTypeMaterialViewModel",
                columns: table => new
                {
                    ProductTypeMaterialId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaterialPrice = table.Column<double>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductTypeName = table.Column<string>(nullable: true),
                    MaterialId = table.Column<int>(nullable: false),
                    MaterialName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeMaterialViewModel", x => x.ProductTypeMaterialId);
                });

            migrationBuilder.CreateTable(
                name: "productTypeOptionsViewModel",
                columns: table => new
                {
                    ProductTypeOptionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OptionPrice = table.Column<double>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductTypeName = table.Column<string>(nullable: true),
                    OptionId = table.Column<int>(nullable: false),
                    OptionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeOptionsViewModel", x => x.ProductTypeOptionId);
                });

            migrationBuilder.CreateTable(
                name: "productTypePageViewModel",
                columns: table => new
                {
                    ProductTypePageId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PagePrice = table.Column<double>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductTypeName = table.Column<string>(nullable: true),
                    PageId = table.Column<int>(nullable: false),
                    PageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypePageViewModel", x => x.ProductTypePageId);
                });

            migrationBuilder.CreateTable(
                name: "productTypePDFViewModel",
                columns: table => new
                {
                    ProductTypePDFId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PDFPrice = table.Column<double>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductTypeName = table.Column<string>(nullable: true),
                    PDFId = table.Column<int>(nullable: false),
                    PDFName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypePDFViewModel", x => x.ProductTypePDFId);
                });

            migrationBuilder.CreateTable(
                name: "productTypeRefinementViewModel",
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
                    table.PrimaryKey("PK_productTypeRefinementViewModel", x => x.ProductTypeRefinementId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_customer_customerBillingDetail_CustomerBillingDetailsId",
                table: "customer",
                column: "CustomerBillingDetailsId",
                principalTable: "customerBillingDetail",
                principalColumn: "CustomerBillingDetailsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_customer_customerShippingDetail_CustomerShippingDetailsId",
                table: "customer",
                column: "CustomerShippingDetailsId",
                principalTable: "customerShippingDetail",
                principalColumn: "CustomerShippingDetailsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customer_customerBillingDetail_CustomerBillingDetailsId",
                table: "customer");

            migrationBuilder.DropForeignKey(
                name: "FK_customer_customerShippingDetail_CustomerShippingDetailsId",
                table: "customer");

            migrationBuilder.DropTable(
                name: "productTypeBookBindingViewModel");

            migrationBuilder.DropTable(
                name: "productTypeColorViewModel");

            migrationBuilder.DropTable(
                name: "productTypeDesignServiceViewModel");

            migrationBuilder.DropTable(
                name: "productTypeDiscountViewModels");

            migrationBuilder.DropTable(
                name: "productTypeFinishedFormatViewModel");

            migrationBuilder.DropTable(
                name: "productTypeFinishingViewModel");

            migrationBuilder.DropTable(
                name: "productTypeMaterialViewModel");

            migrationBuilder.DropTable(
                name: "productTypeOptionsViewModel");

            migrationBuilder.DropTable(
                name: "productTypePageViewModel");

            migrationBuilder.DropTable(
                name: "productTypePDFViewModel");

            migrationBuilder.DropTable(
                name: "productTypeRefinementViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productViewModel",
                table: "productViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productTypeQuantityViewModel",
                table: "productTypeQuantityViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productByIdViewModel",
                table: "productByIdViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customerShippingDetail",
                table: "customerShippingDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customerBillingDetail",
                table: "customerBillingDetail");

            migrationBuilder.RenameTable(
                name: "productViewModel",
                newName: "productViewModels");

            migrationBuilder.RenameTable(
                name: "productTypeQuantityViewModel",
                newName: "productTypeQuantityViewModels");

            migrationBuilder.RenameTable(
                name: "productByIdViewModel",
                newName: "productByIdViewModels");

            migrationBuilder.RenameTable(
                name: "customerShippingDetail",
                newName: "customerShippingDetails");

            migrationBuilder.RenameTable(
                name: "customerBillingDetail",
                newName: "customerBillingDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productViewModels",
                table: "productViewModels",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productTypeQuantityViewModels",
                table: "productTypeQuantityViewModels",
                column: "ProductTypeQuantityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productByIdViewModels",
                table: "productByIdViewModels",
                column: "ProductTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customerShippingDetails",
                table: "customerShippingDetails",
                column: "CustomerShippingDetailsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customerBillingDetails",
                table: "customerBillingDetails",
                column: "CustomerBillingDetailsId");

            migrationBuilder.CreateTable(
                name: "bookBindingViewModel",
                columns: table => new
                {
                    ProductTypeBookBindingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookBindingId = table.Column<int>(type: "int", nullable: false),
                    BookBindingName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    BookBindingPrice = table.Column<double>(type: "double", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookBindingViewModel", x => x.ProductTypeBookBindingId);
                });

            migrationBuilder.CreateTable(
                name: "colorViewModel",
                columns: table => new
                {
                    ProductTypeColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ColorName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ColorPrice = table.Column<double>(type: "double", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colorViewModel", x => x.ProductTypeColorId);
                });

            migrationBuilder.CreateTable(
                name: "optionsViewModel",
                columns: table => new
                {
                    ProductTypeOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OptionId = table.Column<int>(type: "int", nullable: false),
                    OptionName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    OptionPrice = table.Column<double>(type: "double", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_optionsViewModel", x => x.ProductTypeOptionId);
                });

            migrationBuilder.CreateTable(
                name: "refinementViewModel",
                columns: table => new
                {
                    ProductTypeRefinementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    RefinementId = table.Column<int>(type: "int", nullable: false),
                    RefinementName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    RefinementPrice = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refinementViewModel", x => x.ProductTypeRefinementId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_customer_customerBillingDetails_CustomerBillingDetailsId",
                table: "customer",
                column: "CustomerBillingDetailsId",
                principalTable: "customerBillingDetails",
                principalColumn: "CustomerBillingDetailsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_customer_customerShippingDetails_CustomerShippingDetailsId",
                table: "customer",
                column: "CustomerShippingDetailsId",
                principalTable: "customerShippingDetails",
                principalColumn: "CustomerShippingDetailsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
