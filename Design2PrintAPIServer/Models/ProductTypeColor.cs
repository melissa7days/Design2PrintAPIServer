using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class ProductTypeColor
    {
        [Key]
        public int ProductTypeColorId { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        [ForeignKey("Color")]
        public int ColorId { get; set; }
        public double ColorPrice { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Color Color { get; set; }
    }
}
