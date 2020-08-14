﻿// <auto-generated />
using System;
using Design2PrintAPIServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Design2PrintAPIServer.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Design2PrintAPIServer.Models.BookBinding", b =>
                {
                    b.Property<int>("BookBindingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BookBindingName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BookBindingId");

                    b.ToTable("bookBinding");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("ArtworkAdjustment")
                        .HasColumnType("double");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<double>("DeliveryFee")
                        .HasColumnType("double");

                    b.Property<double>("DesignService")
                        .HasColumnType("double");

                    b.Property<double>("GrossPrice")
                        .HasColumnType("double");

                    b.Property<double>("NetPrice")
                        .HasColumnType("double");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("ProductionCost")
                        .HasColumnType("double");

                    b.Property<double>("Tax")
                        .HasColumnType("double");

                    b.HasKey("CartId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("cart");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CategoryName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CategoryId");

                    b.ToTable("category");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ColorName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ColorId");

                    b.ToTable("color");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CustomerBillingDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CustomerFirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CustomerLastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CustomerPassword")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CustomerPhone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("CustomerShippingDetailsId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("CustomerBillingDetailsId");

                    b.HasIndex("CustomerShippingDetailsId");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.CustomerBillingDetails", b =>
                {
                    b.Property<int>("CustomerBillingDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BillingAddress1")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BillingAddress2")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BillingBuilding")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BillingCity")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BillingCountry")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("BillingPostalCode")
                        .HasColumnType("int");

                    b.Property<string>("BillingProvince")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CustomerBillingDetailsId");

                    b.ToTable("customerBillingDetails");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.CustomerShippingDetails", b =>
                {
                    b.Property<int>("CustomerShippingDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address1")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Address2")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Building")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DeliveryInstructions")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("Province")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CustomerShippingDetailsId");

                    b.ToTable("customerShippingDetails");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.DesignService", b =>
                {
                    b.Property<int>("DesignServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DesignServiceName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DesignServiceId");

                    b.ToTable("designService");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Discount", b =>
                {
                    b.Property<int>("DiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DiscountName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DiscountId");

                    b.ToTable("discount");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.FinishedFormat", b =>
                {
                    b.Property<int>("FinishedFormatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FinishedFormatName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("FinishedFormatId");

                    b.ToTable("finishedFormat");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Finishing", b =>
                {
                    b.Property<int>("FinishingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FinishingName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("FinishingId");

                    b.ToTable("finishing");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MaterialName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("MaterialId");

                    b.ToTable("material");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Option", b =>
                {
                    b.Property<int>("OptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("OptionName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("OptionId");

                    b.ToTable("option");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderBillingDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("OrderShippingDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("order");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailsId");

                    b.HasIndex("CartId");

                    b.HasIndex("OrderId");

                    b.ToTable("orderDetails");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.PDF", b =>
                {
                    b.Property<int>("PDFId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PDFName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PDFId");

                    b.ToTable("pdf");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Pages", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PageName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PageId");

                    b.ToTable("pages");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMessage")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PaymentId");

                    b.HasIndex("CartId");

                    b.ToTable("payment");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<double>("ProductBasePrice")
                        .HasColumnType("double");

                    b.Property<string>("ProductImage")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ProductName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("product");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductType", b =>
                {
                    b.Property<int>("ProductTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ProductTypeName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ProductTypeId");

                    b.ToTable("productType");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeBookBinding", b =>
                {
                    b.Property<int>("ProductTypeBookBindingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BookBindingId")
                        .HasColumnType("int");

                    b.Property<double>("BookBindingPrice")
                        .HasColumnType("double");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductTypeBookBindingId");

                    b.HasIndex("BookBindingId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("productTypeBookBinding");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeColor", b =>
                {
                    b.Property<int>("ProductTypeColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<double>("ColorPrice")
                        .HasColumnType("double");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductTypeColorId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("productTypeColor");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeDesignService", b =>
                {
                    b.Property<int>("ProductTypeDesignServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DesignServiceId")
                        .HasColumnType("int");

                    b.Property<double>("DesignServicePrice")
                        .HasColumnType("double");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductTypeDesignServiceId");

                    b.HasIndex("DesignServiceId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("productTypeDesignService");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeDiscount", b =>
                {
                    b.Property<int>("ProductTypeDiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<double>("DiscountPrice")
                        .HasColumnType("double");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductTypeDiscountId");

                    b.HasIndex("DiscountId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("productTypeDiscount");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeFinishedFormat", b =>
                {
                    b.Property<int>("ProductTypeFinishedFormatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FinishedFormatId")
                        .HasColumnType("int");

                    b.Property<double>("FinishedFormatPrice")
                        .HasColumnType("double");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductTypeFinishedFormatId");

                    b.HasIndex("FinishedFormatId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("productTypeFinishedFormat");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeFinishing", b =>
                {
                    b.Property<int>("ProductTypeFinishingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FinishingId")
                        .HasColumnType("int");

                    b.Property<double>("FinishingPrice")
                        .HasColumnType("double");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductTypeFinishingId");

                    b.HasIndex("FinishingId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("productTypeFinishing");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeMaterial", b =>
                {
                    b.Property<int>("ProductTypeMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<double>("MaterialPrice")
                        .HasColumnType("double");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductTypeMaterialId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("productTypeMaterial");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeOption", b =>
                {
                    b.Property<int>("ProductTypeOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OptionId")
                        .HasColumnType("int");

                    b.Property<double>("OptionPrice")
                        .HasColumnType("double");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductTypeOptionId");

                    b.HasIndex("OptionId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("productTypeOption");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypePDF", b =>
                {
                    b.Property<int>("ProductTypePDFId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PDFId")
                        .HasColumnType("int");

                    b.Property<double>("PDFPrice")
                        .HasColumnType("double");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductTypePDFId");

                    b.HasIndex("PDFId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("productTypePDF");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypePage", b =>
                {
                    b.Property<int>("ProductTypePageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PageId")
                        .HasColumnType("int");

                    b.Property<double>("PagePrice")
                        .HasColumnType("double");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductTypePageId");

                    b.HasIndex("PageId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("productTypePages");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeQuantity", b =>
                {
                    b.Property<int>("ProductTypeQuantityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityId")
                        .HasColumnType("int");

                    b.HasKey("ProductTypeQuantityId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("QuantityId");

                    b.ToTable("productTypeQuantity");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeRefinement", b =>
                {
                    b.Property<int>("ProductTypeRefinementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("RefinementId")
                        .HasColumnType("int");

                    b.Property<double>("RefinementPrice")
                        .HasColumnType("double");

                    b.HasKey("ProductTypeRefinementId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("RefinementId");

                    b.ToTable("productTypeRefinement");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductViewModel", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CategoryName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("ProductBasePrice")
                        .HasColumnType("double");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductImage")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ProductName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ProductTypeName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CategoryId");

                    b.ToTable("productViewModels");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Quantity", b =>
                {
                    b.Property<int>("QuantityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("QuantityName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("QuantityId");

                    b.ToTable("quantity");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Refinement", b =>
                {
                    b.Property<int>("RefinementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RefinementName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("RefinementId");

                    b.ToTable("refinement");
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Cart", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Customer", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.CustomerBillingDetails", "CustomerBillingDetails")
                        .WithMany()
                        .HasForeignKey("CustomerBillingDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.CustomerShippingDetails", "CustomerShippingDetails")
                        .WithMany()
                        .HasForeignKey("CustomerShippingDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Order", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.OrderDetails", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Payment", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.Product", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeBookBinding", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.BookBinding", "BookBinding")
                        .WithMany()
                        .HasForeignKey("BookBindingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeColor", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeDesignService", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.DesignService", "DesignService")
                        .WithMany()
                        .HasForeignKey("DesignServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeDiscount", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.Discount", "Discount")
                        .WithMany()
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeFinishedFormat", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.FinishedFormat", "FinishedFormat")
                        .WithMany()
                        .HasForeignKey("FinishedFormatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeFinishing", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.Finishing", "Finishing")
                        .WithMany()
                        .HasForeignKey("FinishingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeMaterial", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeOption", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.Option", "Option")
                        .WithMany()
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypePDF", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.PDF", "PDF")
                        .WithMany()
                        .HasForeignKey("PDFId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypePage", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.Pages", "Pages")
                        .WithMany()
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeQuantity", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.Quantity", "Quantity")
                        .WithMany()
                        .HasForeignKey("QuantityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Design2PrintAPIServer.Models.ProductTypeRefinement", b =>
                {
                    b.HasOne("Design2PrintAPIServer.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Design2PrintAPIServer.Models.Refinement", "Refinement")
                        .WithMany()
                        .HasForeignKey("RefinementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
