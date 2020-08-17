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
        public DbSet<Option> option { get; set; }
        public DbSet<ProductTypeOption> productTypeOption { get; set; }
        public DbSet<Pages> pages { get; set; }
        public DbSet<ProductTypePage> productTypePages { get; set; }
        public DbSet<Discount> discount { get; set; }
        public DbSet<ProductTypeDiscount> productTypeDiscount { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<CustomerShippingDetails> customerShippingDetails { get; set; }
        public DbSet<CustomerBillingDetails> customerBillingDetails { get; set; }
        public DbSet<Cart> cart { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }
        public DbSet<Payment> payment { get; set; }
        public DbSet<ProductViewModel> productViewModels { get; set; }
        public DbSet<ProductByIdViewModel> productByIdViewModels { get; set; }
        public DbSet<CategoryViewModel> categoryViewModels { get; set; }
    }
}
