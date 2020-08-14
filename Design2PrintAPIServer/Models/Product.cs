using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        public string ProductName { get; set; }
        public double ProductBasePrice { get; set; }
        public string ProductImage { get; set; }
        public virtual Category Category { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
