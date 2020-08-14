using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class ProductTypeQuantity
    {
        [Key]
        public int ProductTypeQuantityId { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        [ForeignKey("Quantity")]
        public int QuantityId { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Quantity Quantity { get; set; }
    }
}
