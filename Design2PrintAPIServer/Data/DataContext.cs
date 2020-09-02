using Design2PrintAPIServer.Models;
using Design2PrintAPIServer.Models.CustomModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Product> product { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<ProductType> productType { get; set; }
        public DbSet<Quantity> quantity { get; set; }
        public DbSet<ProductTypeQuantity> productTypeQuantity { get; set; }
        public DbSet<DesignService> designService { get; set; }
        public DbSet<ProductTypeDesignService> productTypeDesignService { get; set; }
        public DbSet<FinishedFormat> finishedFormat { get; set; }
        public DbSet<ProductTypeFinishedFormat> productTypeFinishedFormat { get; set; }
        public DbSet<Material> material { get; set; }
        public DbSet<ProductTypeMaterial> productTypeMaterial { get; set; }
        public DbSet<Color> color { get; set; }
        public DbSet<ProductTypeColor> productTypeColor { get;set; }
        public DbSet<Refinement> refinement { get; set; }
        public DbSet<ProductTypeRefinement> productTypeRefinement { get; set; }
        public DbSet<BookBinding> bookBinding { get; set; }
        public DbSet<ProductTypeBookBinding> productTypeBookBinding { get; set; }
        public DbSet<Finishing> finishing { get; set; }
        public DbSet<ProductTypeFinishing> productTypeFinishing { get; set; }
        public DbSet<PDF> pdf { get; set; }
        public DbSet<ProductTypePDF> productTypePDF { get; set; }
        public DbSet<Options> option { get; set; }
        public DbSet<ProductTypeOption> productTypeOption { get; set; }
        public DbSet<Pages> pages { get; set; }
        public DbSet<ProductTypePage> productTypePages { get; set; }
        public DbSet<Discount> discount { get; set; }
        public DbSet<ProductTypeDiscount> productTypeDiscount { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<CustomerShippingDetails> customerShippingDetail { get; set; }
        public DbSet<CustomerBillingDetails> customerBillingDetail { get; set; }
        public DbSet<Cart> cart { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }
        public DbSet<Payment> payment { get; set; }
        public DbSet<ProductViewModel> productViewModel { get; set; }
        public DbSet<ProductByIdViewModel> productByIdViewModel { get; set; }
        public DbSet<ProductTypeQuantityViewModel> productTypeQuantityViewModel { get; set; }
        public DbSet<ProductTypeDesignServiceViewModel> productTypeDesignServiceViewModel { get; set; }
        public DbSet<ProductTypeFinishedFormatViewModel> productTypeFinishedFormatViewModel { get; set; }
        public DbSet<ProductTypeMaterialViewModel> productTypeMaterialViewModel { get; set; }
        public DbSet<ProductTypeColorViewModel> productTypeColorViewModel { get; set; }
        public DbSet<ProductTypeRefinementViewModel> productTypeRefinementViewModel { get; set; }
        public DbSet<ProductTypeBookBindingViewModel> productTypeBookBindingViewModel { get; set; }
        public DbSet<ProductTypeFinishingViewModel> productTypeFinishingViewModel { get; set; }
        public DbSet<ProductTypePDFViewModel> productTypePDFViewModel { get; set; }
        public DbSet<ProductTypeOptionsViewModel> productTypeOptionsViewModel { get; set; }
        public DbSet<ProductTypePageViewModel> productTypePageViewModel { get; set; }
        public DbSet<ProductTypeDiscountViewModel> productTypeDiscountViewModels { get; set; }
    }
}
