using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Design2PrintAPIServer.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookBinding",
                columns: table => new
                {
                    BookBindingId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookBindingName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookBinding", x => x.BookBindingId);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "color",
                columns: table => new
                {
                    ColorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ColorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_color", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "customerBillingDetails",
                columns: table => new
                {
                    CustomerBillingDetailsId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BillingBuilding = table.Column<string>(nullable: true),
                    BillingAddress1 = table.Column<string>(nullable: true),
                    BillingAddress2 = table.Column<string>(nullable: true),
                    BillingCity = table.Column<string>(nullable: true),
                    BillingProvince = table.Column<string>(nullable: true),
                    BillingCountry = table.Column<string>(nullable: true),
                    BillingPostalCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerBillingDetails", x => x.CustomerBillingDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "customerShippingDetails",
                columns: table => new
                {
                    CustomerShippingDetailsId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Building = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PostalCode = table.Column<int>(nullable: false),
                    DeliveryInstructions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerShippingDetails", x => x.CustomerShippingDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "designService",
                columns: table => new
                {
                    DesignServiceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DesignServiceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_designService", x => x.DesignServiceId);
                });

            migrationBuilder.CreateTable(
                name: "discount",
                columns: table => new
                {
                    DiscountId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DiscountName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_discount", x => x.DiscountId);
                });

            migrationBuilder.CreateTable(
                name: "finishedFormat",
                columns: table => new
                {
                    FinishedFormatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FinishedFormatName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_finishedFormat", x => x.FinishedFormatId);
                });

            migrationBuilder.CreateTable(
                name: "finishing",
                columns: table => new
                {
                    FinishingId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FinishingName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_finishing", x => x.FinishingId);
                });

            migrationBuilder.CreateTable(
                name: "material",
                columns: table => new
                {
                    MaterialId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaterialName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_material", x => x.MaterialId);
                });

            migrationBuilder.CreateTable(
                name: "option",
                columns: table => new
                {
                    OptionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OptionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_option", x => x.OptionId);
                });

            migrationBuilder.CreateTable(
                name: "pages",
                columns: table => new
                {
                    PageId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pages", x => x.PageId);
                });

            migrationBuilder.CreateTable(
                name: "pdf",
                columns: table => new
                {
                    PDFId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PDFName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pdf", x => x.PDFId);
                });

            migrationBuilder.CreateTable(
                name: "productByIdViewModels",
                columns: table => new
                {
                    ProductTypeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeName = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryDescription = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductBasePrice = table.Column<double>(nullable: false),
                    ProductImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productByIdViewModels", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "productType",
                columns: table => new
                {
                    ProductTypeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productType", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "productViewModels",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(nullable: true),
                    ProductBasePrice = table.Column<double>(nullable: false),
                    ProductImage = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryDescription = table.Column<string>(nullable: true),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productViewModels", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "quantity",
                columns: table => new
                {
                    QuantityId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    QuantityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quantity", x => x.QuantityId);
                });

            migrationBuilder.CreateTable(
                name: "refinement",
                columns: table => new
                {
                    RefinementId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RefinementName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refinement", x => x.RefinementId);
                });

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerShippingDetailsId = table.Column<int>(nullable: false),
                    CustomerBillingDetailsId = table.Column<int>(nullable: false),
                    CustomerFirstName = table.Column<string>(nullable: true),
                    CustomerLastName = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<string>(nullable: true),
                    CustomerEmail = table.Column<string>(nullable: true),
                    CustomerPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_customer_customerBillingDetails_CustomerBillingDetailsId",
                        column: x => x.CustomerBillingDetailsId,
                        principalTable: "customerBillingDetails",
                        principalColumn: "CustomerBillingDetailsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_customer_customerShippingDetails_CustomerShippingDetailsId",
                        column: x => x.CustomerShippingDetailsId,
                        principalTable: "customerShippingDetails",
                        principalColumn: "CustomerShippingDetailsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductBasePrice = table.Column<double>(nullable: false),
                    ProductImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_product_category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_product_productType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "productType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productTypeBookBinding",
                columns: table => new
                {
                    ProductTypeBookBindingId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<int>(nullable: false),
                    BookBindingId = table.Column<int>(nullable: false),
                    BookBindingPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeBookBinding", x => x.ProductTypeBookBindingId);
                    table.ForeignKey(
                        name: "FK_productTypeBookBinding_bookBinding_BookBindingId",
                        column: x => x.BookBindingId,
                        principalTable: "bookBinding",
                        principalColumn: "BookBindingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productTypeBookBinding_productType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "productType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productTypeColor",
                columns: table => new
                {
                    ProductTypeColorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false),
                    ColorPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeColor", x => x.ProductTypeColorId);
                    table.ForeignKey(
                        name: "FK_productTypeColor_color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "color",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productTypeColor_productType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "productType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productTypeDesignService",
                columns: table => new
                {
                    ProductTypeDesignServiceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<int>(nullable: false),
                    DesignServiceId = table.Column<int>(nullable: false),
                    DesignServicePrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeDesignService", x => x.ProductTypeDesignServiceId);
                    table.ForeignKey(
                        name: "FK_productTypeDesignService_designService_DesignServiceId",
                        column: x => x.DesignServiceId,
                        principalTable: "designService",
                        principalColumn: "DesignServiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productTypeDesignService_productType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "productType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productTypeDiscount",
                columns: table => new
                {
                    ProductTypeDiscountId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<int>(nullable: false),
                    DiscountId = table.Column<int>(nullable: false),
                    DiscountPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeDiscount", x => x.ProductTypeDiscountId);
                    table.ForeignKey(
                        name: "FK_productTypeDiscount_discount_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "discount",
                        principalColumn: "DiscountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productTypeDiscount_productType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "productType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productTypeFinishedFormat",
                columns: table => new
                {
                    ProductTypeFinishedFormatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<int>(nullable: false),
                    FinishedFormatId = table.Column<int>(nullable: false),
                    FinishedFormatPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeFinishedFormat", x => x.ProductTypeFinishedFormatId);
                    table.ForeignKey(
                        name: "FK_productTypeFinishedFormat_finishedFormat_FinishedFormatId",
                        column: x => x.FinishedFormatId,
                        principalTable: "finishedFormat",
                        principalColumn: "FinishedFormatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productTypeFinishedFormat_productType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "productType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productTypeFinishing",
                columns: table => new
                {
                    ProductTypeFinishingId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<int>(nullable: false),
                    FinishingId = table.Column<int>(nullable: false),
                    FinishingPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeFinishing", x => x.ProductTypeFinishingId);
                    table.ForeignKey(
                        name: "FK_productTypeFinishing_finishing_FinishingId",
                        column: x => x.FinishingId,
                        principalTable: "finishing",
                        principalColumn: "FinishingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productTypeFinishing_productType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "productType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productTypeMaterial",
                columns: table => new
                {
                    ProductTypeMaterialId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<int>(nullable: false),
                    MaterialId = table.Column<int>(nullable: false),
                    MaterialPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeMaterial", x => x.ProductTypeMaterialId);
                    table.ForeignKey(
                        name: "FK_productTypeMaterial_material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "material",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productTypeMaterial_productType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "productType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productTypeOption",
                columns: table => new
                {
                    ProductTypeOptionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<int>(nullable: false),
                    OptionId = table.Column<int>(nullable: false),
                    OptionPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeOption", x => x.ProductTypeOptionId);
                    table.ForeignKey(
                        name: "FK_productTypeOption_option_OptionId",
                        column: x => x.OptionId,
                        principalTable: "option",
                        principalColumn: "OptionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productTypeOption_productType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "productType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productTypePages",
                columns: table => new
                {
                    ProductTypePageId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<int>(nullable: false),
                    PageId = table.Column<int>(nullable: false),
                    PagePrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypePages", x => x.ProductTypePageId);
                    table.ForeignKey(
                        name: "FK_productTypePages_pages_PageId",
                        column: x => x.PageId,
                        principalTable: "pages",
                        principalColumn: "PageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productTypePages_productType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "productType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productTypePDF",
                columns: table => new
                {
                    ProductTypePDFId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<int>(nullable: false),
                    PDFId = table.Column<int>(nullable: false),
                    PDFPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypePDF", x => x.ProductTypePDFId);
                    table.ForeignKey(
                        name: "FK_productTypePDF_pdf_PDFId",
                        column: x => x.PDFId,
                        principalTable: "pdf",
                        principalColumn: "PDFId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productTypePDF_productType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "productType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productTypeQuantity",
                columns: table => new
                {
                    ProductTypeQuantityId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<int>(nullable: false),
                    QuantityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeQuantity", x => x.ProductTypeQuantityId);
                    table.ForeignKey(
                        name: "FK_productTypeQuantity_productType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "productType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productTypeQuantity_quantity_QuantityId",
                        column: x => x.QuantityId,
                        principalTable: "quantity",
                        principalColumn: "QuantityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productTypeRefinement",
                columns: table => new
                {
                    ProductTypeRefinementId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductTypeId = table.Column<int>(nullable: false),
                    RefinementId = table.Column<int>(nullable: false),
                    RefinementPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypeRefinement", x => x.ProductTypeRefinementId);
                    table.ForeignKey(
                        name: "FK_productTypeRefinement_productType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "productType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productTypeRefinement_refinement_RefinementId",
                        column: x => x.RefinementId,
                        principalTable: "refinement",
                        principalColumn: "RefinementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    OrderNumber = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderShippingDate = table.Column<DateTime>(nullable: false),
                    OrderBillingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_order_customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cart",
                columns: table => new
                {
                    CartId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    ProductionCost = table.Column<double>(nullable: false),
                    DeliveryFee = table.Column<double>(nullable: false),
                    ArtworkAdjustment = table.Column<double>(nullable: false),
                    DesignService = table.Column<double>(nullable: false),
                    NetPrice = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false),
                    GrossPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cart", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_cart_customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cart_product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orderDetails",
                columns: table => new
                {
                    OrderDetailsId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    CartId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderDetails", x => x.OrderDetailsId);
                    table.ForeignKey(
                        name: "FK_orderDetails_cart_CartId",
                        column: x => x.CartId,
                        principalTable: "cart",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderDetails_order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "payment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CartId = table.Column<int>(nullable: false),
                    PaymentMessage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_payment_cart_CartId",
                        column: x => x.CartId,
                        principalTable: "cart",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cart_CustomerId",
                table: "cart",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_cart_ProductId",
                table: "cart",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_customer_CustomerBillingDetailsId",
                table: "customer",
                column: "CustomerBillingDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_customer_CustomerShippingDetailsId",
                table: "customer",
                column: "CustomerShippingDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_order_CustomerId",
                table: "order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetails_CartId",
                table: "orderDetails",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetails_OrderId",
                table: "orderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_payment_CartId",
                table: "payment",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_product_CategoryId",
                table: "product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_product_ProductTypeId",
                table: "product",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeBookBinding_BookBindingId",
                table: "productTypeBookBinding",
                column: "BookBindingId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeBookBinding_ProductTypeId",
                table: "productTypeBookBinding",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeColor_ColorId",
                table: "productTypeColor",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeColor_ProductTypeId",
                table: "productTypeColor",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeDesignService_DesignServiceId",
                table: "productTypeDesignService",
                column: "DesignServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeDesignService_ProductTypeId",
                table: "productTypeDesignService",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeDiscount_DiscountId",
                table: "productTypeDiscount",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeDiscount_ProductTypeId",
                table: "productTypeDiscount",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeFinishedFormat_FinishedFormatId",
                table: "productTypeFinishedFormat",
                column: "FinishedFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeFinishedFormat_ProductTypeId",
                table: "productTypeFinishedFormat",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeFinishing_FinishingId",
                table: "productTypeFinishing",
                column: "FinishingId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeFinishing_ProductTypeId",
                table: "productTypeFinishing",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeMaterial_MaterialId",
                table: "productTypeMaterial",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeMaterial_ProductTypeId",
                table: "productTypeMaterial",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeOption_OptionId",
                table: "productTypeOption",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeOption_ProductTypeId",
                table: "productTypeOption",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypePages_PageId",
                table: "productTypePages",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypePages_ProductTypeId",
                table: "productTypePages",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypePDF_PDFId",
                table: "productTypePDF",
                column: "PDFId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypePDF_ProductTypeId",
                table: "productTypePDF",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeQuantity_ProductTypeId",
                table: "productTypeQuantity",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeQuantity_QuantityId",
                table: "productTypeQuantity",
                column: "QuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeRefinement_ProductTypeId",
                table: "productTypeRefinement",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_productTypeRefinement_RefinementId",
                table: "productTypeRefinement",
                column: "RefinementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderDetails");

            migrationBuilder.DropTable(
                name: "payment");

            migrationBuilder.DropTable(
                name: "productByIdViewModels");

            migrationBuilder.DropTable(
                name: "productTypeBookBinding");

            migrationBuilder.DropTable(
                name: "productTypeColor");

            migrationBuilder.DropTable(
                name: "productTypeDesignService");

            migrationBuilder.DropTable(
                name: "productTypeDiscount");

            migrationBuilder.DropTable(
                name: "productTypeFinishedFormat");

            migrationBuilder.DropTable(
                name: "productTypeFinishing");

            migrationBuilder.DropTable(
                name: "productTypeMaterial");

            migrationBuilder.DropTable(
                name: "productTypeOption");

            migrationBuilder.DropTable(
                name: "productTypePages");

            migrationBuilder.DropTable(
                name: "productTypePDF");

            migrationBuilder.DropTable(
                name: "productTypeQuantity");

            migrationBuilder.DropTable(
                name: "productTypeRefinement");

            migrationBuilder.DropTable(
                name: "productViewModels");

            migrationBuilder.DropTable(
                name: "order");

            migrationBuilder.DropTable(
                name: "cart");

            migrationBuilder.DropTable(
                name: "bookBinding");

            migrationBuilder.DropTable(
                name: "color");

            migrationBuilder.DropTable(
                name: "designService");

            migrationBuilder.DropTable(
                name: "discount");

            migrationBuilder.DropTable(
                name: "finishedFormat");

            migrationBuilder.DropTable(
                name: "finishing");

            migrationBuilder.DropTable(
                name: "material");

            migrationBuilder.DropTable(
                name: "option");

            migrationBuilder.DropTable(
                name: "pages");

            migrationBuilder.DropTable(
                name: "pdf");

            migrationBuilder.DropTable(
                name: "quantity");

            migrationBuilder.DropTable(
                name: "refinement");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "customerBillingDetails");

            migrationBuilder.DropTable(
                name: "customerShippingDetails");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "productType");
        }
    }
}
