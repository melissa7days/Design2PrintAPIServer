using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Design2PrintAPIServer.Models
{
    public class ProductTypeBookBinding
    {
        [Key]
        public int ProductTypeBookBindingId { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        [ForeignKey("BookBinding")]
        public int BookBindingId { get; set; }
        public double BookBindingPrice { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual BookBinding BookBinding { get; set; }
    }
}
