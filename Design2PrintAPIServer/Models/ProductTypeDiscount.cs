using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class ProductTypeDiscount
    {
        [Key]
        public int ProductTypeDiscountId { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        [ForeignKey("Discount")]
        public int DiscountId { get; set; }
        public double DiscountPrice { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Discount Discount { get; set; }
    }
}
